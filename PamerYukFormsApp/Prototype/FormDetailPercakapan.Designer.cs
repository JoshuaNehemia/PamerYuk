namespace PamerYukFormsApp.Prototype
{
    partial class FormDetailPercakapan
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
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.listBoxListChat = new System.Windows.Forms.ListBox();
            this.labelChatUsername = new System.Windows.Forms.Label();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPesan.Location = new System.Drawing.Point(27, 528);
            this.textBoxPesan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesan.Multiline = true;
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(839, 63);
            this.textBoxPesan.TabIndex = 5;
            // 
            // listBoxListChat
            // 
            this.listBoxListChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxListChat.FormattingEnabled = true;
            this.listBoxListChat.ItemHeight = 29;
            this.listBoxListChat.Location = new System.Drawing.Point(27, 101);
            this.listBoxListChat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxListChat.Name = "listBoxListChat";
            this.listBoxListChat.Size = new System.Drawing.Size(1016, 410);
            this.listBoxListChat.TabIndex = 4;
            // 
            // labelChatUsername
            // 
            this.labelChatUsername.AutoSize = true;
            this.labelChatUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChatUsername.Location = new System.Drawing.Point(20, 38);
            this.labelChatUsername.Name = "labelChatUsername";
            this.labelChatUsername.Size = new System.Drawing.Size(213, 37);
            this.labelChatUsername.TabIndex = 7;
            this.labelChatUsername.Text = "Nama Teman";
            // 
            // buttonKirim
            // 
            this.buttonKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonKirim.Location = new System.Drawing.Point(877, 528);
            this.buttonKirim.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(166, 62);
            this.buttonKirim.TabIndex = 6;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // FormDetailPercakapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 621);
            this.Controls.Add(this.labelChatUsername);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxPesan);
            this.Controls.Add(this.listBoxListChat);
            this.Name = "FormDetailPercakapan";
            this.Text = "FormDetailPercakapan";
            this.Load += new System.EventHandler(this.FormDetailPercakapan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.ListBox listBoxListChat;
        private System.Windows.Forms.Label labelChatUsername;
        private System.Windows.Forms.Button buttonKirim;
    }
}