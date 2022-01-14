
namespace WindowsFormsApp1.Forms
{
    partial class AlbumAdd
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbAddAlbumLabelName = new System.Windows.Forms.TextBox();
            this.tbAddAlbumGenre = new System.Windows.Forms.TextBox();
            this.tbAddAlbumAlbType = new System.Windows.Forms.TextBox();
            this.tbAddAlbumDate = new System.Windows.Forms.TextBox();
            this.tbAddAlbumAlbum = new System.Windows.Forms.TextBox();
            this.tbAddAlbumArtist = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 312);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Лейбл";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 252);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Жанр";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Тип альбома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Дата выхода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Название альбома";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Имя артиста";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(16, 374);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 35);
            this.bAdd.TabIndex = 19;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbAddAlbumLabelName
            // 
            this.tbAddAlbumLabelName.Location = new System.Drawing.Point(16, 337);
            this.tbAddAlbumLabelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumLabelName.Name = "tbAddAlbumLabelName";
            this.tbAddAlbumLabelName.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumLabelName.TabIndex = 18;
            // 
            // tbAddAlbumGenre
            // 
            this.tbAddAlbumGenre.Location = new System.Drawing.Point(16, 277);
            this.tbAddAlbumGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumGenre.Name = "tbAddAlbumGenre";
            this.tbAddAlbumGenre.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumGenre.TabIndex = 17;
            // 
            // tbAddAlbumAlbType
            // 
            this.tbAddAlbumAlbType.Location = new System.Drawing.Point(16, 217);
            this.tbAddAlbumAlbType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumAlbType.Name = "tbAddAlbumAlbType";
            this.tbAddAlbumAlbType.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumAlbType.TabIndex = 16;
            // 
            // tbAddAlbumDate
            // 
            this.tbAddAlbumDate.Location = new System.Drawing.Point(16, 157);
            this.tbAddAlbumDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumDate.Name = "tbAddAlbumDate";
            this.tbAddAlbumDate.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumDate.TabIndex = 15;
            // 
            // tbAddAlbumAlbum
            // 
            this.tbAddAlbumAlbum.Location = new System.Drawing.Point(16, 97);
            this.tbAddAlbumAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumAlbum.Name = "tbAddAlbumAlbum";
            this.tbAddAlbumAlbum.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumAlbum.TabIndex = 14;
            // 
            // tbAddAlbumArtist
            // 
            this.tbAddAlbumArtist.Location = new System.Drawing.Point(16, 37);
            this.tbAddAlbumArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddAlbumArtist.Name = "tbAddAlbumArtist";
            this.tbAddAlbumArtist.Size = new System.Drawing.Size(357, 27);
            this.tbAddAlbumArtist.TabIndex = 13;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(273, 374);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 26;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // AlbumAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 425);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbAddAlbumLabelName);
            this.Controls.Add(this.tbAddAlbumGenre);
            this.Controls.Add(this.tbAddAlbumAlbType);
            this.Controls.Add(this.tbAddAlbumDate);
            this.Controls.Add(this.tbAddAlbumAlbum);
            this.Controls.Add(this.tbAddAlbumArtist);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AlbumAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить альбом";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbAddAlbumLabelName;
        private System.Windows.Forms.TextBox tbAddAlbumGenre;
        private System.Windows.Forms.TextBox tbAddAlbumAlbType;
        private System.Windows.Forms.TextBox tbAddAlbumDate;
        private System.Windows.Forms.TextBox tbAddAlbumAlbum;
        private System.Windows.Forms.TextBox tbAddAlbumArtist;
        private System.Windows.Forms.Button bClose;
    }
}