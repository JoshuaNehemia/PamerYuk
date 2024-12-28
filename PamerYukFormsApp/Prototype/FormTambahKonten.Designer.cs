namespace PamerYukFormsApp.Prototype
{
    partial class FormTambahKonten
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
            this.buttonGantiGambar = new System.Windows.Forms.Button();
            this.buttonTambah = new System.Windows.Forms.Button();
            this.labelDeskripsi = new System.Windows.Forms.Label();
            this.labelFormTambahKonten = new System.Windows.Forms.Label();
            this.textBoxCaption = new System.Windows.Forms.TextBox();
            this.pictureBoxMedia = new System.Windows.Forms.PictureBox();
            this.buttonTambahTag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGantiGambar
            // 
            this.buttonGantiGambar.Location = new System.Drawing.Point(893, 849);
            this.buttonGantiGambar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGantiGambar.Name = "buttonGantiGambar";
            this.buttonGantiGambar.Size = new System.Drawing.Size(207, 82);
            this.buttonGantiGambar.TabIndex = 74;
            this.buttonGantiGambar.Text = "Pilih Media";
            this.buttonGantiGambar.UseVisualStyleBackColor = true;
            this.buttonGantiGambar.Click += new System.EventHandler(this.buttonGantiGambar_Click);
            // 
            // buttonTambah
            // 
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambah.Location = new System.Drawing.Point(1601, 909);
            this.buttonTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(238, 82);
            this.buttonTambah.TabIndex = 72;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = true;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // labelDeskripsi
            // 
            this.labelDeskripsi.AutoSize = true;
            this.labelDeskripsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelDeskripsi.Location = new System.Drawing.Point(895, 111);
            this.labelDeskripsi.Name = "labelDeskripsi";
            this.labelDeskripsi.Size = new System.Drawing.Size(254, 54);
            this.labelDeskripsi.TabIndex = 70;
            this.labelDeskripsi.Text = "Deskripsi : ";
            // 
            // labelFormTambahKonten
            // 
            this.labelFormTambahKonten.AutoSize = true;
            this.labelFormTambahKonten.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold);
            this.labelFormTambahKonten.Location = new System.Drawing.Point(503, 2);
            this.labelFormTambahKonten.Name = "labelFormTambahKonten";
            this.labelFormTambahKonten.Size = new System.Drawing.Size(826, 120);
            this.labelFormTambahKonten.TabIndex = 66;
            this.labelFormTambahKonten.Text = "Tambah Konten";
            this.labelFormTambahKonten.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxCaption
            // 
            this.textBoxCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxCaption.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxCaption.Location = new System.Drawing.Point(904, 195);
            this.textBoxCaption.Multiline = true;
            this.textBoxCaption.Name = "textBoxCaption";
            this.textBoxCaption.Size = new System.Drawing.Size(935, 192);
            this.textBoxCaption.TabIndex = 75;
            // 
            // pictureBoxMedia
            // 
            this.pictureBoxMedia.Location = new System.Drawing.Point(43, 111);
            this.pictureBoxMedia.Name = "pictureBoxMedia";
            this.pictureBoxMedia.Size = new System.Drawing.Size(800, 800);
            this.pictureBoxMedia.TabIndex = 76;
            this.pictureBoxMedia.TabStop = false;
            // 
            // buttonTambahTag
            // 
            this.buttonTambahTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonTambahTag.Location = new System.Drawing.Point(904, 445);
            this.buttonTambahTag.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTambahTag.Name = "buttonTambahTag";
            this.buttonTambahTag.Size = new System.Drawing.Size(350, 82);
            this.buttonTambahTag.TabIndex = 78;
            this.buttonTambahTag.Text = "Tambah Tag";
            this.buttonTambahTag.UseVisualStyleBackColor = true;
            this.buttonTambahTag.Click += new System.EventHandler(this.buttonTambahTag_Click);
            // 
            // FormTambahKonten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 1019);
            this.Controls.Add(this.buttonTambahTag);
            this.Controls.Add(this.pictureBoxMedia);
            this.Controls.Add(this.textBoxCaption);
            this.Controls.Add(this.buttonGantiGambar);
            this.Controls.Add(this.buttonTambah);
            this.Controls.Add(this.labelDeskripsi);
            this.Controls.Add(this.labelFormTambahKonten);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormTambahKonten";
            this.Text = "FormTambahKonten";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTambahKonten_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonGantiGambar;
        private System.Windows.Forms.Button buttonTambah;
        private System.Windows.Forms.Label labelDeskripsi;
        private System.Windows.Forms.Label labelFormTambahKonten;
        private System.Windows.Forms.TextBox textBoxCaption;
        private System.Windows.Forms.PictureBox pictureBoxMedia;
        private System.Windows.Forms.Button buttonTambahTag;
    }
}