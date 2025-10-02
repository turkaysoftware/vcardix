namespace VCardix
{
    partial class VCardixAdressWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCardixAdressWindow));
            this.BackPanel = new System.Windows.Forms.Panel();
            this.TLPBtn = new System.Windows.Forms.TableLayoutPanel();
            this.BtnSave = new VCardix.TSCustomButton();
            this.BtnCancel = new VCardix.TSCustomButton();
            this.lblPobox = new System.Windows.Forms.Label();
            this.txtPOBox = new System.Windows.Forms.TextBox();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.txtPostal = new System.Windows.Forms.TextBox();
            this.lblPoCode = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblApartment = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.BackPanel.SuspendLayout();
            this.TLPBtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.TLPBtn);
            this.BackPanel.Controls.Add(this.lblPobox);
            this.BackPanel.Controls.Add(this.txtPOBox);
            this.BackPanel.Controls.Add(this.txtRegion);
            this.BackPanel.Controls.Add(this.lblCountry);
            this.BackPanel.Controls.Add(this.txtPostal);
            this.BackPanel.Controls.Add(this.lblPoCode);
            this.BackPanel.Controls.Add(this.lblRegion);
            this.BackPanel.Controls.Add(this.txtCountry);
            this.BackPanel.Controls.Add(this.txtCity);
            this.BackPanel.Controls.Add(this.lblCity);
            this.BackPanel.Controls.Add(this.txtStreet);
            this.BackPanel.Controls.Add(this.lblApartment);
            this.BackPanel.Controls.Add(this.lblStreet);
            this.BackPanel.Controls.Add(this.txtApartment);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Padding = new System.Windows.Forms.Padding(10);
            this.BackPanel.Size = new System.Drawing.Size(634, 301);
            this.BackPanel.TabIndex = 0;
            // 
            // TLPBtn
            // 
            this.TLPBtn.AutoSize = true;
            this.TLPBtn.ColumnCount = 2;
            this.TLPBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBtn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBtn.Controls.Add(this.BtnSave, 0, 0);
            this.TLPBtn.Controls.Add(this.BtnCancel, 1, 0);
            this.TLPBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TLPBtn.Location = new System.Drawing.Point(10, 256);
            this.TLPBtn.Name = "TLPBtn";
            this.TLPBtn.RowCount = 1;
            this.TLPBtn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBtn.Size = new System.Drawing.Size(614, 35);
            this.TLPBtn.TabIndex = 14;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnSave.BorderRadius = 10;
            this.BtnSave.BorderSize = 0;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(3, 0);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnSave.Size = new System.Drawing.Size(301, 35);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "KAYDET";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.TextColor = System.Drawing.Color.White;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnCancel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(120)))), ((int)(((byte)(109)))));
            this.BtnCancel.BorderRadius = 10;
            this.BtnCancel.BorderSize = 0;
            this.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnCancel.FlatAppearance.BorderSize = 0;
            this.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.BtnCancel.ForeColor = System.Drawing.Color.White;
            this.BtnCancel.Location = new System.Drawing.Point(310, 0);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.BtnCancel.Size = new System.Drawing.Size(301, 35);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "İPTAL";
            this.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancel.TextColor = System.Drawing.Color.White;
            this.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancel.UseVisualStyleBackColor = false;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblPobox
            // 
            this.lblPobox.AutoSize = true;
            this.lblPobox.BackColor = System.Drawing.Color.Transparent;
            this.lblPobox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPobox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPobox.Location = new System.Drawing.Point(11, 16);
            this.lblPobox.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPobox.Name = "lblPobox";
            this.lblPobox.Size = new System.Drawing.Size(94, 19);
            this.lblPobox.TabIndex = 0;
            this.lblPobox.Text = "Posta Kutusu:";
            // 
            // txtPOBox
            // 
            this.txtPOBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPOBox.BackColor = System.Drawing.SystemColors.Control;
            this.txtPOBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPOBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPOBox.Location = new System.Drawing.Point(271, 13);
            this.txtPOBox.Name = "txtPOBox";
            this.txtPOBox.Size = new System.Drawing.Size(350, 25);
            this.txtPOBox.TabIndex = 1;
            // 
            // txtRegion
            // 
            this.txtRegion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRegion.BackColor = System.Drawing.SystemColors.Control;
            this.txtRegion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRegion.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtRegion.Location = new System.Drawing.Point(271, 137);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(350, 25);
            this.txtRegion.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCountry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCountry.Location = new System.Drawing.Point(11, 202);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(40, 19);
            this.lblCountry.TabIndex = 12;
            this.lblCountry.Text = "Ülke:";
            // 
            // txtPostal
            // 
            this.txtPostal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostal.BackColor = System.Drawing.SystemColors.Control;
            this.txtPostal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPostal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtPostal.Location = new System.Drawing.Point(271, 168);
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(350, 25);
            this.txtPostal.TabIndex = 11;
            // 
            // lblPoCode
            // 
            this.lblPoCode.AutoSize = true;
            this.lblPoCode.BackColor = System.Drawing.Color.Transparent;
            this.lblPoCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblPoCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblPoCode.Location = new System.Drawing.Point(11, 171);
            this.lblPoCode.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblPoCode.Name = "lblPoCode";
            this.lblPoCode.Size = new System.Drawing.Size(83, 19);
            this.lblPoCode.TabIndex = 10;
            this.lblPoCode.Text = "Posta Kodu:";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.BackColor = System.Drawing.Color.Transparent;
            this.lblRegion.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblRegion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRegion.Location = new System.Drawing.Point(11, 140);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(104, 19);
            this.lblRegion.TabIndex = 8;
            this.lblRegion.Text = "Bölge/Eyalet/İl:";
            // 
            // txtCountry
            // 
            this.txtCountry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCountry.BackColor = System.Drawing.SystemColors.Control;
            this.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCountry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCountry.Location = new System.Drawing.Point(271, 199);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(350, 25);
            this.txtCountry.TabIndex = 13;
            // 
            // txtCity
            // 
            this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCity.BackColor = System.Drawing.SystemColors.Control;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCity.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtCity.Location = new System.Drawing.Point(271, 106);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(350, 25);
            this.txtCity.TabIndex = 7;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCity.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCity.Location = new System.Drawing.Point(11, 109);
            this.lblCity.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(45, 19);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "Şehir:";
            // 
            // txtStreet
            // 
            this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStreet.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtStreet.Location = new System.Drawing.Point(271, 75);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(350, 25);
            this.txtStreet.TabIndex = 5;
            // 
            // lblApartment
            // 
            this.lblApartment.AutoSize = true;
            this.lblApartment.BackColor = System.Drawing.Color.Transparent;
            this.lblApartment.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblApartment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblApartment.Location = new System.Drawing.Point(11, 47);
            this.lblApartment.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblApartment.Name = "lblApartment";
            this.lblApartment.Size = new System.Drawing.Size(154, 19);
            this.lblApartment.TabIndex = 2;
            this.lblApartment.Text = "Apartman/Daire Bilgisi:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.BackColor = System.Drawing.Color.Transparent;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblStreet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblStreet.Location = new System.Drawing.Point(11, 78);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(148, 19);
            this.lblStreet.TabIndex = 4;
            this.lblStreet.Text = "Mahalle/Sokak Adresi:";
            // 
            // txtApartment
            // 
            this.txtApartment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApartment.BackColor = System.Drawing.SystemColors.Control;
            this.txtApartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApartment.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtApartment.Location = new System.Drawing.Point(271, 44);
            this.txtApartment.Name = "txtApartment";
            this.txtApartment.Size = new System.Drawing.Size(350, 25);
            this.txtApartment.TabIndex = 3;
            // 
            // VCardixAdressWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(634, 301);
            this.Controls.Add(this.BackPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VCardixAdressWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VCardixAdressWindow";
            this.Load += new System.EventHandler(this.VCardixAdressWindow_Load);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.TLPBtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.TextBox txtRegion;
        internal System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.TextBox txtPostal;
        internal System.Windows.Forms.Label lblPoCode;
        internal System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtStreet;
        internal System.Windows.Forms.Label lblApartment;
        internal System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtApartment;
        private TSCustomButton BtnSave;
        private TSCustomButton BtnCancel;
        internal System.Windows.Forms.Label lblPobox;
        private System.Windows.Forms.TextBox txtPOBox;
        private System.Windows.Forms.TableLayoutPanel TLPBtn;
    }
}