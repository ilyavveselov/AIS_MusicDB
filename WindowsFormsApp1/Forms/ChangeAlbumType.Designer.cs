
namespace WindowsFormsApp1.Forms
{
    partial class ChangeAlbumType
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
            this.tbNewInfo = new System.Windows.Forms.TextBox();
            this.bChange = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbNewInfo
            // 
            this.tbNewInfo.Location = new System.Drawing.Point(16, 55);
            this.tbNewInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewInfo.Name = "tbNewInfo";
            this.tbNewInfo.Size = new System.Drawing.Size(241, 27);
            this.tbNewInfo.TabIndex = 3;
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(16, 95);
            this.bChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(100, 35);
            this.bChange.TabIndex = 4;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Название типа альбома";
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(159, 95);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 7;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ChangeAlbumType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 149);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.tbNewInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeAlbumType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип альбома";
            this.Load += new System.EventHandler(this.ChangeAlbumType_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbNewInfo;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bClose;
    }
}