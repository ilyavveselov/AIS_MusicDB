
namespace WindowsFormsApp1.Forms
{
    partial class ChangeAlbum
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
            this.bChange = new System.Windows.Forms.Button();
            this.tbChangeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbChangeDate = new System.Windows.Forms.MaskedTextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(216, 94);
            this.bChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(100, 35);
            this.bChange.TabIndex = 3;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbChangeName
            // 
            this.tbChangeName.Location = new System.Drawing.Point(16, 38);
            this.tbChangeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbChangeName.Name = "tbChangeName";
            this.tbChangeName.Size = new System.Drawing.Size(409, 27);
            this.tbChangeName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Название альбома";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Дата выхода";
            // 
            // tbChangeDate
            // 
            this.tbChangeDate.Location = new System.Drawing.Point(16, 98);
            this.tbChangeDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbChangeDate.Mask = "00/00/0000";
            this.tbChangeDate.Name = "tbChangeDate";
            this.tbChangeDate.Size = new System.Drawing.Size(192, 27);
            this.tbChangeDate.TabIndex = 13;
            this.tbChangeDate.ValidatingType = typeof(System.DateTime);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(324, 94);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 14;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ChangeAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 139);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.tbChangeDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbChangeName);
            this.Controls.Add(this.bChange);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeAlbum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Альбом";
            this.Load += new System.EventHandler(this.ChangeAlbum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.TextBox tbChangeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox tbChangeDate;
        private System.Windows.Forms.Button bClose;
    }
}