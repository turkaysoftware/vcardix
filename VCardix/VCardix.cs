// ======================================================================================================
// VCardix - vCard and CSV Contact Manager Software
// © Copyright 2025, Eray Türkay.
// Project Type: Open Source
// License: MIT License
// Website: https://www.turkaysoftware.com/vcardix
// GitHub: https://github.com/turkaysoftware/vcardix
// ======================================================================================================

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
// TS MODULES
using static VCardix.TSModules;
using static VCardix.VCardixModule;

namespace VCardix{
    public partial class VCardix : Form{
        // VCARD MANAGER
        // ======================================================================================================
        readonly VCardixModule VCardManager = new VCardixModule();
        public VCardix(){
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            ContactUserImage.SizeMode = PictureBoxSizeMode.Zoom;
            //
            vcard30ToolStripMenuItem.Checked = true;
            sortingFullNameToolStripMenuItem.Checked = true;
            ContactList.DisplayMember = "FullName";
        }
        // GLOBAL VARIABLES
        // ======================================================================================================
        public static string lang, lang_path;
        public static int theme;
        // LOCAL VARIABLES
        // ======================================================================================================
        private int startup_status;
        private readonly int i_upload_size = 7;
        bool save_status = true;
        readonly string ts_wizard_name = "TS Wizard";
        // ======================================================================================================
        // COLOR MODES
        static readonly List<Color> header_colors = new List<Color>() { Color.Transparent, Color.Transparent, Color.Transparent };
        // HEADER SETTINGS
        // ======================================================================================================
        private class HeaderMenuColors : ToolStripProfessionalRenderer{
            public HeaderMenuColors() : base(new HeaderColors()) { }
            protected override void OnRenderArrow(ToolStripArrowRenderEventArgs e) { e.ArrowColor = header_colors[1]; base.OnRenderArrow(e); }
            protected override void OnRenderItemCheck(ToolStripItemImageRenderEventArgs e){
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                float dpiScale = g.DpiX / 96f;
                // TICK BG
                // using (SolidBrush bgBrush = new SolidBrush(header_colors[0])){ RectangleF bgRect = new RectangleF( e.ImageRectangle.Left, e.ImageRectangle.Top, e.ImageRectangle.Width,e.ImageRectangle.Height); g.FillRectangle(bgBrush, bgRect); }
                using (Pen anti_alias_pen = new Pen(header_colors[2], 3 * dpiScale)){
                    Rectangle rect = e.ImageRectangle;
                    Point p1 = new Point((int)(rect.Left + 3 * dpiScale), (int)(rect.Top + rect.Height / 2));
                    Point p2 = new Point((int)(rect.Left + 7 * dpiScale), (int)(rect.Bottom - 4 * dpiScale));
                    Point p3 = new Point((int)(rect.Right - 2 * dpiScale), (int)(rect.Top + 3 * dpiScale));
                    g.DrawLines(anti_alias_pen, new Point[] { p1, p2, p3 });
                }
            }
        }
        private class HeaderColors : ProfessionalColorTable{
            public override Color MenuItemSelected => header_colors[0];
            public override Color ToolStripDropDownBackground => header_colors[0];
            public override Color ImageMarginGradientBegin => header_colors[0];
            public override Color ImageMarginGradientEnd => header_colors[0];
            public override Color ImageMarginGradientMiddle => header_colors[0];
            public override Color MenuItemSelectedGradientBegin => header_colors[0];
            public override Color MenuItemSelectedGradientEnd => header_colors[0];
            public override Color MenuItemPressedGradientBegin => header_colors[0];
            public override Color MenuItemPressedGradientMiddle => header_colors[0];
            public override Color MenuItemPressedGradientEnd => header_colors[0];
            public override Color MenuItemBorder => header_colors[0];
            public override Color CheckBackground => header_colors[0];
            public override Color ButtonSelectedBorder => header_colors[0];
            public override Color CheckSelectedBackground => header_colors[0];
            public override Color CheckPressedBackground => header_colors[0];
            public override Color MenuBorder => header_colors[0];
            public override Color SeparatorLight => header_colors[1];
            public override Color SeparatorDark => header_colors[1];
        }
        // LOAD SOFTWARE SETTINGS
        // ======================================================================================================
        private void RunSoftwareEngine(){
            // DOUBLE BUFFER TABLE
            typeof(ListBox).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, ContactList, new object[] { true });

