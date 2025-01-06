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
            this.buttonKirim = new System.Windows.Forms.Button();
            this.textBoxPesan = new System.Windows.Forms.TextBox();
            this.listBoxListChat = new System.Windows.Forms.ListBox();
            this.labelTeman = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKirim
            // 
            this.buttonKirim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonKirim.Location = new System.Drawing.Point(876, 539);
            this.buttonKirim.Margin = new System.Windows.Forms.Padding(2);
            this.buttonKirim.Name = "buttonKirim";
            this.buttonKirim.Size = new System.Drawing.Size(166, 62);
            this.buttonKirim.TabIndex = 7;
            this.buttonKirim.Text = "Kirim";
            this.buttonKirim.UseVisualStyleBackColor = true;
            this.buttonKirim.Click += new System.EventHandler(this.buttonKirim_Click);
            // 
            // textBoxPesan
            // 
            this.textBoxPesan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBoxPesan.Location = new System.Drawing.Point(26, 539);
            this.textBoxPesan.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPesan.Multiline = true;
            this.textBoxPesan.Name = "textBoxPesan";
            this.textBoxPesan.Size = new System.Drawing.Size(839, 63);
            this.textBoxPesan.TabIndex = 6;
            // 
            // listBoxListChat
            // 
            this.listBoxListChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxListChat.FormattingEnabled = true;
            this.listBoxListChat.ItemHeight = 29;
            this.listBoxListChat.Location = new System.Drawing.Point(26, 100);
            this.listBoxListChat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxListChat.Name = "listBoxListChat";
            this.listBoxListChat.Size = new System.Drawing.Size(1018, 410);
            this.listBoxListChat.TabIndex = 5;
            // 
            // labelTeman
            // 
            this.labelTeman.AutoSize = true;
            this.labelTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTeman.Location = new System.Drawing.Point(19, 38);
            this.labelTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeman.Name = "labelTeman";
            this.labelTeman.Size = new System.Drawing.Size(189, 40);
            this.labelTeman.TabIndex = 4;
            this.labelTeman.Text = "labelNama";
            // 
            // FormPercakapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 640);
            this.Controls.Add(this.buttonKirim);
            this.Controls.Add(this.textBoxPesan);
            this.Controls.Add(this.listBoxListChat);
            this.Controls.Add(this.labelTeman);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPercakapan";
            this.Text = "FormPercakapan";
            this.Load += new System.EventHandler(this.FormPercakapan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKirim;
        private System.Windows.Forms.TextBox textBoxPesan;
        private System.Windows.Forms.ListBox listBoxListChat;
        private System.Windows.Forms.Label labelTeman;
    }
}