
namespace WindowsFormsApp1.Forms
{
    partial class AddArtist
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
            this.tbAddCountry = new System.Windows.Forms.TextBox();
            this.tbAddArtistName = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Страна";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Имя артиста";
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(16, 143);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(100, 35);
            this.bAdd.TabIndex = 24;
            this.bAdd.Text = "Добавить";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbAddCountry
            // 
            this.tbAddCountry.Location = new System.Drawing.Point(16, 103);
            this.tbAddCountry.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddCountry.Name = "tbAddCountry";
            this.tbAddCountry.Size = new System.Drawing.Size(357, 27);
            this.tbAddCountry.TabIndex = 23;
            // 
            // tbAddArtistName
            // 
            this.tbAddArtistName.Location = new System.Drawing.Point(16, 43);
            this.tbAddArtistName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAddArtistName.Name = "tbAddArtistName";
            this.tbAddArtistName.Size = new System.Drawing.Size(357, 27);
            this.tbAddArtistName.TabIndex = 22;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(275, 143);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 27;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // AddArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 209);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.tbAddCountry);
            this.Controls.Add(this.tbAddArtistName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить артиста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.TextBox tbAddCountry;
        private System.Windows.Forms.TextBox tbAddArtistName;
        private System.Windows.Forms.Button bClose;
    }
}