            // THEME - LANG - STARTUP MODE PRELOADER
            // ======================================================================================================
            TSSettingsSave software_read_settings = new TSSettingsSave(ts_sf);
            //
            int theme_mode = int.TryParse(software_read_settings.TSReadSettings(ts_settings_container, "ThemeStatus"), out int the_status) ? the_status : 1;
            Theme_engine(theme_mode);
            darkThemeToolStripMenuItem.Checked = theme_mode == 0;
            lightThemeToolStripMenuItem.Checked = theme_mode == 1;
            string lang_mode = software_read_settings.TSReadSettings(ts_settings_container, "LanguageStatus");
            var languageFiles = new Dictionary<string, (object langResource, ToolStripMenuItem menuItem, bool fileExists)>{
                { "en", (ts_lang_en, englishToolStripMenuItem, File.Exists(ts_lang_en)) },
                { "tr", (ts_lang_tr, turkishToolStripMenuItem, File.Exists(ts_lang_tr)) },
            };
            foreach (var langLoader in languageFiles) { langLoader.Value.menuItem.Enabled = langLoader.Value.fileExists; }
            var (langResource, selectedMenuItem, _) = languageFiles.ContainsKey(lang_mode) ? languageFiles[lang_mode] : languageFiles["en"];
            Lang_engine(Convert.ToString(langResource), lang_mode);
            selectedMenuItem.Checked = true;
            //
            string startup_mode = software_read_settings.TSReadSettings(ts_settings_container, "StartupStatus");
            startup_status = int.TryParse(startup_mode, out int ini_status) && (ini_status == 0 || ini_status == 1) ? ini_status : 0;
            WindowState = startup_status == 1 ? FormWindowState.Maximized : FormWindowState.Normal;
            windowedToolStripMenuItem.Checked = startup_status == 0;
            fullScreenToolStripMenuItem.Checked = startup_status == 1;
            //
            BtnOpenAdressWindow.Height = textBoxAddress.Height;
        }
        // MAIN TOOLTIP SETTINGS
        // ======================================================================================================
        private void MainToolTip_Draw(object sender, DrawToolTipEventArgs e){ e.DrawBackground(); e.DrawBorder(); e.DrawText(); }
        // VCARDIX LOAD
        // ====================================================================================================== 
        private void VCardix_Load(object sender, EventArgs e){
            Text = TS_VersionEngine.TS_SofwareVersion(0, Program.ts_version_mode);
            HeaderMenu.Cursor = Cursors.Hand;
            RunSoftwareEngine();
            //
            Task softwareUpdateCheck = Task.Run(() => Software_update_check(0));
        }
        // GET PERSON DATA FROM INPUTS
        // ====================================================================================================== 
        private PrefixModule GetContactFromInputs(){
            var contact = new PrefixModule{
                FirstName = textBoxFirstName.Text.Trim(),
                MiddleName = textBoxMiddleName.Text.Trim(),
                LastName = textBoxLastName.Text.Trim(),
                Birthday = dateTimePickerBirthday.Checked ? (DateTime?)dateTimePickerBirthday.Value.Date : null,
                PhoneMobile = textBoxPhoneMobile.Text.Trim(),
                PhoneHome = textBoxPhoneHome.Text.Trim(),
                PhoneWork = textBoxPhoneWork.Text.Trim(),
                Email1 = textBoxEmail1.Text.Trim(),
                Email2 = textBoxEmail2.Text.Trim(),
                Email3 = textBoxEmail3.Text.Trim(),
                Address = textBoxAddress.Text.Trim(),
                Organization = textBoxOrganization.Text.Trim(),
                Website = textBoxWebsite.Text.Trim(),
                Note = textBoxNote.Text.Trim(),
                PhotoBase64 = (ContactList.SelectedItem as PrefixModule)?.PhotoBase64
            };
            return contact;
        }
        // REFRESH CONTACT LIST
        // ====================================================================================================== 
        private void RefreshList(){
            ContactList.Items.Clear();
            foreach (var c in VCardManager.ContactsList.OrderBy(c => TSNaturalSortKey(c.FullName, CultureInfo.CurrentCulture))){
                ContactList.Items.Add(c);
            }
            if (ContactList.Items.Count > 0){
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                statusLabel.Text = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_bottom_ready"), ContactList.Items.Count.ToString());
                BottomTickPanel.Visible = true;
            }else{
                statusLabel.Text = string.Empty;
                BottomTickPanel.Visible = false;
            }
        }
        // CLEAR UI
        // ====================================================================================================== 
        private void CleanUI(){
            textBoxSearch.Text = string.Empty;
            //
            textBoxFirstName.Text = string.Empty;
            textBoxMiddleName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            //
            dateTimePickerBirthday.Value = DateTime.Now;
            dateTimePickerBirthday.Checked = false;
            //
            textBoxPhoneMobile.Text = string.Empty;
            textBoxPhoneHome.Text = string.Empty;
            textBoxPhoneWork.Text = string.Empty;
            //
            textBoxEmail1.Text = string.Empty;
            textBoxEmail2.Text = string.Empty;
            textBoxEmail3.Text = string.Empty;
            //
            textBoxAddress.Text = string.Empty;
            textBoxOrganization.Text = string.Empty;
            textBoxWebsite.Text = string.Empty;
            textBoxNote.Text = string.Empty;
            //
            TSImageHelper.SetPictureBoxImage(ContactUserImage, null);
        }
        // CONTACT PERSON CHANGE
        // ====================================================================================================== 
        private void ContactList_SelectedIndexChanged(object sender, EventArgs e){
            if (ContactList.SelectedItem is PrefixModule c){
                textBoxFirstName.Text = c.FirstName;
                textBoxMiddleName.Text = c.MiddleName;
                textBoxLastName.Text = c.LastName;
                //
                if (c.Birthday.HasValue){
                    dateTimePickerBirthday.Value = c.Birthday.Value;
                    dateTimePickerBirthday.Checked = true;
                }else{
                    dateTimePickerBirthday.Value = DateTime.Now;
                    dateTimePickerBirthday.Checked = false;
                }
                //
                textBoxPhoneMobile.Text = c.PhoneMobile;
                textBoxPhoneHome.Text = c.PhoneHome;
                textBoxPhoneWork.Text = c.PhoneWork;
                //
                textBoxEmail1.Text = c.Email1;
                textBoxEmail2.Text = c.Email2;
                textBoxEmail3.Text = c.Email3;
                //
                textBoxAddress.Text = c.Address;
                textBoxOrganization.Text = c.Organization;
                textBoxWebsite.Text = c.Website;
                textBoxNote.Text = c.Note;
                //
                TSImageHelper.SetPictureBoxImage(ContactUserImage, c.PhotoImage);
            }else{
                TSImageHelper.SetPictureBoxImage(ContactUserImage, null);
            }
        }
        // ADD NEW PERSON
        // ====================================================================================================== 
        private void BtnAdd_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (!string.IsNullOrEmpty(textBoxFirstName.Text.Trim())){
                VCardManager.AddContact(GetContactFromInputs());
                RefreshList();
                CleanUI();
                save_status = false;
                TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_new_person_add_success"));
            }else{
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_new_person_add_warning"));
            }
        }
        // UPDATE PERSON
        // ====================================================================================================== 
        private void BtnUpdate_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ContactList.SelectedItem is PrefixModule selected){
                DialogResult update_warning = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_update_person_query"), selected.FirstName));
                if (update_warning == DialogResult.Yes){
                    if (VCardManager.UpdateContact(selected.Id, GetContactFromInputs())){
                        RefreshList();
                        CleanUI();
                        save_status = false;
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_update_person_success"));
                    }else{
                        TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_person_not_found"));
                    }
                }
            }else{
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_update_person_process_warning"));
            }
        }
        // DELETE PERSON
        // ====================================================================================================== 
        private void BtnDelete_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ContactList.SelectedItem is PrefixModule selected){
                var delete_warning = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_delete_person_query"), selected.FirstName));
                if (delete_warning == DialogResult.Yes){
                    try{
                        VCardManager.DeleteContact(selected.Id);
                        RefreshList();
                        CleanUI();
                        save_status = false;
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_delete_person_success"));
                    }catch (Exception ex){
                        TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_delete_failed"), "\n\n", ex.Message));
                    }
                }
            }else{
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_delete_person_process_warning"));
            }
        }
        // ADD PERSON IMAGE
        // ====================================================================================================== 
        private void ContactUserImage_MouseUp(object sender, MouseEventArgs e){
            if (e.Button != MouseButtons.Right && e.Button != MouseButtons.Left){ return; }
            //
            cxImageSelectToolStripMenuItem.Enabled = ContactList.SelectedItem is PrefixModule;
            bool hasImage = ContactUserImage.Image != null;
            cxViewImageToolStripMenuItem.Enabled = hasImage;
            cxRemoveImageToolStripMenuItem.Enabled = hasImage;
            //
            CXImageMenu.Show(ContactUserImage, e.Location);
        }
        private void CxImageSelectToolStripMenuItem_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            using (OpenFileDialog ofd = new OpenFileDialog()){
                ofd.Title = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_select_image"), Application.ProductName);
                ofd.Filter = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_image_filter"), "|*.jpg;*.jpeg;*.png;*.bmp;*.tif;*.tiff");
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofd.RestoreDirectory = true;
                ofd.CheckFileExists = true;
                ofd.Multiselect = false;
                if (ofd.ShowDialog() == DialogResult.OK){
                    AddImageToSelectedContact(ofd.FileName);
                }
            }
        }
        private void CxRemoveImageToolStripMenuItem_Click(object sender, EventArgs e){
            if (ContactList.SelectedItem is PrefixModule selected){
                selected.ClearPhoto();
                TSImageHelper.SetPictureBoxImage(ContactUserImage, null);
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_image_remove_success"));
            }
        }
        private void AddImageToSelectedContact(string imagePath){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ContactList.Items.Count == 0){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_image_person_not_added_warning"));
                return;
            }
            if (!(ContactList.SelectedItem is PrefixModule selected)){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_image_person_not_select_warning"));
                return;
            }
            FileInfo fi = new FileInfo(imagePath);
            long maxFileSize = i_upload_size * 1024 * 1024;
            if (fi.Length > maxFileSize){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_image_size_limit_warning"), i_upload_size));
                return;
            }
            try{
                using (var originalImage = Image.FromFile(imagePath))
                using (var ms = new MemoryStream()){
                    originalImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    string base64 = Convert.ToBase64String(ms.ToArray());
                    selected.ClearPhoto();
                    selected.PhotoBase64 = base64;
                    TSImageHelper.SetPictureBoxImage(ContactUserImage, selected.PhotoImage);
                    TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_image_import_success"));
                }
            }catch (Exception ex){
                TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_image_import_failed"), "\n\n", ex.Message));
            }
        }
        // DYNAMIC SEARCH
        // ====================================================================================================== 
        private void TextBoxSearch_TextChanged(object sender, EventArgs e){
            try{
                var results = VCardManager.SearchContacts(textBoxSearch.Text.Trim());
                ContactList.Items.Clear();
                foreach (var c in results){
                    ContactList.Items.Add(c);
                }
            }catch (Exception){ }
        }
        // vCARD VERSION CHANGER
        // ====================================================================================================== 
        private VCardVersion VCardVersionChanger(VCardVersion? setVersion = null){
            if (setVersion.HasValue){
                vcard21ToolStripMenuItem.Checked = (setVersion.Value == VCardVersion.V21);
                vcard30ToolStripMenuItem.Checked = (setVersion.Value == VCardVersion.V30);
                vcard40ToolStripMenuItem.Checked = (setVersion.Value == VCardVersion.V40);
                return setVersion.Value;
            }else{
                if (vcard21ToolStripMenuItem.Checked) return VCardVersion.V21;
                if (vcard30ToolStripMenuItem.Checked) return VCardVersion.V30;
                if (vcard40ToolStripMenuItem.Checked) return VCardVersion.V40;
                return VCardVersion.V30;
            }
        }
        // HEADER vCARD VERSION CHANGER
        // ====================================================================================================== 
        private void Vcard21ToolStripMenuItem_Click(object sender, EventArgs e){
            VCardManager.CurrentVersion = VCardVersion.V21;
            UpdateMenuChecks(vcard21ToolStripMenuItem);
        }
        private void Vcard30ToolStripMenuItem_Click(object sender, EventArgs e){
            VCardManager.CurrentVersion =   VCardVersion.V30;
            UpdateMenuChecks(vcard30ToolStripMenuItem);
        }
        private void Vcard40ToolStripMenuItem_Click(object sender, EventArgs e){
            VCardManager.CurrentVersion = VCardVersion.V40;
            UpdateMenuChecks(vcard40ToolStripMenuItem);
        }
        private void UpdateMenuChecks(ToolStripMenuItem selectedItem){
            vcard21ToolStripMenuItem.Checked = false;
            vcard30ToolStripMenuItem.Checked = false;
            vcard40ToolStripMenuItem.Checked = false;
            selectedItem.Checked = true;
        }
        // SORTING MODE CHANGER
        // ====================================================================================================== 
        private void SortingFullNameToolStripMenuItem_Click(object sender, EventArgs e){
            UpdateSortringMenuChecks(sortingFullNameToolStripMenuItem);
            RefreshContactList("FullName", c => c.FullName);
        }
        private void SortingFirstNameToolStripMenuItem_Click(object sender, EventArgs e){
            UpdateSortringMenuChecks(sortingFirstNameToolStripMenuItem);
            RefreshContactList("FirstName", c => c.FirstName);
        }
        private void SortingLastNameToolStripMenuItem_Click(object sender, EventArgs e){
            UpdateSortringMenuChecks(sortingLastNameToolStripMenuItem);
            RefreshContactList("LastName", c => c.LastName);
        } 
        private void RefreshContactList(string displayMember, Func<PrefixModule, string> orderBySelector){
            var selectedContact = ContactList.SelectedItem as PrefixModule;
            Guid? selectedId = selectedContact?.Id;
            //
            ContactList.DisplayMember = displayMember;
            ContactList.Items.Clear();
            //
            foreach (var c in VCardManager.ContactsList.OrderBy(c => TSNaturalSortKey(orderBySelector(c), CultureInfo.CurrentCulture))){
                ContactList.Items.Add(c);
            }
            if (selectedId.HasValue){
                for (int i = 0; i < ContactList.Items.Count; i++){
                    if (((PrefixModule)ContactList.Items[i]).Id == selectedId.Value){
                        ContactList.SelectedIndex = i;
                        break;
                    }
                }
            }
        }
        private void UpdateSortringMenuChecks(ToolStripMenuItem selectedItem){
            sortingFullNameToolStripMenuItem.Checked = false;
            sortingFirstNameToolStripMenuItem.Checked = false;
            sortingLastNameToolStripMenuItem.Checked = false;
            selectedItem.Checked = true;
        }
        // IMPORT FILE & DRAG AND DROP
        // ====================================================================================================== 
        private void VCardix_DragEnter(object sender, DragEventArgs e){
            if (e.Data.GetDataPresent(DataFormats.FileDrop)){
                e.Effect = DragDropEffects.Copy;
            }
        }
        private void VCardix_DragDrop(object sender, DragEventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] drop_files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (drop_files.Length == 0) return;
            string drop_file = drop_files[0];
            string ext = Path.GetExtension(drop_file).ToLower();
            string[] imageExtensions = { ".jpg", ".jpeg", ".png", ".bmp", ".tif", ".tiff" };
            try{
                if (imageExtensions.Contains(ext)){
                    AddImageToSelectedContact(drop_file);
                    return;
                }
                if (ext == ".vcf" || ext == ".csv"){
                    if (ContactList.Items.Count > 0){
                        var import_warning = TS_MessageBoxEngine.TS_MessageBox(this, 6, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_import_warning"), "\n\n"));
                        if (import_warning != DialogResult.Yes){ return; }
                    }
                    if (ext == ".vcf"){
                        VCardManager.LoadVcf(drop_file);
                        VCardVersionChanger(VCardManager.CurrentVersion);
                        RefreshList();
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_vcard_import_success"));
                    }else{ // .csv
                        VCardManager.LoadCsv(drop_file);
                        RefreshList();
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_csv_import_success"));
                    }
                    //save_status = false;
                    return;
                }
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_dad_filter"));
            }catch (Exception ex){
                TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_dad_failed"), "\n\n", ex.Message));
            }
        }
        private void OpenAndLoadFile(){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            using (var ofg = new OpenFileDialog()){
                ofg.Title = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_select_file"), Application.ProductName);
                ofg.Filter = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_select_filter"), "(*.vcf;*.csv)|*.vcf;*.csv");
                ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                ofg.RestoreDirectory = true;
                ofg.CheckFileExists = true;
                ofg.Multiselect = false;
                if (ofg.ShowDialog() == DialogResult.OK){
                    try{
                        string ext = Path.GetExtension(ofg.FileName).ToLower();
                        if (ext == ".vcf"){
                            VCardManager.LoadVcf(ofg.FileName);
                            VCardVersionChanger(VCardManager.CurrentVersion);
                            RefreshList();
                            TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_vcard_import_success"));
                        }else if (ext == ".csv"){
                            VCardManager.LoadCsv(ofg.FileName);
                            RefreshList();
                            TS_MessageBoxEngine.TS_MessageBox(this, 1, software_lang.TSReadLangs("VCardixUI", "vcui_csv_import_success"));
                        }
                        //save_status = false;
                    }catch (Exception ex){
                        TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_select_failed"), "\n\n", ex.Message));
                    }
                }
            }
        }
        // EXPORT FILE
        // ====================================================================================================== 
        private void SaveContactsToFile(){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ContactList.Items.Count == 0){
                TS_MessageBoxEngine.TS_MessageBox(this, 2, software_lang.TSReadLangs("VCardixUI", "vcui_export_warning"));
                return;
            }
            using (var dlg = new SaveFileDialog()){
                dlg.FileName = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_export_name"), Application.ProductName, DateTime.Now.ToString("ddMMyyyy_HHmm"), Path.GetRandomFileName().Replace(".", "").Substring(0, 7));
                dlg.Title = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_export_file"), Application.ProductName);
                dlg.Filter = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_export_filter"), "(*.vcf)|*.vcf|", "(*.csv)|*.csv");
                dlg.DefaultExt = "vcf";
                dlg.RestoreDirectory = true;
                dlg.OverwritePrompt = true;
                dlg.AddExtension = true;
                dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (dlg.ShowDialog() == DialogResult.OK){
                    try{
                        string ext = Path.GetExtension(dlg.FileName).ToLower();
                        if (ext == ".vcf"){
                            VCardManager.CurrentVersion = VCardVersionChanger();
                            VCardManager.SaveVcf(dlg.FileName);
                            DialogResult save_aof_warning = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_vcard_export_success"), dlg.FileName, "\n\n"));
                            if (save_aof_warning == DialogResult.Yes){
                                Process.Start(new ProcessStartInfo("explorer.exe", $"/select,\"{dlg.FileName}\"") { UseShellExecute = true });
                            }
                        }else if (ext == ".csv"){
                            VCardManager.SaveCsv(dlg.FileName);
                            DialogResult save_aof_warning = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_csv_export_success"), dlg.FileName, "\n\n"));
                            if (save_aof_warning == DialogResult.Yes){
                                Process.Start(new ProcessStartInfo("explorer.exe", $"/select,\"{dlg.FileName}\"") { UseShellExecute = true });
                            }
                        }
                        save_status = true;
                    }catch (Exception ex){
                        TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_export_failed"), "\n\n", ex.Message));
                    }
                }
            }
        }
        // IMPORT HEADER BTN CLICK
        // ====================================================================================================== 
        private void ImportFileToolStripMenuItem_Click(object sender, EventArgs e){
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            if (ContactList.Items.Count > 0){
                var import_warning = TS_MessageBoxEngine.TS_MessageBox(this, 6, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_import_warning"), "\n\n"));
                if (import_warning == DialogResult.Yes){
                    OpenAndLoadFile();
                }
            }else{
                OpenAndLoadFile();
            }
        }
        // EXPORT HEADER BTN CLICK
        // ====================================================================================================== 
        private void ExportFileToolStripMenuItem_Click(object sender, EventArgs e){
            SaveContactsToFile();
        }
        // THEME MODE
        // ======================================================================================================
        private void Select_theme_active(object target_theme){
            ToolStripMenuItem selected_theme = null;
            Select_theme_deactive();
            if (target_theme != null){
                if (selected_theme != (ToolStripMenuItem)target_theme){
                    selected_theme = (ToolStripMenuItem)target_theme;
                    selected_theme.Checked = true;
                }
            }
        }
        private void Select_theme_deactive(){
            foreach (ToolStripMenuItem disabled_theme in themeToolStripMenuItem.DropDownItems){
                disabled_theme.Checked = false;
            }
        }
        private void LightThemeToolStripMenuItem_Click(object sender, EventArgs e){
            if (theme != 1){ Theme_engine(1); Select_theme_active(sender); }
        }
        private void DarkThemeToolStripMenuItem_Click(object sender, EventArgs e){
            if (theme != 0){ Theme_engine(0); Select_theme_active(sender); }
        }
        // THEME ENGINE
        // ======================================================================================================
        private void Theme_engine(int ts){
            try{
                theme = ts;
                int set_attribute = theme == 1 ? 20 : 19;
                if (DwmSetWindowAttribute(Handle, set_attribute, new[] { 1 }, 4) != theme){
                    DwmSetWindowAttribute(Handle, 20, new[] { theme == 1 ? 0 : 1 }, 4);
                }
                if (theme == 1){
                    // FILE
                    TSImageRenderer(fileToolStripMenuItem, Properties.Resources.tm_file_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(importFileToolStripMenuItem, Properties.Resources.tm_import_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(exportFileToolStripMenuItem, Properties.Resources.tm_export_light, 0, ContentAlignment.MiddleRight);
                    // VCARD VERSION
                    TSImageRenderer(vCardVersionToolStripMenuItem, Properties.Resources.tm_vcard_light, 0, ContentAlignment.MiddleRight);
                    // SORTING MODE
                    TSImageRenderer(sortingModeToolStripMenuItem, Properties.Resources.tm_sorting_mode_light, 0, ContentAlignment.MiddleRight);
                    // SETTINGS
                    TSImageRenderer(settingsToolStripMenuItem, Properties.Resources.tm_settings_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(themeToolStripMenuItem, Properties.Resources.tm_theme_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(languageToolStripMenuItem, Properties.Resources.tm_language_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(startupToolStripMenuItem, Properties.Resources.tm_startup_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(checkForUpdateToolStripMenuItem, Properties.Resources.tm_update_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(tSWizardToolStripMenuItem, Properties.Resources.tm_ts_wizard_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(bmacToolStripMenuItem, Properties.Resources.tm_bmac_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(aboutToolStripMenuItem, Properties.Resources.tm_about_light, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BtnAdd, Properties.Resources.ct_add_light, 16, ContentAlignment.MiddleLeft);
                    TSImageRenderer(BtnUpdate, Properties.Resources.ct_update_light, 16, ContentAlignment.MiddleLeft);
                    TSImageRenderer(BtnDelete, Properties.Resources.ct_delete_light, 16, ContentAlignment.MiddleLeft);
                    //
                    TSImageRenderer(BtnOpenAdressWindow, Properties.Resources.ct_adress_window_light, 10, ContentAlignment.MiddleCenter);
                    // PHOTO MODE
                    TSImageRenderer(cxImageSelectToolStripMenuItem, Properties.Resources.ct_select_image_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(cxViewImageToolStripMenuItem, Properties.Resources.ct_show_image_light, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(cxRemoveImageToolStripMenuItem, Properties.Resources.ct_delete_image_light, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BottomImage, Properties.Resources.ct_confirm_dark, 0, ContentAlignment.MiddleCenter);
                }else if (theme == 0){
                    // FILE
                    TSImageRenderer(fileToolStripMenuItem, Properties.Resources.tm_file_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(importFileToolStripMenuItem, Properties.Resources.tm_import_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(exportFileToolStripMenuItem, Properties.Resources.tm_export_dark, 0, ContentAlignment.MiddleRight);
                    // VCARD VERSION
                    TSImageRenderer(vCardVersionToolStripMenuItem, Properties.Resources.tm_vcard_dark, 0, ContentAlignment.MiddleRight);
                    // SORTING MODE
                    TSImageRenderer(sortingModeToolStripMenuItem, Properties.Resources.tm_sorting_mode_dark, 0, ContentAlignment.MiddleRight);
                    // SETTINGS
                    TSImageRenderer(settingsToolStripMenuItem, Properties.Resources.tm_settings_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(themeToolStripMenuItem, Properties.Resources.tm_theme_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(languageToolStripMenuItem, Properties.Resources.tm_language_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(startupToolStripMenuItem, Properties.Resources.tm_startup_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(checkForUpdateToolStripMenuItem, Properties.Resources.tm_update_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(tSWizardToolStripMenuItem, Properties.Resources.tm_ts_wizard_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(bmacToolStripMenuItem, Properties.Resources.tm_bmac_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(aboutToolStripMenuItem, Properties.Resources.tm_about_dark, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BtnAdd, Properties.Resources.ct_add_dark, 16, ContentAlignment.MiddleLeft);
                    TSImageRenderer(BtnUpdate, Properties.Resources.ct_update_dark, 16, ContentAlignment.MiddleLeft);
                    TSImageRenderer(BtnDelete, Properties.Resources.ct_delete_dark, 16, ContentAlignment.MiddleLeft);
                    //
                    TSImageRenderer(BtnOpenAdressWindow, Properties.Resources.ct_adress_window_dark, 10, ContentAlignment.MiddleCenter);
                    // PHOTO MODE
                    TSImageRenderer(cxImageSelectToolStripMenuItem, Properties.Resources.ct_select_image_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(cxViewImageToolStripMenuItem, Properties.Resources.ct_show_image_dark, 0, ContentAlignment.MiddleRight);
                    TSImageRenderer(cxRemoveImageToolStripMenuItem, Properties.Resources.ct_delete_image_dark, 0, ContentAlignment.MiddleRight);
                    //
                    TSImageRenderer(BottomImage, Properties.Resources.ct_confirm_light, 0, ContentAlignment.MiddleCenter);
                }
                // HEADER
                header_colors[0] = TS_ThemeEngine.ColorMode(theme, "HeaderBGColorMain");
                header_colors[1] = TS_ThemeEngine.ColorMode(theme, "HeaderFEColorMain");
                header_colors[2] = TS_ThemeEngine.ColorMode(theme, "AccentColor");
                HeaderMenu.Renderer = new HeaderMenuColors();
                CXImageMenu.Renderer = new HeaderMenuColors();
                // HEADER MENU
                HeaderMenu.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                HeaderMenu.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // TOOLTIP
                MainToolTip.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                MainToolTip.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // HEADER MENU CONTENT
                // FILE
                fileToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                fileToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                importFileToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                importFileToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                exportFileToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                exportFileToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // VCARD VERSION
                vCardVersionToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                vCardVersionToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                vcard21ToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                vcard21ToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                vcard30ToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                vcard30ToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                vcard40ToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                vcard40ToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // SORTING MODE
                sortingModeToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                sortingModeToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                sortingFullNameToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                sortingFullNameToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                sortingFirstNameToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                sortingFirstNameToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                sortingLastNameToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                sortingLastNameToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // SETTINGS
                settingsToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                settingsToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                // THEMES
                themeToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                themeToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                lightThemeToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                lightThemeToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                darkThemeToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                darkThemeToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // LANGS
                languageToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                languageToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                englishToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                englishToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                turkishToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                turkishToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // STARTUP MODE
                startupToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                startupToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                windowedToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                windowedToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                fullScreenToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                fullScreenToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // UPDATE
                checkForUpdateToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                checkForUpdateToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // TS WIZARD
                tSWizardToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                tSWizardToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // BMAC
                bmacToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                bmacToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // ABOUT
                aboutToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                aboutToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // CX
                cxImageSelectToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                cxImageSelectToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                cxViewImageToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                cxViewImageToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                cxRemoveImageToolStripMenuItem.BackColor = TS_ThemeEngine.ColorMode(theme, "HeaderBGColor");
                cxRemoveImageToolStripMenuItem.ForeColor = TS_ThemeEngine.ColorMode(theme, "HeaderFEColor");
                // UI
                BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                //
                lblSearch.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                //
                ContactList.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor");
                ContactList.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                //
                var combinedBtnsControls = BackPanel.Controls.Cast<Control>().Concat(UIPanel.Controls.Cast<Control>());
                foreach (Control ui_controls in combinedBtnsControls)
                {
                    if (ui_controls is Button ui_btn){
                        ui_btn.ForeColor = TS_ThemeEngine.ColorMode(theme, "DynamicThemeActiveBtnBG");
                        ui_btn.BackColor = TS_ThemeEngine.ColorMode(theme, "AccentColor");
                        ui_btn.FlatAppearance.BorderColor = TS_ThemeEngine.ColorMode(theme, "AccentColor");
                        ui_btn.FlatAppearance.MouseDownBackColor = TS_ThemeEngine.ColorMode(theme, "AccentColor");
                        ui_btn.FlatAppearance.MouseOverBackColor = TS_ThemeEngine.ColorMode(theme, "AccentColorHover");
                    }

                    if (ui_controls is TextBox ui_textbox)
                    {
                        ui_textbox.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                        ui_textbox.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                    }
                    if (ui_controls is Label ui_label)
                    {
                        ui_label.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                    }
                }
                textBoxSearch.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor");
                textBoxSearch.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                //
                UIPanel.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor");
             
                dateTimePickerBirthday.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                dateTimePickerBirthday.ButtonColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                dateTimePickerBirthday.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                dateTimePickerBirthday.BorderColor = TS_ThemeEngine.ColorMode(theme, "BorderColor");
                ContactUserImage.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                ContactUserImage.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                //
                FooterPanel.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor");
                FooterPanel.ForeColor = TS_ThemeEngine.ColorMode(theme, "AccentColorText");
                BottomTickPanel.BackColor = TS_ThemeEngine.ColorMode(theme, "UIBGColor2");
                //
                Software_other_page_preloader();
                // SAVE CURRENT THEME
                try{
                    TSSettingsSave software_setting_save = new TSSettingsSave(ts_sf);
                    software_setting_save.TSWriteSettings(ts_settings_container, "ThemeStatus", Convert.ToString(ts));
                }catch (Exception){ }
            }catch (Exception){ }
        }
        // OTHER PAGE DYNAMIC UI
        private void OtherDynamicUI<T>(string formName, Action<T> preloader) where T : Form, new(){
            try{
                T formInstance;
                if (Application.OpenForms[formName] != null){
                    formInstance = (T)Application.OpenForms[formName];
                    preloader(formInstance);
                }else{
                    formInstance = new T{ Name = formName };
                }
            }catch (Exception){ }
        }
        private void Software_other_page_preloader(){
            OtherDynamicUI<VCardixAdressWindow>("vcardix_adress_window", f => f.Adress_window_preloader());
            OtherDynamicUI<VCardixImagePreview>("vcardix_image_preview", f => f.Image_preview_preloader());
            OtherDynamicUI<VCardixAbout>("vcardix_about", f => f.About_preloader());
        }
        // LANG MODE
        // ======================================================================================================
        private void Select_lang_active(object target_lang){
            ToolStripMenuItem selected_lang = null;
            Select_lang_deactive();
            if (target_lang != null){
                if (selected_lang != (ToolStripMenuItem)target_lang){
                    selected_lang = (ToolStripMenuItem)target_lang;
                    selected_lang.Checked = true;
                }
            }
        }
        private void Select_lang_deactive(){
            foreach (ToolStripMenuItem disabled_lang in languageToolStripMenuItem.DropDownItems){
                disabled_lang.Checked = false;
            }
        }
        private void EnglishToolStripMenuItem_Click(object sender, EventArgs e){
            if (lang != "en"){ Lang_preload(ts_lang_en, "en"); Select_lang_active(sender); }
        }
        private void TurkishToolStripMenuItem_Click(object sender, EventArgs e){
            if (lang != "tr"){ Lang_preload(ts_lang_tr, "tr"); Select_lang_active(sender); }
        }
        private void Lang_preload(string lang_type, string lang_code){
            Lang_engine(lang_type, lang_code);
            try{
                TSSettingsSave software_setting_save = new TSSettingsSave(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "LanguageStatus", lang_code);
            }catch (Exception){ }
            // LANG CHANGE NOTIFICATION
            TSGetLangs software_lang = new TSGetLangs(lang_path);
            DialogResult lang_change_message = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("LangChange", "lang_change_notification"), "\n\n", "\n\n"));
            if (lang_change_message == DialogResult.Yes) { Application.Restart(); }
        }
        private void Lang_engine(string lang_type, string lang_code){
            try{
                lang_path = lang_type;
                lang = lang_code;
                // GLOBAL ENGINE
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                // FILE
                fileToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_file");
                importFileToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderFileContent", "header_fc_import");
                exportFileToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderFileContent", "header_fc_export");
                // VCARD VERSION
                vCardVersionToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_vcard_version");
                vcard21ToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderVCardVersion", "header_vcard_21");
                vcard30ToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderVCardVersion", "header_vcard_30");
                vcard40ToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderVCardVersion", "header_vcard_40");
                // SORTING MODE
                sortingModeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_sorting");
                sortingFullNameToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderSortingMode", "header_sm_full");
                sortingFirstNameToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderSortingMode", "header_sm_firstname");
                sortingLastNameToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderSortingMode", "header_sm_lastname");
                // SETTINGS
                settingsToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_settings");
                // THEMES
                themeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_theme");
                lightThemeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderThemes", "theme_light");
                darkThemeToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderThemes", "theme_dark");
                // LANGS
                languageToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_language");
                englishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_en");
                turkishToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderLangs", "lang_tr");
                // STARTUP MODE
                startupToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_start");
                windowedToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderViewMode", "header_viev_mode_windowed");
                fullScreenToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderViewMode", "header_viev_mode_full_screen");
                // UPDATE
                checkForUpdateToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_update");
                // TS WIZARD
                tSWizardToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_ts_wizard");
                // BMAC
                bmacToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_bmac");
                // ABOUT
                aboutToolStripMenuItem.Text = software_lang.TSReadLangs("HeaderMenu", "header_menu_about");
                // CX
                cxImageSelectToolStripMenuItem.Text = software_lang.TSReadLangs("CxImageMenu", "cxim_select");
                cxViewImageToolStripMenuItem.Text = software_lang.TSReadLangs("CxImageMenu", "cxim_view");
                cxRemoveImageToolStripMenuItem.Text = software_lang.TSReadLangs("CxImageMenu", "cxim_remove");
                // UI
                lblSearch.Text = software_lang.TSReadLangs("VCardixUI", "vcui_search");
                BtnAdd.Text = " " + software_lang.TSReadLangs("VCardixUI", "vcui_add");
                BtnUpdate.Text = " " + software_lang.TSReadLangs("VCardixUI", "vcui_update");
                BtnDelete.Text = " " + software_lang.TSReadLangs("VCardixUI", "vcui_delete");
                // UI FORM
                lblFirstName.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_name");
                lblMiddleName.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_sec_name");
                lblLastName.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_surname");
                lblBirthday.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_birthday");
                lblPhoneHome.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_phone_cell");
                lblPhoneHome.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_phone_home");
                lblPhoneWork.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_phone_work");
                lblMail1.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_email_1");
                lblMail2.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_email_2");
                lblMail3.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_email_3");
                lblAdress.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_address");
                lblOrganization.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_organization");
                lblWebsite.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_website");
                lblNote.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_note");
                lblProfileImage.Text = software_lang.TSReadLangs("VCardixUI", "vcui_f_profile_image");
                //
                if (ContactList.Items.Count > 0){
                    statusLabel.Text = string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_bottom_ready"), ContactList.Items.Count.ToString());
                }
                //
                MainToolTip.RemoveAll();
                MainToolTip.SetToolTip(textBoxSearch, software_lang.TSReadLangs("VCardixUI", "vcui_search_hover"));
                MainToolTip.SetToolTip(BtnOpenAdressWindow, software_lang.TSReadLangs("VCardixUI", "vcui_adress_window_hover"));
                MainToolTip.SetToolTip(ContactUserImage, software_lang.TSReadLangs("VCardixUI", "vcui_profile_image_hover"));
            }catch (Exception){ }
        }
        // STARTUP SETINGS
        // ======================================================================================================
        private void Select_startup_mode_active(object target_startup_mode){
            ToolStripMenuItem selected_startup_mode = null;
            Select_startup_mode_deactive();
            if (target_startup_mode != null){
                if (selected_startup_mode != (ToolStripMenuItem)target_startup_mode){
                    selected_startup_mode = (ToolStripMenuItem)target_startup_mode;
                    selected_startup_mode.Checked = true;
                }
            }
        }
        private void Select_startup_mode_deactive(){
            foreach (ToolStripMenuItem disabled_startup in startupToolStripMenuItem.DropDownItems){
                disabled_startup.Checked = false;
            }
        }
        private void WindowedToolStripMenuItem_Click(object sender, EventArgs e){
            if (startup_status != 0){ startup_status = 0; Startup_mode_settings("0"); Select_startup_mode_active(sender); }
        }
        private void FullScreenToolStripMenuItem_Click(object sender, EventArgs e){
            if (startup_status != 1){ startup_status = 1; Startup_mode_settings("1"); Select_startup_mode_active(sender); }
        }
        private void Startup_mode_settings(string get_startup_value){
            try{
                TSSettingsSave software_setting_save = new TSSettingsSave(ts_sf);
                software_setting_save.TSWriteSettings(ts_settings_container, "StartupStatus", get_startup_value);
            }catch (Exception){ }
        }
        // SOFTWARE OPERATION CONTROLLER MODULE
        // ======================================================================================================
        private static bool Software_operation_controller(string __target_software_path){
            var exeFiles = Directory.GetFiles(__target_software_path, "*.exe");
            var runned_process = Process.GetProcesses();
            foreach (var exe_path in exeFiles){
                string exe_name = Path.GetFileNameWithoutExtension(exe_path);
                if (runned_process.Any(p => {
                    try{
                        return string.Equals(p.ProcessName, exe_name, StringComparison.OrdinalIgnoreCase);
                    }catch{
                        return false;
                    }
                })){
                    return true;
                }
            }
            return false;
        }
        // TS WIZARD STARTER MODE
        // ======================================================================================================
        private string[] Ts_wizard_starter_mode(){
            string[] ts_wizard_exe_files = { "TSWizard_arm64.exe", "TSWizard_x64.exe", "TSWizard.exe" };
            if (RuntimeInformation.OSArchitecture == Architecture.Arm64){
                return new[] { ts_wizard_exe_files[0], ts_wizard_exe_files[1], ts_wizard_exe_files[2] }; // arm64 > x64 > default
            }else if (Environment.Is64BitOperatingSystem){
                return new[] { ts_wizard_exe_files[1], ts_wizard_exe_files[0], ts_wizard_exe_files[2] }; // x64 > arm64 > default
            }else{
                return new[] { ts_wizard_exe_files[2], ts_wizard_exe_files[1], ts_wizard_exe_files[0] }; // default > x64 > arm64
            }
        }
        // UPDATE CHECK ENGINE
        // ======================================================================================================
        private void CheckForUpdateToolStripMenuItem_Click(object sender, EventArgs e){
            Software_update_check(1);
        }
        public void Software_update_check(int _check_update_ui){
            try{
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                if (!IsNetworkCheck()){
                    if (_check_update_ui == 1){
                        TS_MessageBoxEngine.TS_MessageBox(this, 2, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_not_connection"), "\n\n"), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                    }
                    return;
                }
                using (WebClient webClient = new WebClient()){
                    string client_version = TS_VersionEngine.TS_SofwareVersion(2, Program.ts_version_mode).Trim();
                    int client_num_version = Convert.ToInt32(client_version.Replace(".", string.Empty));
                    //
                    string[] version_content = webClient.DownloadString(TS_LinkSystem.github_link_lv).Split('=');
                    string last_version = version_content[1].Trim();
                    int last_num_version = Convert.ToInt32(last_version.Replace(".", string.Empty));
                    //
                    if (client_num_version < last_num_version){
                        try{
                            string baseDir = Path.Combine(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName).FullName);
                            string ts_wizard_path = Ts_wizard_starter_mode().Select(name => Path.Combine(baseDir, name)).FirstOrDefault(File.Exists);
                            //
                            if (ts_wizard_path != null){
                                if (!Software_operation_controller(Path.GetDirectoryName(ts_wizard_path))){
                                    // Update available
                                    DialogResult info_update = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_available_ts_wizard"), Application.ProductName, "\n\n", client_version, "\n", last_version, "\n\n", ts_wizard_name), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                                    if (info_update == DialogResult.Yes){
                                        Process.Start(new ProcessStartInfo { FileName = ts_wizard_path, WorkingDirectory = Path.GetDirectoryName(ts_wizard_path) });
                                    }
                                }else{
                                    TS_MessageBoxEngine.TS_MessageBox(this, 1, string.Format(software_lang.TSReadLangs("HeaderHelp", "header_help_info_notification"), ts_wizard_name));
                                }
                            }else{
                                // Update available
                                DialogResult info_update = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_available"), Application.ProductName, "\n\n", client_version, "\n", last_version, "\n\n"), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                                if (info_update == DialogResult.Yes){
                                    Process.Start(new ProcessStartInfo(TS_LinkSystem.github_link_lr) { UseShellExecute = true });
                                }
                            }
                        }catch (Exception){ }
                    }else if (_check_update_ui == 1 && client_num_version == last_num_version){
                        // No update available
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_not_available"), Application.ProductName, "\n", client_version), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                    }else if (_check_update_ui == 1 && client_num_version > last_num_version){
                        // Access before public use
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_newer"), "\n\n", string.Format("v{0}", client_version)), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
                    }
                }
            }catch (Exception ex){
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_error"), "\n\n", ex.Message), string.Format(software_lang.TSReadLangs("SoftwareUpdate", "su_title"), Application.ProductName));
            }
        }
        // TS WIZARD
        // ======================================================================================================
        private void TSWizardToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                string baseDir = Path.Combine(Directory.GetParent(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName).FullName);
                string ts_wizard_path = Ts_wizard_starter_mode().Select(name => Path.Combine(baseDir, name)).FirstOrDefault(File.Exists);
                //
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                //
                if (ts_wizard_path != null){
                    if (!Software_operation_controller(Path.GetDirectoryName(ts_wizard_path))){
                        Process.Start(new ProcessStartInfo { FileName = ts_wizard_path, WorkingDirectory = Path.GetDirectoryName(ts_wizard_path) });
                    }else{
                        TS_MessageBoxEngine.TS_MessageBox(this, 1, string.Format(software_lang.TSReadLangs("HeaderHelp", "header_help_info_notification"), ts_wizard_name));
                    }
                }else{
                    DialogResult ts_wizard_query = TS_MessageBoxEngine.TS_MessageBox(this, 5, string.Format(software_lang.TSReadLangs("TSWizard", "tsw_content"), software_lang.TSReadLangs("HeaderMenu", "header_menu_ts_wizard"), Application.CompanyName, "\n\n", Application.ProductName, Application.CompanyName, "\n\n"), string.Format(software_lang.TSReadLangs("TSWizard", "tsw_title"), Application.ProductName));
                    if (ts_wizard_query == DialogResult.Yes){
                        Process.Start(new ProcessStartInfo(TS_LinkSystem.ts_wizard) { UseShellExecute = true });
                    }
                }
            }catch (Exception){ }
        }
        // BUY ME A COFFEE LINK
        // ======================================================================================================
        private void BmacToolStripMenuItem_Click(object sender, EventArgs e){
            try{
                Process.Start(new ProcessStartInfo(TS_LinkSystem.ts_bmac){ UseShellExecute = true });
            }catch (Exception){ }
        }
        // TS TOOL LAUNCHER MODULE
        // ======================================================================================================
        private void TSToolLauncher<T>(string formName, string langKey, bool mode) where T : Form, new(){
            try{
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                T tool = new T { Name = formName };
                if (Application.OpenForms[formName] == null){
                    if (mode) tool.ShowDialog(); else tool.Show();
                }
                else{
                    if (Application.OpenForms[formName].WindowState == FormWindowState.Minimized){
                        Application.OpenForms[formName].WindowState = FormWindowState.Normal;
                    }
                    string public_message;
                    public_message = string.Format(software_lang.TSReadLangs("HeaderHelp", "header_help_info_notification"), software_lang.TSReadLangs("VCardixOther", langKey));
                    if (formName == "vcardix_about"){
                        public_message = string.Format(software_lang.TSReadLangs("HeaderHelp", "header_help_info_notification"), software_lang.TSReadLangs("HeaderMenu", langKey));
                    }
                    TS_MessageBoxEngine.TS_MessageBox(this, 1, public_message);
                    Application.OpenForms[formName].Activate();
                }
            }catch (Exception){ }
        }
        // OPEN ADDRESS WINDOW
        // ======================================================================================================
        private void BtnOpenAdressWindow_Click(object sender, EventArgs e){
            TSToolLauncher<VCardixAdressWindow>("vcardix_adress_window", "vca_name", true);
        }
        private void TextBoxAddress_KeyPress(object sender, KeyPressEventArgs e){
            TSToolLauncher<VCardixAdressWindow>("vcardix_adress_window", "vca_name", true);
            e.Handled = true;
        }
        // IMAGE PREVIEW WINDOW
        private void CxViewImageToolStripMenuItem_Click(object sender, EventArgs e){
            TSToolLauncher<VCardixImagePreview>("vcardix_image_preview", "vci_name", true);
        }
        // VCARDIX ABOUT
        // ======================================================================================================
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e){
            TSToolLauncher<VCardixAbout>("vcardix_about", "header_menu_about", false);
        }
        // VCARDIX EXIT
        // ======================================================================================================
        private void VCardix_FormClosing(object sender, FormClosingEventArgs e){
            if (!save_status){
                TSGetLangs software_lang = new TSGetLangs(lang_path);
                var import_warning = TS_MessageBoxEngine.TS_MessageBox(this, 10, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_import_warning_exit"), "\n\n"));
                if (import_warning == DialogResult.Yes){
                    try{
                        SaveContactsToFile();
                        Application.Exit();
                    }catch (Exception ex){
                        TS_MessageBoxEngine.TS_MessageBox(this, 3, string.Format(software_lang.TSReadLangs("VCardixUI", "vcui_export_failed"), "\n\n", ex.Message));
                        e.Cancel = true;
                        return;
                    }
                }else if (import_warning == DialogResult.No){
                    Application.ExitThread();
                }else if (import_warning == DialogResult.Cancel){
                    e.Cancel = true;
                    return;
                }
            }else{
                Application.Exit();
            }
        }
    }
    // TS CUSTOM CONTROL NAMESPACE
    // ======================================================================================================
    namespace TSCustomControls{
        public class TSCustomDateTimePicker : DateTimePicker{
            private Color _backColor = SystemColors.Window;
            private Color _foreColor = SystemColors.WindowText;
            private Color _buttonColor = SystemColors.ControlDark;
            private Color _borderColor = SystemColors.ControlDark;
            public TSCustomDateTimePicker(){
                this.SetStyle(ControlStyles.UserPaint, true);
                SetControlColors();
            }
            [Browsable(true)]
            [Category("Appearance")]
            [Description("Gets or sets the border color.")]
            public Color BorderColor{
                get => _borderColor;
                set{
                    _borderColor = value;
                    Invalidate();
                }
            }
            [Browsable(true)]
            [Category("Appearance")]
            [Description("Gets or sets the background color of the control.")]
            public override Color BackColor{
                get => _backColor;
                set{
                    _backColor = value;
                    SetControlColors();
                    Invalidate();
                }
            }
            [Browsable(true)]
            [Category("Appearance")]
            [Description("Gets or sets the foreground color of the control.")]
            public override Color ForeColor{
                get => _foreColor;
                set{
                    _foreColor = value;
                    SetControlColors();
                    Invalidate();
                }
            }
            [Browsable(true)]
            [Category("Appearance")]
            [Description("Gets or sets the dropdown button color.")]
            public Color ButtonColor{
                get => _buttonColor;
                set{
                    _buttonColor = value;
                    Invalidate();
                }
            }
            private void SetControlColors(){
                this.CalendarForeColor = _foreColor;
                this.CalendarMonthBackground = _backColor;
            }
            protected override void OnPaint(PaintEventArgs e){
                base.OnPaint(e);
                Rectangle rect = this.ClientRectangle;
                Rectangle textRect = new Rectangle(2, 0, rect.Width - 20, rect.Height);
                Rectangle buttonRect = new Rectangle(rect.Width - 20, 0, 20, rect.Height);
                float scale = this.DeviceDpi / 96f;
                // Background
                using (SolidBrush b = new SolidBrush(_backColor)){ e.Graphics.FillRectangle(b, rect); }
                // Text
                TextRenderer.DrawText(e.Graphics, this.Text, this.Font, textRect, _foreColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
                // Button background
                using (SolidBrush b = new SolidBrush(_buttonColor)){ e.Graphics.FillRectangle(b, buttonRect); }
                // DPI-aware dropdown arrow with horizontal offset
                int arrowWidth = (int)(8 * scale);
                int arrowHeight = (int)(5 * scale);
                int arrowXOffset = (int)(2 * scale);
                Point middle = new Point(buttonRect.Left + buttonRect.Width / 2 - arrowXOffset, buttonRect.Top + buttonRect.Height / 2);
                Point[] arrow = { new Point(middle.X - arrowWidth / 2, middle.Y - arrowHeight / 2), new Point(middle.X + arrowWidth / 2, middle.Y - arrowHeight / 2), new Point(middle.X, middle.Y + arrowHeight / 2) };
                using (SolidBrush arrowBrush = new SolidBrush(_foreColor)){ e.Graphics.FillPolygon(arrowBrush, arrow); }
                // Border
                using (Pen pen = new Pen(_borderColor)){ e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1); }
            }
            protected override void OnValueChanged(EventArgs eventargs){
                base.OnValueChanged(eventargs);
                Invalidate();
            }
            protected override void OnFontChanged(EventArgs e){
                base.OnFontChanged(e);
                Invalidate();
            }
        }
    }
}