﻿namespace VCardix
{
    partial class VCardixMain
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCardixMain));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BtnAdd = new VCardix.TSCustomButton();
            this.BtnDelete = new VCardix.TSCustomButton();
            this.BtnUpdate = new VCardix.TSCustomButton();
            this.ContactList = new System.Windows.Forms.ListBox();
            this.UIPanel = new System.Windows.Forms.Panel();
            this.BtnOpenAdressWindow = new VCardix.TSCustomButton();
            this.dateTimePickerBirthday = new VCardix.TSCustomDateTimePicker();
            this.ContactUserImage = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblMiddleName = new System.Windows.Forms.Label();
            this.lblProfileImage = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblWebsite = new System.Windows.Forms.Label();
            this.lblPhoneCell = new System.Windows.Forms.Label();
            this.textBoxOrganization = new System.Windows.Forms.TextBox();
            this.lblOrganization = new System.Windows.Forms.Label();
            this.lblPhoneHome = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.textBoxWebsite = new System.Windows.Forms.TextBox();
            this.lblPhoneWork = new System.Windows.Forms.Label();
            this.textBoxEmail3 = new System.Windows.Forms.TextBox();
            this.lblMail3 = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.lblMail1 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.lblMail2 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneWork = new System.Windows.Forms.TextBox();
            this.textBoxPhoneHome = new System.Windows.Forms.TextBox();
            this.textBoxPhoneMobile = new System.Windows.Forms.TextBox();
            this.textBoxEmail1 = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.FooterPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.BottomTickPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.MLPanel = new System.Windows.Forms.Panel();
            this.BottomImage = new System.Windows.Forms.PictureBox();
            this.MFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.MFLP3 = new System.Windows.Forms.Panel();
            this.MLBmac = new System.Windows.Forms.PictureBox();
            this.MFLP2 = new System.Windows.Forms.Panel();
            this.MLGitHub = new System.Windows.Forms.PictureBox();
            this.MFLP1 = new System.Windows.Forms.Panel();
            this.MLWeb = new System.Windows.Forms.PictureBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.HeaderMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vCardVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vcard21ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vcard30ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vcard40ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingFullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingFirstNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingLastNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemThemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turkishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSWizardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.CXImageMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cxImageSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxViewImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxSaveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxRemoveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackPanel.SuspendLayout();
            this.UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactUserImage)).BeginInit();
            this.FooterPanel.SuspendLayout();
            this.BottomTickPanel.SuspendLayout();
            this.MLPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BottomImage)).BeginInit();
            this.MFLP.SuspendLayout();
            this.MFLP3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MLBmac)).BeginInit();
            this.MFLP2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MLGitHub)).BeginInit();
            this.MFLP1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MLWeb)).BeginInit();
            this.HeaderMenu.SuspendLayout();
            this.CXImageMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.BtnAdd);
            this.BackPanel.Controls.Add(this.BtnDelete);
            this.BackPanel.Controls.Add(this.BtnUpdate);
            this.BackPanel.Controls.Add(this.ContactList);
            this.BackPanel.Controls.Add(this.UIPanel);
            this.BackPanel.Controls.Add(this.lblSearch);
            this.BackPanel.Controls.Add(this.FooterPanel);
            this.BackPanel.Controls.Add(this.textBoxSearch);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 24);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BackPanel.Size = new System.Drawing.Size(1008, 577);
            this.BackPanel.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnAdd.BorderRadius = 10;
            this.BtnAdd.BorderSize = 0;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(10, 407);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnAdd.Size = new System.Drawing.Size(255, 35);
            this.BtnAdd.TabIndex = 3;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.TextColor = System.Drawing.Color.White;
            this.BtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnDelete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnDelete.BorderRadius = 10;
            this.BtnDelete.BorderSize = 0;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(10, 489);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnDelete.Size = new System.Drawing.Size(255, 35);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.TextColor = System.Drawing.Color.White;
            this.BtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnUpdate.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnUpdate.BorderRadius = 10;
            this.BtnUpdate.BorderSize = 0;
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.FlatAppearance.BorderSize = 0;
            this.BtnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnUpdate.ForeColor = System.Drawing.Color.White;
            this.BtnUpdate.Location = new System.Drawing.Point(10, 448);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnUpdate.Size = new System.Drawing.Size(255, 35);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.TextColor = System.Drawing.Color.White;
            this.BtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUpdate.UseVisualStyleBackColor = false;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // ContactList
            // 
            this.ContactList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactList.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.ContactList.FormattingEnabled = true;
            this.ContactList.IntegralHeight = false;
            this.ContactList.ItemHeight = 17;
            this.ContactList.Location = new System.Drawing.Point(10, 67);
            this.ContactList.Name = "ContactList";
            this.ContactList.Size = new System.Drawing.Size(255, 334);
            this.ContactList.TabIndex = 2;
            this.ContactList.SelectedIndexChanged += new System.EventHandler(this.ContactList_SelectedIndexChanged);
            // 
            // UIPanel
            // 
            this.UIPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UIPanel.BackColor = System.Drawing.Color.White;
            this.UIPanel.Controls.Add(this.BtnOpenAdressWindow);
            this.UIPanel.Controls.Add(this.dateTimePickerBirthday);
            this.UIPanel.Controls.Add(this.ContactUserImage);
            this.UIPanel.Controls.Add(this.lblFirstName);
            this.UIPanel.Controls.Add(this.lblMiddleName);
            this.UIPanel.Controls.Add(this.lblProfileImage);
            this.UIPanel.Controls.Add(this.lblLastName);
            this.UIPanel.Controls.Add(this.lblNote);
            this.UIPanel.Controls.Add(this.lblBirthday);
            this.UIPanel.Controls.Add(this.textBoxAddress);
            this.UIPanel.Controls.Add(this.lblWebsite);
            this.UIPanel.Controls.Add(this.lblPhoneCell);
            this.UIPanel.Controls.Add(this.textBoxOrganization);
            this.UIPanel.Controls.Add(this.lblOrganization);
            this.UIPanel.Controls.Add(this.lblPhoneHome);
            this.UIPanel.Controls.Add(this.textBoxNote);
            this.UIPanel.Controls.Add(this.lblAdress);
            this.UIPanel.Controls.Add(this.textBoxWebsite);
            this.UIPanel.Controls.Add(this.lblPhoneWork);
            this.UIPanel.Controls.Add(this.textBoxEmail3);
            this.UIPanel.Controls.Add(this.lblMail3);
            this.UIPanel.Controls.Add(this.textBoxFirstName);
            this.UIPanel.Controls.Add(this.textBoxEmail2);
            this.UIPanel.Controls.Add(this.lblMail1);
            this.UIPanel.Controls.Add(this.textBoxMiddleName);
            this.UIPanel.Controls.Add(this.lblMail2);
            this.UIPanel.Controls.Add(this.textBoxLastName);
            this.UIPanel.Controls.Add(this.textBoxPhoneWork);
            this.UIPanel.Controls.Add(this.textBoxPhoneHome);
            this.UIPanel.Controls.Add(this.textBoxPhoneMobile);
            this.UIPanel.Controls.Add(this.textBoxEmail1);
            this.UIPanel.Location = new System.Drawing.Point(273, 13);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.Padding = new System.Windows.Forms.Padding(10);
            this.UIPanel.Size = new System.Drawing.Size(725, 511);
            this.UIPanel.TabIndex = 6;
            // 
            // BtnOpenAdressWindow
            // 
            this.BtnOpenAdressWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnOpenAdressWindow.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnOpenAdressWindow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnOpenAdressWindow.BorderRadius = 5;
            this.BtnOpenAdressWindow.BorderSize = 0;
            this.BtnOpenAdressWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOpenAdressWindow.FlatAppearance.BorderSize = 0;
            this.BtnOpenAdressWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOpenAdressWindow.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnOpenAdressWindow.ForeColor = System.Drawing.Color.White;
            this.BtnOpenAdressWindow.Location = new System.Drawing.Point(210, 321);
            this.BtnOpenAdressWindow.Name = "BtnOpenAdressWindow";
            this.BtnOpenAdressWindow.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnOpenAdressWindow.Size = new System.Drawing.Size(28, 28);
            this.BtnOpenAdressWindow.TabIndex = 35;
            this.BtnOpenAdressWindow.TextColor = System.Drawing.Color.White;
            this.BtnOpenAdressWindow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOpenAdressWindow.UseVisualStyleBackColor = false;
            this.BtnOpenAdressWindow.Click += new System.EventHandler(this.BtnOpenAdressWindow_Click);
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerBirthday.ButtonColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerBirthday.CalendarForeColor = System.Drawing.SystemColors.WindowText;
            this.dateTimePickerBirthday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerBirthday.DisabledBackColor = System.Drawing.SystemColors.Control;
            this.dateTimePickerBirthday.DisabledButtonColor = System.Drawing.SystemColors.ControlDark;
            this.dateTimePickerBirthday.DisabledForeColor = System.Drawing.SystemColors.GrayText;
            this.dateTimePickerBirthday.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(212, 106);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(300, 25);
            this.dateTimePickerBirthday.TabIndex = 7;
            // 
            // ContactUserImage
            // 
            this.ContactUserImage.BackColor = System.Drawing.SystemColors.Control;
            this.ContactUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContactUserImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ContactUserImage.Location = new System.Drawing.Point(212, 447);
            this.ContactUserImage.Name = "ContactUserImage";
            this.ContactUserImage.Size = new System.Drawing.Size(91, 51);
            this.ContactUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ContactUserImage.TabIndex = 30;
            this.ContactUserImage.TabStop = false;
            this.ContactUserImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ContactUserImage_MouseUp);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblFirstName.Location = new System.Drawing.Point(10, 16);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(33, 19);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Adı:";
            // 
            // lblMiddleName
            // 
            this.lblMiddleName.AutoSize = true;
            this.lblMiddleName.BackColor = System.Drawing.Color.Transparent;
            this.lblMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMiddleName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMiddleName.Location = new System.Drawing.Point(10, 47);
            this.lblMiddleName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblMiddleName.Name = "lblMiddleName";
            this.lblMiddleName.Size = new System.Drawing.Size(71, 19);
            this.lblMiddleName.TabIndex = 2;
            this.lblMiddleName.Text = "İkinci Adı:";
            // 
            // lblProfileImage
            // 
            this.lblProfileImage.AutoSize = true;
            this.lblProfileImage.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileImage.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblProfileImage.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblProfileImage.Location = new System.Drawing.Point(10, 463);
            this.lblProfileImage.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblProfileImage.Name = "lblProfileImage";
            this.lblProfileImage.Size = new System.Drawing.Size(94, 19);
            this.lblProfileImage.TabIndex = 29;
            this.lblProfileImage.Text = "Profil Görseli:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.BackColor = System.Drawing.Color.Transparent;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblLastName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLastName.Location = new System.Drawing.Point(10, 78);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(54, 19);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Soyadı:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblNote.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNote.Location = new System.Drawing.Point(10, 419);
            this.lblNote.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(36, 19);
            this.lblNote.TabIndex = 27;
            this.lblNote.Text = "Not:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.BackColor = System.Drawing.Color.Transparent;
            this.lblBirthday.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblBirthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblBirthday.Location = new System.Drawing.Point(10, 109);
            this.lblBirthday.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(97, 19);
            this.lblBirthday.TabIndex = 6;
            this.lblBirthday.Text = "Doğum Tarihi:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxAddress.Location = new System.Drawing.Point(243, 323);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(469, 25);
            this.textBoxAddress.TabIndex = 22;
            this.textBoxAddress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAddress_KeyPress);
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.BackColor = System.Drawing.Color.Transparent;
            this.lblWebsite.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblWebsite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblWebsite.Location = new System.Drawing.Point(10, 388);
            this.lblWebsite.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(63, 19);
            this.lblWebsite.TabIndex = 25;
            this.lblWebsite.Text = "Website:";
            // 
            // lblPhoneCell
            // 
            this.lblPhoneCell.AutoSize = true;
            this.lblPhoneCell.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneCell.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneCell.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneCell.Location = new System.Drawing.Point(10, 140);
            this.lblPhoneCell.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPhoneCell.Name = "lblPhoneCell";
            this.lblPhoneCell.Size = new System.Drawing.Size(94, 19);
            this.lblPhoneCell.TabIndex = 8;
            this.lblPhoneCell.Text = "Cep Telefonu:";
            // 
            // textBoxOrganization
            // 
            this.textBoxOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrganization.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxOrganization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOrganization.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxOrganization.Location = new System.Drawing.Point(212, 354);
            this.textBoxOrganization.Name = "textBoxOrganization";
            this.textBoxOrganization.Size = new System.Drawing.Size(500, 25);
            this.textBoxOrganization.TabIndex = 24;
            // 
            // lblOrganization
            // 
            this.lblOrganization.AutoSize = true;
            this.lblOrganization.BackColor = System.Drawing.Color.Transparent;
            this.lblOrganization.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblOrganization.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblOrganization.Location = new System.Drawing.Point(10, 357);
            this.lblOrganization.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblOrganization.Name = "lblOrganization";
            this.lblOrganization.Size = new System.Drawing.Size(98, 19);
            this.lblOrganization.TabIndex = 23;
            this.lblOrganization.Text = "Organizasyon:";
            // 
            // lblPhoneHome
            // 
            this.lblPhoneHome.AutoSize = true;
            this.lblPhoneHome.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneHome.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneHome.Location = new System.Drawing.Point(10, 171);
            this.lblPhoneHome.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPhoneHome.Name = "lblPhoneHome";
            this.lblPhoneHome.Size = new System.Drawing.Size(84, 19);
            this.lblPhoneHome.TabIndex = 10;
            this.lblPhoneHome.Text = "Ev Telefonu:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNote.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNote.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxNote.Location = new System.Drawing.Point(212, 416);
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(500, 25);
            this.textBoxNote.TabIndex = 28;
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.BackColor = System.Drawing.Color.Transparent;
            this.lblAdress.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblAdress.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblAdress.Location = new System.Drawing.Point(10, 326);
            this.lblAdress.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(51, 19);
            this.lblAdress.TabIndex = 20;
            this.lblAdress.Text = "Adresi:";
            // 
            // textBoxWebsite
            // 
            this.textBoxWebsite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWebsite.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWebsite.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxWebsite.Location = new System.Drawing.Point(212, 385);
            this.textBoxWebsite.Name = "textBoxWebsite";
            this.textBoxWebsite.Size = new System.Drawing.Size(500, 25);
            this.textBoxWebsite.TabIndex = 26;
            // 
            // lblPhoneWork
            // 
            this.lblPhoneWork.AutoSize = true;
            this.lblPhoneWork.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneWork.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPhoneWork.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPhoneWork.Location = new System.Drawing.Point(10, 202);
            this.lblPhoneWork.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPhoneWork.Name = "lblPhoneWork";
            this.lblPhoneWork.Size = new System.Drawing.Size(80, 19);
            this.lblPhoneWork.TabIndex = 12;
            this.lblPhoneWork.Text = "İş Telefonu:";
            // 
            // textBoxEmail3
            // 
            this.textBoxEmail3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail3.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail3.Location = new System.Drawing.Point(212, 292);
            this.textBoxEmail3.Name = "textBoxEmail3";
            this.textBoxEmail3.Size = new System.Drawing.Size(500, 25);
            this.textBoxEmail3.TabIndex = 19;
            // 
            // lblMail3
            // 
            this.lblMail3.AutoSize = true;
            this.lblMail3.BackColor = System.Drawing.Color.Transparent;
            this.lblMail3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMail3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMail3.Location = new System.Drawing.Point(10, 295);
            this.lblMail3.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblMail3.Name = "lblMail3";
            this.lblMail3.Size = new System.Drawing.Size(65, 19);
            this.lblMail3.TabIndex = 18;
            this.lblMail3.Text = "E-Mail 3:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxFirstName.Location = new System.Drawing.Point(212, 13);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(500, 25);
            this.textBoxFirstName.TabIndex = 1;
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail2.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail2.Location = new System.Drawing.Point(212, 261);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(500, 25);
            this.textBoxEmail2.TabIndex = 17;
            // 
            // lblMail1
            // 
            this.lblMail1.AutoSize = true;
            this.lblMail1.BackColor = System.Drawing.Color.Transparent;
            this.lblMail1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMail1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMail1.Location = new System.Drawing.Point(10, 233);
            this.lblMail1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblMail1.Name = "lblMail1";
            this.lblMail1.Size = new System.Drawing.Size(63, 19);
            this.lblMail1.TabIndex = 14;
            this.lblMail1.Text = "E-Mail 1:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMiddleName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMiddleName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxMiddleName.Location = new System.Drawing.Point(212, 44);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(500, 25);
            this.textBoxMiddleName.TabIndex = 3;
            // 
            // lblMail2
            // 
            this.lblMail2.AutoSize = true;
            this.lblMail2.BackColor = System.Drawing.Color.Transparent;
            this.lblMail2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblMail2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblMail2.Location = new System.Drawing.Point(10, 264);
            this.lblMail2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblMail2.Name = "lblMail2";
            this.lblMail2.Size = new System.Drawing.Size(65, 19);
            this.lblMail2.TabIndex = 16;
            this.lblMail2.Text = "E-Mail 2:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLastName.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLastName.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxLastName.Location = new System.Drawing.Point(212, 75);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(500, 25);
            this.textBoxLastName.TabIndex = 5;
            // 
            // textBoxPhoneWork
            // 
            this.textBoxPhoneWork.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneWork.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPhoneWork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneWork.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneWork.Location = new System.Drawing.Point(212, 199);
            this.textBoxPhoneWork.Name = "textBoxPhoneWork";
            this.textBoxPhoneWork.Size = new System.Drawing.Size(500, 25);
            this.textBoxPhoneWork.TabIndex = 13;
            // 
            // textBoxPhoneHome
            // 
            this.textBoxPhoneHome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneHome.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPhoneHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneHome.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneHome.Location = new System.Drawing.Point(212, 168);
            this.textBoxPhoneHome.Name = "textBoxPhoneHome";
            this.textBoxPhoneHome.Size = new System.Drawing.Size(500, 25);
            this.textBoxPhoneHome.TabIndex = 11;
            // 
            // textBoxPhoneMobile
            // 
            this.textBoxPhoneMobile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhoneMobile.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPhoneMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneMobile.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxPhoneMobile.Location = new System.Drawing.Point(212, 137);
            this.textBoxPhoneMobile.Name = "textBoxPhoneMobile";
            this.textBoxPhoneMobile.Size = new System.Drawing.Size(500, 25);
            this.textBoxPhoneMobile.TabIndex = 9;
            // 
            // textBoxEmail1
            // 
            this.textBoxEmail1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEmail1.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxEmail1.Location = new System.Drawing.Point(212, 230);
            this.textBoxEmail1.Name = "textBoxEmail1";
            this.textBoxEmail1.Size = new System.Drawing.Size(500, 25);
            this.textBoxEmail1.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblSearch.Location = new System.Drawing.Point(7, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(33, 19);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Ara:";
            // 
            // FooterPanel
            // 
            this.FooterPanel.BackColor = System.Drawing.Color.White;
            this.FooterPanel.Controls.Add(this.statusLabel);
            this.FooterPanel.Controls.Add(this.BottomTickPanel);
            this.FooterPanel.Controls.Add(this.MFLP);
            this.FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FooterPanel.Location = new System.Drawing.Point(10, 532);
            this.FooterPanel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.FooterPanel.Name = "FooterPanel";
            this.FooterPanel.Size = new System.Drawing.Size(988, 35);
            this.FooterPanel.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.statusLabel.Location = new System.Drawing.Point(35, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(531, 35);
            this.statusLabel.TabIndex = 1;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomTickPanel
            // 
            this.BottomTickPanel.AutoSize = true;
            this.BottomTickPanel.Controls.Add(this.MLPanel);
            this.BottomTickPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.BottomTickPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomTickPanel.Name = "BottomTickPanel";
            this.BottomTickPanel.Size = new System.Drawing.Size(35, 35);
            this.BottomTickPanel.TabIndex = 4;
            this.BottomTickPanel.Visible = false;
            // 
            // MLPanel
            // 
            this.MLPanel.Controls.Add(this.BottomImage);
            this.MLPanel.Location = new System.Drawing.Point(3, 3);
            this.MLPanel.Name = "MLPanel";
            this.MLPanel.Padding = new System.Windows.Forms.Padding(7);
            this.MLPanel.Size = new System.Drawing.Size(29, 29);
            this.MLPanel.TabIndex = 0;
            // 
            // BottomImage
            // 
            this.BottomImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BottomImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomImage.Location = new System.Drawing.Point(7, 7);
            this.BottomImage.Name = "BottomImage";
            this.BottomImage.Size = new System.Drawing.Size(15, 15);
            this.BottomImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BottomImage.TabIndex = 5;
            this.BottomImage.TabStop = false;
            // 
            // MFLP
            // 
            this.MFLP.Controls.Add(this.MFLP3);
            this.MFLP.Controls.Add(this.MFLP2);
            this.MFLP.Controls.Add(this.MFLP1);
            this.MFLP.Dock = System.Windows.Forms.DockStyle.Right;
            this.MFLP.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MFLP.Location = new System.Drawing.Point(880, 0);
            this.MFLP.Name = "MFLP";
            this.MFLP.Size = new System.Drawing.Size(108, 35);
            this.MFLP.TabIndex = 3;
            // 
            // MFLP3
            // 
            this.MFLP3.BackColor = System.Drawing.Color.BurlyWood;
            this.MFLP3.Controls.Add(this.MLBmac);
            this.MFLP3.Location = new System.Drawing.Point(76, 3);
            this.MFLP3.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.MFLP3.Name = "MFLP3";
            this.MFLP3.Padding = new System.Windows.Forms.Padding(5);
            this.MFLP3.Size = new System.Drawing.Size(29, 29);
            this.MFLP3.TabIndex = 16;
            // 
            // MLBmac
            // 
            this.MLBmac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MLBmac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MLBmac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLBmac.Location = new System.Drawing.Point(5, 5);
            this.MLBmac.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MLBmac.Name = "MLBmac";
            this.MLBmac.Size = new System.Drawing.Size(19, 19);
            this.MLBmac.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MLBmac.TabIndex = 10;
            this.MLBmac.TabStop = false;
            this.MLBmac.Click += new System.EventHandler(this.MLBmac_Click);
            // 
            // MFLP2
            // 
            this.MFLP2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MFLP2.Controls.Add(this.MLGitHub);
            this.MFLP2.Location = new System.Drawing.Point(45, 3);
            this.MFLP2.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MFLP2.Name = "MFLP2";
            this.MFLP2.Padding = new System.Windows.Forms.Padding(5);
            this.MFLP2.Size = new System.Drawing.Size(29, 29);
            this.MFLP2.TabIndex = 12;
            // 
            // MLGitHub
            // 
            this.MLGitHub.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MLGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MLGitHub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLGitHub.Location = new System.Drawing.Point(5, 5);
            this.MLGitHub.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MLGitHub.Name = "MLGitHub";
            this.MLGitHub.Size = new System.Drawing.Size(19, 19);
            this.MLGitHub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MLGitHub.TabIndex = 7;
            this.MLGitHub.TabStop = false;
            this.MLGitHub.Click += new System.EventHandler(this.MLGitHub_Click);
            // 
            // MFLP1
            // 
            this.MFLP1.BackColor = System.Drawing.Color.DarkKhaki;
            this.MFLP1.Controls.Add(this.MLWeb);
            this.MFLP1.Location = new System.Drawing.Point(14, 3);
            this.MFLP1.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
            this.MFLP1.Name = "MFLP1";
            this.MFLP1.Padding = new System.Windows.Forms.Padding(5);
            this.MFLP1.Size = new System.Drawing.Size(29, 29);
            this.MFLP1.TabIndex = 15;
            // 
            // MLWeb
            // 
            this.MLWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MLWeb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MLWeb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MLWeb.Location = new System.Drawing.Point(5, 5);
            this.MLWeb.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.MLWeb.Name = "MLWeb";
            this.MLWeb.Size = new System.Drawing.Size(19, 19);
            this.MLWeb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MLWeb.TabIndex = 10;
            this.MLWeb.TabStop = false;
            this.MLWeb.Click += new System.EventHandler(this.MLWeb_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.textBoxSearch.Location = new System.Drawing.Point(10, 34);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(255, 25);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // HeaderMenu
            // 
            this.HeaderMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.vCardVersionToolStripMenuItem,
            this.sortingModeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.tSWizardToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.HeaderMenu.Location = new System.Drawing.Point(0, 0);
            this.HeaderMenu.Name = "HeaderMenu";
            this.HeaderMenu.Size = new System.Drawing.Size(1008, 24);
            this.HeaderMenu.TabIndex = 0;
            this.HeaderMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem,
            this.exportFileToolStripMenuItem});
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importFileToolStripMenuItem
            // 
            this.importFileToolStripMenuItem.Name = "importFileToolStripMenuItem";
            this.importFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.importFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importFileToolStripMenuItem.Text = "Import File";
            this.importFileToolStripMenuItem.Click += new System.EventHandler(this.ImportFileToolStripMenuItem_Click);
            // 
            // exportFileToolStripMenuItem
            // 
            this.exportFileToolStripMenuItem.Name = "exportFileToolStripMenuItem";
            this.exportFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.exportFileToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportFileToolStripMenuItem.Text = "Export File";
            this.exportFileToolStripMenuItem.Click += new System.EventHandler(this.ExportFileToolStripMenuItem_Click);
            // 
            // vCardVersionToolStripMenuItem
            // 
            this.vCardVersionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vcard21ToolStripMenuItem,
            this.vcard30ToolStripMenuItem,
            this.vcard40ToolStripMenuItem});
            this.vCardVersionToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.vCardVersionToolStripMenuItem.Name = "vCardVersionToolStripMenuItem";
            this.vCardVersionToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.vCardVersionToolStripMenuItem.Text = "VCardVersion";
            // 
            // vcard21ToolStripMenuItem
            // 
            this.vcard21ToolStripMenuItem.Name = "vcard21ToolStripMenuItem";
            this.vcard21ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.vcard21ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.vcard21ToolStripMenuItem.Text = "vcard2.1";
            this.vcard21ToolStripMenuItem.Click += new System.EventHandler(this.Vcard21ToolStripMenuItem_Click);
            // 
            // vcard30ToolStripMenuItem
            // 
            this.vcard30ToolStripMenuItem.Name = "vcard30ToolStripMenuItem";
            this.vcard30ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.vcard30ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.vcard30ToolStripMenuItem.Text = "vcard3.0";
            this.vcard30ToolStripMenuItem.Click += new System.EventHandler(this.Vcard30ToolStripMenuItem_Click);
            // 
            // vcard40ToolStripMenuItem
            // 
            this.vcard40ToolStripMenuItem.Name = "vcard40ToolStripMenuItem";
            this.vcard40ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.vcard40ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.vcard40ToolStripMenuItem.Text = "vcard4.0";
            this.vcard40ToolStripMenuItem.Click += new System.EventHandler(this.Vcard40ToolStripMenuItem_Click);
            // 
            // sortingModeToolStripMenuItem
            // 
            this.sortingModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortingFullNameToolStripMenuItem,
            this.sortingFirstNameToolStripMenuItem,
            this.sortingLastNameToolStripMenuItem,
            this.sortingPhoneToolStripMenuItem});
            this.sortingModeToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sortingModeToolStripMenuItem.Name = "sortingModeToolStripMenuItem";
            this.sortingModeToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.sortingModeToolStripMenuItem.Text = "SortingMode";
            // 
            // sortingFullNameToolStripMenuItem
            // 
            this.sortingFullNameToolStripMenuItem.Checked = true;
            this.sortingFullNameToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sortingFullNameToolStripMenuItem.Name = "sortingFullNameToolStripMenuItem";
            this.sortingFullNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D1)));
            this.sortingFullNameToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.sortingFullNameToolStripMenuItem.Text = "SortingFullName";
            this.sortingFullNameToolStripMenuItem.Click += new System.EventHandler(this.SortingFullNameToolStripMenuItem_Click);
            // 
            // sortingFirstNameToolStripMenuItem
            // 
            this.sortingFirstNameToolStripMenuItem.Name = "sortingFirstNameToolStripMenuItem";
            this.sortingFirstNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D2)));
            this.sortingFirstNameToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.sortingFirstNameToolStripMenuItem.Text = "SortingFirstName";
            this.sortingFirstNameToolStripMenuItem.Click += new System.EventHandler(this.SortingFirstNameToolStripMenuItem_Click);
            // 
            // sortingLastNameToolStripMenuItem
            // 
            this.sortingLastNameToolStripMenuItem.Name = "sortingLastNameToolStripMenuItem";
            this.sortingLastNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D3)));
            this.sortingLastNameToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.sortingLastNameToolStripMenuItem.Text = "SortingLastName";
            this.sortingLastNameToolStripMenuItem.Click += new System.EventHandler(this.SortingLastNameToolStripMenuItem_Click);
            // 
            // sortingPhoneToolStripMenuItem
            // 
            this.sortingPhoneToolStripMenuItem.Name = "sortingPhoneToolStripMenuItem";
            this.sortingPhoneToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D4)));
            this.sortingPhoneToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.sortingPhoneToolStripMenuItem.Text = "SortingPhone";
            this.sortingPhoneToolStripMenuItem.Click += new System.EventHandler(this.SortingPhoneToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem,
            this.languageToolStripMenuItem,
            this.startupToolStripMenuItem,
            this.checkForUpdateToolStripMenuItem});
            this.settingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightThemeToolStripMenuItem,
            this.darkThemeToolStripMenuItem,
            this.systemThemeToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // lightThemeToolStripMenuItem
            // 
            this.lightThemeToolStripMenuItem.Name = "lightThemeToolStripMenuItem";
            this.lightThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.lightThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.lightThemeToolStripMenuItem.Text = "Light Theme";
            this.lightThemeToolStripMenuItem.Click += new System.EventHandler(this.LightThemeToolStripMenuItem_Click);
            // 
            // darkThemeToolStripMenuItem
            // 
            this.darkThemeToolStripMenuItem.Name = "darkThemeToolStripMenuItem";
            this.darkThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.darkThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.darkThemeToolStripMenuItem.Text = "Dark Theme";
            this.darkThemeToolStripMenuItem.Click += new System.EventHandler(this.DarkThemeToolStripMenuItem_Click);
            // 
            // systemThemeToolStripMenuItem
            // 
            this.systemThemeToolStripMenuItem.Name = "systemThemeToolStripMenuItem";
            this.systemThemeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.systemThemeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.systemThemeToolStripMenuItem.Text = "System Theme";
            this.systemThemeToolStripMenuItem.Click += new System.EventHandler(this.SystemThemeToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.turkishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.englishToolStripMenuItem.Text = "English";
            // 
            // turkishToolStripMenuItem
            // 
            this.turkishToolStripMenuItem.Name = "turkishToolStripMenuItem";
            this.turkishToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.turkishToolStripMenuItem.Text = "Turkish";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowedToolStripMenuItem,
            this.fullScreenToolStripMenuItem});
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.startupToolStripMenuItem.Text = "Startup";
            // 
            // windowedToolStripMenuItem
            // 
            this.windowedToolStripMenuItem.Name = "windowedToolStripMenuItem";
            this.windowedToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.windowedToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.windowedToolStripMenuItem.Text = "Windowed";
            this.windowedToolStripMenuItem.Click += new System.EventHandler(this.WindowedToolStripMenuItem_Click);
            // 
            // fullScreenToolStripMenuItem
            // 
            this.fullScreenToolStripMenuItem.Name = "fullScreenToolStripMenuItem";
            this.fullScreenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.fullScreenToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.fullScreenToolStripMenuItem.Text = "Full Screen";
            this.fullScreenToolStripMenuItem.Click += new System.EventHandler(this.FullScreenToolStripMenuItem_Click);
            // 
            // checkForUpdateToolStripMenuItem
            // 
            this.checkForUpdateToolStripMenuItem.Name = "checkForUpdateToolStripMenuItem";
            this.checkForUpdateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.checkForUpdateToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.checkForUpdateToolStripMenuItem.Text = "checkupdate";
            this.checkForUpdateToolStripMenuItem.Click += new System.EventHandler(this.CheckForUpdateToolStripMenuItem_Click);
            // 
            // tSWizardToolStripMenuItem
            // 
            this.tSWizardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tSWizardToolStripMenuItem.Name = "tSWizardToolStripMenuItem";
            this.tSWizardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.tSWizardToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tSWizardToolStripMenuItem.Text = "TSWizard";
            this.tSWizardToolStripMenuItem.Click += new System.EventHandler(this.TSWizardToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // MainToolTip
            // 
            this.MainToolTip.OwnerDraw = true;
            this.MainToolTip.Draw += new System.Windows.Forms.DrawToolTipEventHandler(this.MainToolTip_Draw);
            // 
            // CXImageMenu
            // 
            this.CXImageMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cxImageSelectToolStripMenuItem,
            this.cxViewImageToolStripMenuItem,
            this.cxSaveImageToolStripMenuItem,
            this.cxRemoveImageToolStripMenuItem});
            this.CXImageMenu.Name = "contextMenuStrip1";
            this.CXImageMenu.Size = new System.Drawing.Size(164, 92);
            // 
            // cxImageSelectToolStripMenuItem
            // 
            this.cxImageSelectToolStripMenuItem.Name = "cxImageSelectToolStripMenuItem";
            this.cxImageSelectToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cxImageSelectToolStripMenuItem.Text = "CxImageSelect";
            this.cxImageSelectToolStripMenuItem.Click += new System.EventHandler(this.CxImageSelectToolStripMenuItem_Click);
            // 
            // cxViewImageToolStripMenuItem
            // 
            this.cxViewImageToolStripMenuItem.Name = "cxViewImageToolStripMenuItem";
            this.cxViewImageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cxViewImageToolStripMenuItem.Text = "CxViewImage";
            this.cxViewImageToolStripMenuItem.Click += new System.EventHandler(this.CxViewImageToolStripMenuItem_Click);
            // 
            // cxSaveImageToolStripMenuItem
            // 
            this.cxSaveImageToolStripMenuItem.Name = "cxSaveImageToolStripMenuItem";
            this.cxSaveImageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cxSaveImageToolStripMenuItem.Text = "CxSaveImage";
            this.cxSaveImageToolStripMenuItem.Click += new System.EventHandler(this.CxSaveImageToolStripMenuItem_Click);
            // 
            // cxRemoveImageToolStripMenuItem
            // 
            this.cxRemoveImageToolStripMenuItem.Name = "cxRemoveImageToolStripMenuItem";
            this.cxRemoveImageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.cxRemoveImageToolStripMenuItem.Text = "CxRemoveImage";
            this.cxRemoveImageToolStripMenuItem.Click += new System.EventHandler(this.CxRemoveImageToolStripMenuItem_Click);
            // 
            // VCardixMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1008, 601);
            this.Controls.Add(this.BackPanel);
            this.Controls.Add(this.HeaderMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.HeaderMenu;
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "VCardixMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCardix";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VCardix_FormClosing);
            this.Load += new System.EventHandler(this.VCardix_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.VCardix_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.VCardix_DragEnter);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.UIPanel.ResumeLayout(false);
            this.UIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactUserImage)).EndInit();
            this.FooterPanel.ResumeLayout(false);
            this.FooterPanel.PerformLayout();
            this.BottomTickPanel.ResumeLayout(false);
            this.MLPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BottomImage)).EndInit();
            this.MFLP.ResumeLayout(false);
            this.MFLP3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MLBmac)).EndInit();
            this.MFLP2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MLGitHub)).EndInit();
            this.MFLP1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MLWeb)).EndInit();
            this.HeaderMenu.ResumeLayout(false);
            this.HeaderMenu.PerformLayout();
            this.CXImageMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        internal System.Windows.Forms.Label lblProfileImage;
        internal System.Windows.Forms.Label lblNote;
        internal System.Windows.Forms.Label lblWebsite;
        internal System.Windows.Forms.Label lblOrganization;
        internal System.Windows.Forms.Label lblAdress;
        internal System.Windows.Forms.Label lblMail3;
        internal System.Windows.Forms.Label lblMail2;
        internal System.Windows.Forms.Label lblMail1;
        internal System.Windows.Forms.Label lblPhoneWork;
        internal System.Windows.Forms.Label lblPhoneHome;
        internal System.Windows.Forms.Label lblPhoneCell;
        internal System.Windows.Forms.Label lblBirthday;
        internal System.Windows.Forms.Label lblLastName;
        internal System.Windows.Forms.Label lblMiddleName;
        internal System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel FooterPanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxOrganization;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxWebsite;
        private System.Windows.Forms.TextBox textBoxEmail3;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxEmail2;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneMobile;
        private System.Windows.Forms.TextBox textBoxEmail1;
        private System.Windows.Forms.TextBox textBoxPhoneHome;
        private System.Windows.Forms.TextBox textBoxPhoneWork;
        private System.Windows.Forms.MenuStrip HeaderMenu;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSWizardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkThemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turkishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vCardVersionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vcard21ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vcard30ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vcard40ToolStripMenuItem;
        internal System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Panel UIPanel;
        private System.Windows.Forms.ToolTip MainToolTip;
        private System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdateToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ContextMenuStrip CXImageMenu;
        private System.Windows.Forms.ToolStripMenuItem cxImageSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxViewImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxRemoveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingFullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingLastNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingFirstNameToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel MFLP;
        private System.Windows.Forms.Panel MFLP2;
        private System.Windows.Forms.PictureBox MLGitHub;
        private System.Windows.Forms.Panel MFLP1;
        private System.Windows.Forms.PictureBox MLWeb;
        private System.Windows.Forms.FlowLayoutPanel BottomTickPanel;
        private System.Windows.Forms.Panel MLPanel;
        private System.Windows.Forms.PictureBox BottomImage;
        private System.Windows.Forms.ToolStripMenuItem sortingPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cxSaveImageToolStripMenuItem;
        private System.Windows.Forms.ListBox ContactList;
        private System.Windows.Forms.PictureBox ContactUserImage;
        private System.Windows.Forms.Panel MFLP3;
        private System.Windows.Forms.PictureBox MLBmac;
        private TSCustomDateTimePicker dateTimePickerBirthday;
        private TSCustomButton BtnUpdate;
        private TSCustomButton BtnAdd;
        private TSCustomButton BtnDelete;
        public TSCustomButton BtnOpenAdressWindow;
        private System.Windows.Forms.ToolStripMenuItem systemThemeToolStripMenuItem;
    }
}

