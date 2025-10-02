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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgPreview = new System.Windows.Forms.PictureBox();
            this.BtnSaveImg = new VCardix.TSCustomButton();
            this.BackPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.panel1);
            this.BackPanel.Controls.Add(this.BtnSaveImg);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BackPanel.Size = new System.Drawing.Size(284, 261);
            this.BackPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(264, 206);
            this.panel1.TabIndex = 0;
            // 
            // ImgPreview
            // 
            this.ImgPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImgPreview.Location = new System.Drawing.Point(0, 0);
            this.ImgPreview.Name = "ImgPreview";
            this.ImgPreview.Size = new System.Drawing.Size(264, 196);
            this.ImgPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPreview.TabIndex = 0;
            this.ImgPreview.TabStop = false;
            // 
            // BtnSaveImg
            // 
            this.BtnSaveImg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSaveImg.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSaveImg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSaveImg.BorderRadius = 10;
            this.BtnSaveImg.BorderSize = 0;
            this.BtnSaveImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSaveImg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSaveImg.FlatAppearance.BorderSize = 0;
            this.BtnSaveImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSaveImg.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSaveImg.ForeColor = System.Drawing.Color.White;
            this.BtnSaveImg.Location = new System.Drawing.Point(10, 216);
            this.BtnSaveImg.Name = "BtnSaveImg";
            this.BtnSaveImg.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSaveImg.Size = new System.Drawing.Size(264, 35);
            this.BtnSaveImg.TabIndex = 1;
            this.BtnSaveImg.Text = "Kaydet";
            this.BtnSaveImg.TextColor = System.Drawing.Color.White;
            this.BtnSaveImg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSaveImg.UseVisualStyleBackColor = false;
            this.BtnSaveImg.Click += new System.EventHandler(this.BtnSaveImg_Click);
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
            this.MinimizeBox = false;
            this.Name = "VCardixImagePreview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCardixImagePreview";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VCardixImagePreview_FormClosing);
            this.Load += new System.EventHandler(this.VCardixImagePreview_Load);
            this.BackPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImgPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.PictureBox ImgPreview;
        private TSCustomButton BtnSaveImg;
        private System.Windows.Forms.Panel panel1;
    }
}