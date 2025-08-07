using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static VCardix.TSModules;

namespace VCardix{
    public partial class VCardixAdressWindow : Form{
        public VCardixAdressWindow(){ InitializeComponent(); }
        // LOAD
        // ======================================================================================================
        private void VCardixAdressWindow_Load(object sender, EventArgs e){
            Adress_window_preloader();
            try{
                if (Application.OpenForms[Application.ProductName] is VCardix transfer_main_form){
                    string address = transfer_main_form.textBoxAddress.Text;
                    if (!string.IsNullOrEmpty(address)){
                        string[] parts = address.Split(new[] { "||" }, StringSplitOptions.None);
                        if (parts.Length == 7){
                            txtPOBox.Text = parts[0];
                            txtApartment.Text = parts[1];
                            txtStreet.Text = parts[2];
                            txtCity.Text = parts[3];
                            txtRegion.Text = parts[4];
                            txtPostal.Text = parts[5];
                            txtCountry.Text = parts[6];
                        }
                    }
                }
            }catch (Exception){ }
        }
        // DYNAMIC UI
        // ======================================================================================================
        public void Adress_window_preloader(){
            try{
                // COLOR SETTINGS
                int set_attribute = VCardix.theme == 1 ? 20 : 19;
                if (DwmSetWindowAttribute(Handle, set_attribute, new[] { 1 }, 4) != VCardix.theme){
                    DwmSetWindowAttribute(Handle, 20, new[] { VCardix.theme == 1 ? 0 : 1 }, 4);
                }
                BackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "TSBT_BGColor2");
                //
                foreach (Control ui_controls in BackPanel.Controls){
                    if (ui_controls is Button ui_btn){
                        ui_btn.ForeColor = TS_ThemeEngine.ColorMode(VCardix.theme, "DynamicThemeActiveBtnBG");
                        ui_btn.BackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColor");
                        ui_btn.FlatAppearance.BorderColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColor");
                        ui_btn.FlatAppearance.MouseDownBackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColor");
                        ui_btn.FlatAppearance.MouseOverBackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColorHover");
                    }
                    if (ui_controls is TextBox ui_textbox){
                        ui_textbox.BackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "UIBGColor2");
                        ui_textbox.ForeColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColorText");
                    }
                    if (ui_controls is Label ui_label){
                        ui_label.ForeColor = TS_ThemeEngine.ColorMode(VCardix.theme, "AccentColorText");
                    }
                }
                //
                TSImageRenderer(BtnSave, VCardix.theme == 1 ? Properties.Resources.ct_confirm_light : Properties.Resources.ct_confirm_dark, 18, ContentAlignment.MiddleRight);
                TSImageRenderer(BtnCancel, VCardix.theme == 1 ? Properties.Resources.ct_cancel_light : Properties.Resources.ct_cancel_dark, 20, ContentAlignment.MiddleRight);
                //
                // ======================================================================================================
                // TEXTS
                TSGetLangs software_lang = new TSGetLangs(VCardix.lang_path);
                Text = string.Format(software_lang.TSReadLangs("VCardixOther", "vca_title"), Application.ProductName);
                lblPobox.Text = software_lang.TSReadLangs("VCardixOther", "vca_pobox");
                lblApartment.Text = software_lang.TSReadLangs("VCardixOther", "vca_apartment");
                lblStreet.Text = software_lang.TSReadLangs("VCardixOther", "vca_street");
                lblCity.Text = software_lang.TSReadLangs("VCardixOther", "vca_city");
                lblRegion.Text = software_lang.TSReadLangs("VCardixOther", "vca_region");
                lblPoCode.Text = software_lang.TSReadLangs("VCardixOther", "vca_po_code");
                lblCountry.Text = software_lang.TSReadLangs("VCardixOther", "vca_country");
                BtnSave.Text = " " + software_lang.TSReadLangs("VCardixOther", "vca_save");
                BtnCancel.Text = " " + software_lang.TSReadLangs("VCardixOther", "vca_cancel");
            }catch (Exception){ }
        }
        // BTN CONTROLS
        // ======================================================================================================
        private void BtnSave_Click(object sender, EventArgs e){
            string[] parts = {
                txtPOBox.Text.Trim(),
                txtApartment.Text.Trim(),
                txtStreet.Text.Trim(),
                txtCity.Text.Trim(),
                txtRegion.Text.Trim(),
                txtPostal.Text.Trim(),
                txtCountry.Text.Trim()
            };
            if (!parts.All(string.IsNullOrEmpty)){
                string fullAddress = string.Join("||", parts);
                if (Application.OpenForms[Application.ProductName] is VCardix transfer_main_form){
                    transfer_main_form.textBoxAddress.Text = fullAddress;
                    transfer_main_form.BtnOpenAdressWindow.Invalidate();
                    transfer_main_form.BtnOpenAdressWindow.Update();
                }
            }
            Close();
        }
        private void BtnCancel_Click(object sender, EventArgs e){ Close(); }
    }
}