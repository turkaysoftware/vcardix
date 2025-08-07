namespace VCardix
{
    partial class VCardixImagePreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCardixImagePreview));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.ImgPreview = new System.Windows.Forms.PictureBox();
            this.BackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.ImgPreview);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BackPanel.Size = new System.Drawing.Size(284, 261);
            this.BackPanel.TabIndex = 0;
            // 
            // ImgPreview
            // 
            this.ImgPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPreview.Location = new System.Drawing.Point(10, 10);
            this.ImgPreview.Name = "ImgPreview";
            this.ImgPreview.Size = new System.Drawing.Size(264, 241);
            this.ImgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPreview.TabIndex = 0;
            this.ImgPreview.TabStop = false;
            // 
            // VCardixImagePreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "VCardixImagePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCardixImagePreview";
            this.Load += new System.EventHandler(this.VCardixImagePreview_Load);
            this.BackPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.PictureBox ImgPreview;
    }
}