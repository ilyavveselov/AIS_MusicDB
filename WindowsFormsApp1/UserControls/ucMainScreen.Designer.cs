
namespace WindowsFormsApp1.UserControls
{
    partial class ucMainScreen
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcntrlMain = new System.Windows.Forms.TabControl();
            this.tpAlbum = new System.Windows.Forms.TabPage();
            this.ucAlbum1 = new WindowsFormsApp1.UserControls.ucAlbum();
            this.tpSong = new System.Windows.Forms.TabPage();
            this.ucSong1 = new WindowsFormsApp1.UserControls.ucSong();
            this.tpArtist = new System.Windows.Forms.TabPage();
            this.ucArtist1 = new WindowsFormsApp1.UserControls.ucArtist();
            this.tpCountry = new System.Windows.Forms.TabPage();
            this.ucCountry1 = new WindowsFormsApp1.UserControls.ucCountry();
            this.tpLabel = new System.Windows.Forms.TabPage();
            this.ucLabelName1 = new WindowsFormsApp1.UserControls.ucLabelName();
            this.tpGenre = new System.Windows.Forms.TabPage();
            this.ucGenre1 = new WindowsFormsApp1.UserControls.ucGenre();
            this.tpAlbumType = new System.Windows.Forms.TabPage();
            this.ucAlbumType1 = new WindowsFormsApp1.UserControls.ucAlbumType();
            this.tpMix = new System.Windows.Forms.TabPage();
            this.ucMusicMix1 = new WindowsFormsApp1.UserControls.ucMusicMix();
            this.tpReport = new System.Windows.Forms.TabPage();
            this.ucReport1 = new WindowsFormsApp1.UserControls.ucReport();
            this.tbcntrlMain.SuspendLayout();
            this.tpAlbum.SuspendLayout();
            this.tpSong.SuspendLayout();
            this.tpArtist.SuspendLayout();
            this.tpCountry.SuspendLayout();
            this.tpLabel.SuspendLayout();
            this.tpGenre.SuspendLayout();
            this.tpAlbumType.SuspendLayout();
            this.tpMix.SuspendLayout();
            this.tpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcntrlMain
            // 
            this.tbcntrlMain.Controls.Add(this.tpAlbum);
            this.tbcntrlMain.Controls.Add(this.tpSong);
            this.tbcntrlMain.Controls.Add(this.tpArtist);
            this.tbcntrlMain.Controls.Add(this.tpCountry);
            this.tbcntrlMain.Controls.Add(this.tpLabel);
            this.tbcntrlMain.Controls.Add(this.tpGenre);
            this.tbcntrlMain.Controls.Add(this.tpAlbumType);
            this.tbcntrlMain.Controls.Add(this.tpMix);
            this.tbcntrlMain.Controls.Add(this.tpReport);
            this.tbcntrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbcntrlMain.Location = new System.Drawing.Point(0, 0);
            this.tbcntrlMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcntrlMain.Name = "tbcntrlMain";
            this.tbcntrlMain.SelectedIndex = 0;
            this.tbcntrlMain.Size = new System.Drawing.Size(1312, 798);
            this.tbcntrlMain.TabIndex = 0;
            // 
            // tpAlbum
            // 
            this.tpAlbum.AccessibleName = "";
            this.tpAlbum.Controls.Add(this.ucAlbum1);
            this.tpAlbum.Location = new System.Drawing.Point(4, 29);
            this.tpAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAlbum.Name = "tpAlbum";
            this.tpAlbum.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAlbum.Size = new System.Drawing.Size(1304, 765);
            this.tpAlbum.TabIndex = 0;
            this.tpAlbum.Text = "Альбом";
            this.tpAlbum.UseVisualStyleBackColor = true;
            // 
            // ucAlbum1
            // 
            this.ucAlbum1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAlbum1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucAlbum1.Location = new System.Drawing.Point(4, 5);
            this.ucAlbum1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAlbum1.Name = "ucAlbum1";
            this.ucAlbum1.Size = new System.Drawing.Size(1296, 755);
            this.ucAlbum1.TabIndex = 0;
            // 
            // tpSong
            // 
            this.tpSong.Controls.Add(this.ucSong1);
            this.tpSong.Location = new System.Drawing.Point(4, 29);
            this.tpSong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpSong.Name = "tpSong";
            this.tpSong.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpSong.Size = new System.Drawing.Size(1304, 765);
            this.tpSong.TabIndex = 1;
            this.tpSong.Text = "Песни";
            this.tpSong.UseVisualStyleBackColor = true;
            // 
            // ucSong1
            // 
            this.ucSong1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSong1.Location = new System.Drawing.Point(4, 5);
            this.ucSong1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucSong1.Name = "ucSong1";
            this.ucSong1.Size = new System.Drawing.Size(1296, 755);
            this.ucSong1.TabIndex = 0;
            // 
            // tpArtist
            // 
            this.tpArtist.Controls.Add(this.ucArtist1);
            this.tpArtist.Location = new System.Drawing.Point(4, 29);
            this.tpArtist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpArtist.Name = "tpArtist";
            this.tpArtist.Size = new System.Drawing.Size(1304, 765);
            this.tpArtist.TabIndex = 5;
            this.tpArtist.Text = "Артисты";
            this.tpArtist.UseVisualStyleBackColor = true;
            // 
            // ucArtist1
            // 
            this.ucArtist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucArtist1.Location = new System.Drawing.Point(0, 0);
            this.ucArtist1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucArtist1.Name = "ucArtist1";
            this.ucArtist1.Size = new System.Drawing.Size(1304, 765);
            this.ucArtist1.TabIndex = 0;
            // 
            // tpCountry
            // 
            this.tpCountry.Controls.Add(this.ucCountry1);
            this.tpCountry.Location = new System.Drawing.Point(4, 29);
            this.tpCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpCountry.Name = "tpCountry";
            this.tpCountry.Size = new System.Drawing.Size(1304, 765);
            this.tpCountry.TabIndex = 2;
            this.tpCountry.Text = "Страны";
            this.tpCountry.UseVisualStyleBackColor = true;
            // 
            // ucCountry1
            // 
            this.ucCountry1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucCountry1.Location = new System.Drawing.Point(0, 0);
            this.ucCountry1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucCountry1.Name = "ucCountry1";
            this.ucCountry1.Size = new System.Drawing.Size(1304, 765);
            this.ucCountry1.TabIndex = 0;
            // 
            // tpLabel
            // 
            this.tpLabel.Controls.Add(this.ucLabelName1);
            this.tpLabel.Location = new System.Drawing.Point(4, 29);
            this.tpLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpLabel.Name = "tpLabel";
            this.tpLabel.Size = new System.Drawing.Size(1304, 765);
            this.tpLabel.TabIndex = 3;
            this.tpLabel.Text = "Лейблы";
            this.tpLabel.UseVisualStyleBackColor = true;
            // 
            // ucLabelName1
            // 
            this.ucLabelName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLabelName1.Location = new System.Drawing.Point(0, 0);
            this.ucLabelName1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucLabelName1.Name = "ucLabelName1";
            this.ucLabelName1.Size = new System.Drawing.Size(1304, 765);
            this.ucLabelName1.TabIndex = 0;
            // 
            // tpGenre
            // 
            this.tpGenre.Controls.Add(this.ucGenre1);
            this.tpGenre.Location = new System.Drawing.Point(4, 29);
            this.tpGenre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpGenre.Name = "tpGenre";
            this.tpGenre.Size = new System.Drawing.Size(1304, 765);
            this.tpGenre.TabIndex = 4;
            this.tpGenre.Text = "Жанры";
            this.tpGenre.UseVisualStyleBackColor = true;
            // 
            // ucGenre1
            // 
            this.ucGenre1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGenre1.Location = new System.Drawing.Point(0, 0);
            this.ucGenre1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucGenre1.Name = "ucGenre1";
            this.ucGenre1.Size = new System.Drawing.Size(1304, 765);
            this.ucGenre1.TabIndex = 0;
            // 
            // tpAlbumType
            // 
            this.tpAlbumType.Controls.Add(this.ucAlbumType1);
            this.tpAlbumType.Location = new System.Drawing.Point(4, 29);
            this.tpAlbumType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpAlbumType.Name = "tpAlbumType";
            this.tpAlbumType.Size = new System.Drawing.Size(1304, 765);
            this.tpAlbumType.TabIndex = 6;
            this.tpAlbumType.Text = "Типы альбомов";
            this.tpAlbumType.UseVisualStyleBackColor = true;
            // 
            // ucAlbumType1
            // 
            this.ucAlbumType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucAlbumType1.Location = new System.Drawing.Point(0, 0);
            this.ucAlbumType1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucAlbumType1.Name = "ucAlbumType1";
            this.ucAlbumType1.Size = new System.Drawing.Size(1304, 765);
            this.ucAlbumType1.TabIndex = 0;
            // 
            // tpMix
            // 
            this.tpMix.Controls.Add(this.ucMusicMix1);
            this.tpMix.Location = new System.Drawing.Point(4, 29);
            this.tpMix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpMix.Name = "tpMix";
            this.tpMix.Size = new System.Drawing.Size(1304, 765);
            this.tpMix.TabIndex = 7;
            this.tpMix.Text = "Миксы";
            this.tpMix.UseVisualStyleBackColor = true;
            // 
            // ucMusicMix1
            // 
            this.ucMusicMix1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucMusicMix1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucMusicMix1.Location = new System.Drawing.Point(0, 0);
            this.ucMusicMix1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMusicMix1.Name = "ucMusicMix1";
            this.ucMusicMix1.Size = new System.Drawing.Size(1304, 765);
            this.ucMusicMix1.TabIndex = 0;
            // 
            // tpReport
            // 
            this.tpReport.Controls.Add(this.ucReport1);
            this.tpReport.Location = new System.Drawing.Point(4, 29);
            this.tpReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tpReport.Name = "tpReport";
            this.tpReport.Size = new System.Drawing.Size(1304, 765);
            this.tpReport.TabIndex = 8;
            this.tpReport.Text = "Отчеты";
            this.tpReport.UseVisualStyleBackColor = true;
            // 
            // ucReport1
            // 
            this.ucReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucReport1.Location = new System.Drawing.Point(0, 0);
            this.ucReport1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucReport1.Name = "ucReport1";
            this.ucReport1.Size = new System.Drawing.Size(1304, 765);
            this.ucReport1.TabIndex = 0;
            // 
            // ucMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbcntrlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMainScreen";
            this.Size = new System.Drawing.Size(1312, 798);
            this.tbcntrlMain.ResumeLayout(false);
            this.tpAlbum.ResumeLayout(false);
            this.tpSong.ResumeLayout(false);
            this.tpArtist.ResumeLayout(false);
            this.tpCountry.ResumeLayout(false);
            this.tpLabel.ResumeLayout(false);
            this.tpGenre.ResumeLayout(false);
            this.tpAlbumType.ResumeLayout(false);
            this.tpMix.ResumeLayout(false);
            this.tpReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcntrlMain;
        private System.Windows.Forms.TabPage tpAlbum;
        private System.Windows.Forms.TabPage tpSong;
        private System.Windows.Forms.TabPage tpCountry;
        private System.Windows.Forms.TabPage tpLabel;
        private ucAlbum ucAlbum1;
        private System.Windows.Forms.TabPage tpGenre;
        private System.Windows.Forms.TabPage tpArtist;
        private System.Windows.Forms.TabPage tpAlbumType;
        private ucCountry ucCountry1;
        private ucGenre ucGenre1;
        private ucSong ucSong1;
        private ucArtist ucArtist1;
        private ucLabelName ucLabelName1;
        private ucAlbumType ucAlbumType1;
        private System.Windows.Forms.TabPage tpMix;
        private ucMusicMix ucMusicMix1;
        private System.Windows.Forms.TabPage tpReport;
        private ucReport ucReport1;
    }
}
