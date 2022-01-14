
namespace WindowsFormsApp1.Forms
{
    partial class AddSong
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbAlbumName = new System.Windows.Forms.TextBox();
            this.tbArtistName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSongName = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Название альбома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Имя артиста";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(20, 212);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 35);
            this.bAdd.TabIndex = 29;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbAlbumName
            // 
            this.tbAlbumName.Location = new System.Drawing.Point(16, 112);
            this.tbAlbumName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAlbumName.Name = "tbAlbumName";
            this.tbAlbumName.Size = new System.Drawing.Size(357, 27);
            this.tbAlbumName.TabIndex = 28;
            // 
            // tbArtistName
            // 
            this.tbArtistName.Location = new System.Drawing.Point(16, 52);
            this.tbArtistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbArtistName.Name = "tbArtistName";
            this.tbArtistName.Size = new System.Drawing.Size(357, 27);
            this.tbArtistName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Название песни";
            // 
            // tbSongName
            // 
            this.tbSongName.Location = new System.Drawing.Point(16, 172);
            this.tbSongName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSongName.Name = "tbSongName";
            this.tbSongName.Size = new System.Drawing.Size(357, 27);
            this.tbSongName.TabIndex = 33;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(275, 212);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 34;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 288);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tbSongName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbAlbumName);
            this.Controls.Add(this.tbArtistName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить песню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbAlbumName;
        private System.Windows.Forms.TextBox tbArtistName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSongName;
        private System.Windows.Forms.Button bClose;
    }
}