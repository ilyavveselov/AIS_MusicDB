
namespace WindowsFormsApp1.Forms
{
    partial class ChangeArtist
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
            this.label4 = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.tbNewInfo = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Имя артиста";
            // 
            // bChange
            // 
            this.bChange.Location = new System.Drawing.Point(16, 78);
            this.bChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(100, 35);
            this.bChange.TabIndex = 20;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // tbNewInfo
            // 
            this.tbNewInfo.Location = new System.Drawing.Point(16, 38);
            this.tbNewInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNewInfo.Name = "tbNewInfo";
            this.tbNewInfo.Size = new System.Drawing.Size(409, 27);
            this.tbNewInfo.TabIndex = 19;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(316, 78);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 23;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // ChangeArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 128);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.tbNewInfo);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChangeArtist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Артист";
            this.Load += new System.EventHandler(this.ChangeArtist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.TextBox tbNewInfo;
        private System.Windows.Forms.Button bClose;
    }
}