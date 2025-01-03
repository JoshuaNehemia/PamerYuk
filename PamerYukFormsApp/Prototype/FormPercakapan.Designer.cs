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
            this.dataGridViewDaftarTeman = new System.Windows.Forms.DataGridView();
            this.listBoxListChat = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTeman
            // 
            this.labelTeman.AutoSize = true;
            this.labelTeman.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTeman.Location = new System.Drawing.Point(19, 23);
            this.labelTeman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTeman.Name = "labelTeman";
            this.labelTeman.Size = new System.Drawing.Size(189, 40);
            this.labelTeman.TabIndex = 0;
            this.labelTeman.Text = "labelNama";
            // 
            // dataGridViewDaftarTeman
            // 
            this.dataGridViewDaftarTeman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDaftarTeman.Location = new System.Drawing.Point(26, 86);
            this.dataGridViewDaftarTeman.Name = "dataGridViewDaftarTeman";
            this.dataGridViewDaftarTeman.RowHeadersWidth = 62;
            this.dataGridViewDaftarTeman.RowTemplate.Height = 28;
            this.dataGridViewDaftarTeman.Size = new System.Drawing.Size(1016, 453);
            this.dataGridViewDaftarTeman.TabIndex = 4;
            this.dataGridViewDaftarTeman.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDaftarTeman_CellContentClick);
            // 
            // listBoxListChat
            // 
            this.listBoxListChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.listBoxListChat.FormattingEnabled = true;
            this.listBoxListChat.ItemHeight = 29;
            this.listBoxListChat.Location = new System.Drawing.Point(26, 572);
            this.listBoxListChat.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxListChat.Name = "listBoxListChat";
            this.listBoxListChat.Size = new System.Drawing.Size(1018, 33);
            this.listBoxListChat.TabIndex = 1;
            // 
            // FormPercakapan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 640);
            this.Controls.Add(this.dataGridViewDaftarTeman);
            this.Controls.Add(this.listBoxListChat);
            this.Controls.Add(this.labelTeman);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPercakapan";
            this.Text = "FormPercakapan";
            this.Load += new System.EventHandler(this.FormPercakapan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaftarTeman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTeman;
        private System.Windows.Forms.DataGridView dataGridViewDaftarTeman;
        private System.Windows.Forms.ListBox listBoxListChat;
    }
}