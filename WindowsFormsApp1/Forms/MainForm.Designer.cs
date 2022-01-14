
namespace WindowsFormsApp1
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucMainScreen1 = new WindowsFormsApp1.UserControls.ucMainScreen();
            this.SuspendLayout();
            // 
            // ucMainScreen1
            // 
            this.ucMainScreen1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ucMainScreen1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucMainScreen1.Location = new System.Drawing.Point(-1, -2);
            this.ucMainScreen1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMainScreen1.Name = "ucMainScreen1";
            this.ucMainScreen1.Size = new System.Drawing.Size(984, 519);
            this.ucMainScreen1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 515);
            this.Controls.Add(this.ucMainScreen1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Музыкальный микс";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucMainScreen ucMainScreen1;
    }
}

