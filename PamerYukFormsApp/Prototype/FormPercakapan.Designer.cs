namespace PamerYukFormsApp.Prototype
{
    partial class FormPercakapan
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
            this.labelTeman = new System.Windows.Forms.Label();
            this.listBoxListChat = new System.Windows.Forms.ListBox();
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.buttonKirim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTeman
            // 
            this.labelTeman.AutoSize = true;
            this.labelTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTeman.Location = new System.Drawing.Point(34, 35);
            this.labelTeman.Name = "labelTeman";
            this.labelTeman.Size = new System.Drawing.Size(316, 69);
            this.labelTeman.TabIndex = 0;
            this.labelTeman.Text = "labelNama";
            // 
            // listBoxListChat
            // 
            this.listBoxListChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxListChat.FormattingEnabled = true;
            this.listBoxListChat.ItemHeight = 46;
            this.listBoxListChat.Location = new System.Drawing.Point(46, 131);
            this.listBoxListChat.Name = "listBoxListChat";
            this.listBoxListChat.Size = new System.Drawing.Size(1807, 648);
            this.listBoxListChat.TabIndex = 1;
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPesan.Location = new System.Drawing.Point(46, 812);
            this.textBoxPesan.Multiline = true;
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(1488, 96);
            this.textBoxPesan.TabIndex = 2;
            // 
            // buttonKirim
            // 
            this.buttonKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonKirim.Location = new System.Drawing.Point(1558, 812);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(295, 96);
            this.buttonKirim.TabIndex = 3;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // FormPercakapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxPesan);
            this.Controls.Add(this.listBoxListChat);
            this.Controls.Add(this.labelTeman);
            this.Name = "FormPercakapan";
            this.Text = "FormPercakapan";
            this.Load += new System.EventHandler(this.FormPercakapan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeman;
        private System.Windows.Forms.ListBox listBoxListChat;
        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.Button buttonKirim;
    }
}