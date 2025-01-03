namespace PamerYukFormsApp.Prototype2
{
    partial class MainForm
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
            this.panelUtama = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NavigationBar = new System.Windows.Forms.TableLayoutPanel();
            this.buttonHome = new System.Windows.Forms.PictureBox();
            this.buttonChat = new System.Windows.Forms.PictureBox();
            this.buttonTambahKonten = new System.Windows.Forms.PictureBox();
            this.buttonProfile = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.NavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTambahKonten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panelUtama
            // 
            this.panelUtama.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelUtama.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelUtama.Location = new System.Drawing.Point(0, 0);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(1278, 842);
            this.panelUtama.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.NavigationBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 832);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 106);
            this.panel1.TabIndex = 0;
            // 
            // NavigationBar
            // 
            this.NavigationBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NavigationBar.AutoSize = true;
            this.NavigationBar.BackColor = System.Drawing.Color.White;
            this.NavigationBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NavigationBar.ColumnCount = 4;
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.NavigationBar.Controls.Add(this.buttonHome, 0, 0);
            this.NavigationBar.Controls.Add(this.buttonChat, 2, 0);
            this.NavigationBar.Controls.Add(this.buttonTambahKonten, 1, 0);
            this.NavigationBar.Controls.Add(this.buttonProfile, 3, 0);
            this.NavigationBar.Location = new System.Drawing.Point(451, 16);
            this.NavigationBar.Name = "NavigationBar";
            this.NavigationBar.RowCount = 1;
            this.NavigationBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NavigationBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.NavigationBar.Size = new System.Drawing.Size(376, 78);
            this.NavigationBar.TabIndex = 1;
            // 
            // buttonHome
            // 
            this.buttonHome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHome.Image = global::PamerYukFormsApp.Properties.Resources.Home_true;
            this.buttonHome.Location = new System.Drawing.Point(31, 23);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(32, 32);
            this.buttonHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonHome.TabIndex = 3;
            this.buttonHome.TabStop = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // buttonChat
            // 
            this.buttonChat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonChat.Image = global::PamerYukFormsApp.Properties.Resources.Chat_false;
            this.buttonChat.Location = new System.Drawing.Point(219, 23);
            this.buttonChat.Name = "buttonChat";
            this.buttonChat.Size = new System.Drawing.Size(32, 32);
            this.buttonChat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonChat.TabIndex = 2;
            this.buttonChat.TabStop = false;
            this.buttonChat.Click += new System.EventHandler(this.buttonChat_Click);
            // 
            // buttonTambahKonten
            // 
            this.buttonTambahKonten.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonTambahKonten.Image = global::PamerYukFormsApp.Properties.Resources.Tambahkonten_false;
            this.buttonTambahKonten.Location = new System.Drawing.Point(125, 23);
            this.buttonTambahKonten.Name = "buttonTambahKonten";
            this.buttonTambahKonten.Size = new System.Drawing.Size(32, 32);
            this.buttonTambahKonten.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonTambahKonten.TabIndex = 1;
            this.buttonTambahKonten.TabStop = false;
            this.buttonTambahKonten.Click += new System.EventHandler(this.buttonTambahKonten_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonProfile.Image = global::PamerYukFormsApp.Properties.Resources.Profile_false;
            this.buttonProfile.Location = new System.Drawing.Point(313, 23);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(32, 32);
            this.buttonProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonProfile.TabIndex = 0;
            this.buttonProfile.TabStop = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 938);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUtama);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.NavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTambahKonten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelUtama;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel NavigationBar;
        private System.Windows.Forms.PictureBox buttonProfile;
        private System.Windows.Forms.PictureBox buttonHome;
        private System.Windows.Forms.PictureBox buttonChat;
        private System.Windows.Forms.PictureBox buttonTambahKonten;
    }
}