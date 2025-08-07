using System;
using System.Drawing;
using System.Windows.Forms;
using static VCardix.TSModules;

namespace VCardix{
    public partial class VCardixImagePreview : Form{
        public VCardixImagePreview(){ InitializeComponent(); }
        // LOAD
        // ======================================================================================================
        private void VCardixImagePreview_Load(object sender, EventArgs e){
            Image_preview_preloader();
            if (Application.OpenForms[Application.ProductName] is VCardix transfer_main_form){
                Image img_file = transfer_main_form.ContactUserImage.Image;
                ImgPreview.Image = img_file;
            }
        }
        // DYNAMIC UI
        // ======================================================================================================
        public void Image_preview_preloader(){
            try{
                // COLOR SETTINGS
                int set_attribute = VCardix.theme == 1 ? 20 : 19;
                if (DwmSetWindowAttribute(Handle, set_attribute, new[] { 1 }, 4) != VCardix.theme){
                    DwmSetWindowAttribute(Handle, 20, new[] { VCardix.theme == 1 ? 0 : 1 }, 4);
                }
                BackColor = TS_ThemeEngine.ColorMode(VCardix.theme, "TSBT_BGColor2");
                //
                // ======================================================================================================
                // TEXTS
                TSGetLangs software_lang = new TSGetLangs(VCardix.lang_path);
                Text = string.Format(software_lang.TSReadLangs("VCardixOther", "vci_title"), Application.ProductName);
            }catch (Exception){ }
        }
    }
}