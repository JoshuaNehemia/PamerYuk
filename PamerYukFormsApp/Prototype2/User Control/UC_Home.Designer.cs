﻿namespace PamerYukFormsApp.Prototype2.User_Control
{
    partial class UC_Home
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelRequestPertemenan = new System.Windows.Forms.Panel();
            this.flowLayoutPanelRequestPertemanan = new System.Windows.Forms.FlowLayoutPanel();
            this.panelCariTeman = new System.Windows.Forms.Panel();
            this.labelCariTeman = new System.Windows.Forms.Label();
            this.buttonCariTeman = new System.Windows.Forms.Button();
            this.panelDaftarTeman = new System.Windows.Forms.Panel();
            this.dataGridViewDaftarTeman = new System.Windows.Forms.DataGridView();
            this.labelDaftarTeman = new System.Windows.Forms.Label();
            this.labelHariIni = new System.Windows.Forms.Label();
            this.labelPamerYuk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCurrentUser = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelRequestPertemanan = new System.Windows.Forms.Label();
            this.labelPertemananMasuk = new System.Windows.Forms.Label();
            this.labelPertemananTerkirim = new System.Windows.Forms.Label();
            this.panelRequestPertemenan.SuspendLayout();
            this.panelCariTeman.SuspendLayout();
            this.panelDaftarTeman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRequestPertemenan
            // 
            this.panelRequestPertemenan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelRequestPertemenan.Controls.Add(this.labelPertemananTerkirim);
            this.panelRequestPertemenan.Controls.Add(this.labelPertemananMasuk);
            this.panelRequestPertemenan.Controls.Add(this.labelRequestPertemanan);
            this.panelRequestPertemenan.Controls.Add(this.flowLayoutPanelRequestPertemanan);
            this.panelRequestPertemenan.Location = new System.Drawing.Point(2, 453);
            this.panelRequestPertemenan.Name = "panelRequestPertemenan";
            this.panelRequestPertemenan.Size = new System.Drawing.Size(1277, 325);
            this.panelRequestPertemenan.TabIndex = 47;
            // 
            // flowLayoutPanelRequestPertemanan
            // 
            this.flowLayoutPanelRequestPertemanan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanelRequestPertemanan.Location = new System.Drawing.Point(-1, 98);
            this.flowLayoutPanelRequestPertemanan.Name = "flowLayoutPanelRequestPertemanan";
            this.flowLayoutPanelRequestPertemanan.Size = new System.Drawing.Size(1278, 178);
            this.flowLayoutPanelRequestPertemanan.TabIndex = 44;
            // 
            // panelCariTeman
            // 
            this.panelCariTeman.Controls.Add(this.labelCariTeman);
            this.panelCariTeman.Controls.Add(this.buttonCariTeman);
            this.panelCariTeman.Location = new System.Drawing.Point(-1, 390);
            this.panelCariTeman.Name = "panelCariTeman";
            this.panelCariTeman.Size = new System.Drawing.Size(1280, 68);
            this.panelCariTeman.TabIndex = 46;
            // 
            // labelCariTeman
            // 
            this.labelCariTeman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCariTeman.AutoSize = true;
            this.labelCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCariTeman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCariTeman.Location = new System.Drawing.Point(34, 20);
            this.labelCariTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCariTeman.Name = "labelCariTeman";
            this.labelCariTeman.Size = new System.Drawing.Size(241, 29);
            this.labelCariTeman.TabIndex = 40;
            this.labelCariTeman.Text = "Butuh Teman Baru?";
            this.labelCariTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCariTeman
            // 
            this.buttonCariTeman.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCariTeman.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCariTeman.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCariTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCariTeman.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCariTeman.Location = new System.Drawing.Point(299, 10);
            this.buttonCariTeman.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCariTeman.Name = "buttonCariTeman";
            this.buttonCariTeman.Size = new System.Drawing.Size(920, 48);
            this.buttonCariTeman.TabIndex = 41;
            this.buttonCariTeman.Text = "Cari Teman";
            this.buttonCariTeman.UseVisualStyleBackColor = false;
            this.buttonCariTeman.Click += new System.EventHandler(this.buttonCariTeman_Click);
            // 
            // panelDaftarTeman
            // 
            this.panelDaftarTeman.Controls.Add(this.dataGridViewDaftarTeman);
            this.panelDaftarTeman.Controls.Add(this.labelDaftarTeman);
            this.panelDaftarTeman.Location = new System.Drawing.Point(2, 95);
            this.panelDaftarTeman.Name = "panelDaftarTeman";
            this.panelDaftarTeman.Size = new System.Drawing.Size(1277, 296);
            this.panelDaftarTeman.TabIndex = 45;
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(35, 49);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 62;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 28;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1182, 228);
            this.dataGridViewDaftarTeman.TabIndex = 43;
            this.dataGridViewDaftarTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTeman_CellContentClick);
            // 
            // labelDaftarTeman
            // 
            this.labelDaftarTeman.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelDaftarTeman.AutoSize = true;
            this.labelDaftarTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDaftarTeman.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDaftarTeman.Location = new System.Drawing.Point(31, 10);
            this.labelDaftarTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDaftarTeman.Name = "labelDaftarTeman";
            this.labelDaftarTeman.Size = new System.Drawing.Size(160, 29);
            this.labelDaftarTeman.TabIndex = 42;
            this.labelDaftarTeman.Text = "Teman Anda";
            this.labelDaftarTeman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHariIni
            // 
            this.labelHariIni.AutoSize = true;
            this.labelHariIni.Location = new System.Drawing.Point(1009, 62);
            this.labelHariIni.Name = "labelHariIni";
            this.labelHariIni.Size = new System.Drawing.Size(78, 20);
            this.labelHariIni.TabIndex = 47;
            this.labelHariIni.Text = "DateTime";
            // 
            // labelPamerYuk
            // 
            this.labelPamerYuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPamerYuk.AutoSize = true;
            this.labelPamerYuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPamerYuk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelPamerYuk.Location = new System.Drawing.Point(1003, 13);
            this.labelPamerYuk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPamerYuk.Name = "labelPamerYuk";
            this.labelPamerYuk.Size = new System.Drawing.Size(213, 46);
            this.labelPamerYuk.TabIndex = 46;
            this.labelPamerYuk.Text = "PamerYuk";
            this.labelPamerYuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 45;
            this.label2.Text = "Hallo,";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCurrentUser
            // 
            this.labelCurrentUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelCurrentUser.AutoSize = true;
            this.labelCurrentUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCurrentUser.Location = new System.Drawing.Point(29, 49);
            this.labelCurrentUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentUser.Name = "labelCurrentUser";
            this.labelCurrentUser.Size = new System.Drawing.Size(221, 37);
            this.labelCurrentUser.TabIndex = 44;
            this.labelCurrentUser.Text = "Current_User";
            this.labelCurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelHeader.Controls.Add(this.labelHariIni);
            this.panelHeader.Controls.Add(this.labelPamerYuk);
            this.panelHeader.Controls.Add(this.label2);
            this.panelHeader.Controls.Add(this.labelCurrentUser);
            this.panelHeader.Location = new System.Drawing.Point(1, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1278, 104);
            this.panelHeader.TabIndex = 44;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // labelRequestPertemanan
            // 
            this.labelRequestPertemanan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelRequestPertemanan.AutoSize = true;
            this.labelRequestPertemanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequestPertemanan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelRequestPertemanan.Location = new System.Drawing.Point(509, 15);
            this.labelRequestPertemanan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRequestPertemanan.Name = "labelRequestPertemanan";
            this.labelRequestPertemanan.Size = new System.Drawing.Size(258, 29);
            this.labelRequestPertemanan.TabIndex = 42;
            this.labelRequestPertemanan.Text = "Request Pertemenan";
            this.labelRequestPertemanan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPertemananMasuk
            // 
            this.labelPertemananMasuk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPertemananMasuk.AutoSize = true;
            this.labelPertemananMasuk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertemananMasuk.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPertemananMasuk.Location = new System.Drawing.Point(509, 53);
            this.labelPertemananMasuk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPertemananMasuk.Name = "labelPertemananMasuk";
            this.labelPertemananMasuk.Size = new System.Drawing.Size(76, 25);
            this.labelPertemananMasuk.TabIndex = 45;
            this.labelPertemananMasuk.Text = "Masuk";
            this.labelPertemananMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPertemananMasuk.Click += new System.EventHandler(this.labelPertemananMasuk_Click);
            // 
            // labelPertemananTerkirim
            // 
            this.labelPertemananTerkirim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelPertemananTerkirim.AutoSize = true;
            this.labelPertemananTerkirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPertemananTerkirim.ForeColor = System.Drawing.SystemColors.GrayText;
            this.labelPertemananTerkirim.Location = new System.Drawing.Point(677, 53);
            this.labelPertemananTerkirim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPertemananTerkirim.Name = "labelPertemananTerkirim";
            this.labelPertemananTerkirim.Size = new System.Drawing.Size(90, 25);
            this.labelPertemananTerkirim.TabIndex = 46;
            this.labelPertemananTerkirim.Text = "Terkirim";
            this.labelPertemananTerkirim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPertemananTerkirim.Click += new System.EventHandler(this.labelPertemananTerkirim_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelRequestPertemenan);
            this.Controls.Add(this.panelCariTeman);
            this.Controls.Add(this.panelDaftarTeman);
            this.Controls.Add(this.panelHeader);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1278, 778);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.panelRequestPertemenan.ResumeLayout(false);
            this.panelRequestPertemenan.PerformLayout();
            this.panelCariTeman.ResumeLayout(false);
            this.panelCariTeman.PerformLayout();
            this.panelDaftarTeman.ResumeLayout(false);
            this.panelDaftarTeman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRequestPertemenan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelRequestPertemanan;
        private System.Windows.Forms.Panel panelCariTeman;
        private System.Windows.Forms.Label labelCariTeman;
        private System.Windows.Forms.Button buttonCariTeman;
        private System.Windows.Forms.Panel panelDaftarTeman;
        private System.Windows.Forms.DataGridView dataGridViewDaftarTeman;
        private System.Windows.Forms.Label labelDaftarTeman;
        private System.Windows.Forms.Label labelHariIni;
        private System.Windows.Forms.Label labelPamerYuk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCurrentUser;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelPertemananTerkirim;
        private System.Windows.Forms.Label labelPertemananMasuk;
        private System.Windows.Forms.Label labelRequestPertemanan;
    }
}
