
namespace WindowsFormsApp1.Forms
{
    partial class AddLabelName
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtboxAdd = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(16, 14);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(131, 20);
            this.lblAdd.TabIndex = 8;
            this.lblAdd.Text = "Название лейбла";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 91);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtboxAdd
            // 
            this.txtboxAdd.Location = new System.Drawing.Point(20, 54);
            this.txtboxAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtboxAdd.Name = "txtboxAdd";
            this.txtboxAdd.Size = new System.Drawing.Size(353, 27);
            this.txtboxAdd.TabIndex = 6;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(273, 91);
            this.bClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(100, 35);
            this.bClose.TabIndex = 9;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // AddLabelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 146);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxAdd);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddLabelName";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить лейбл";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtboxAdd;
        private System.Windows.Forms.Button bClose;
    }
}