
namespace WindowsFormsApp1.Forms
{
    partial class OldMixForm
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
            this.ucOldMix1 = new WindowsFormsApp1.UserControls.ucOldMix();
            this.SuspendLayout();
            // 
            // ucOldMix1
            // 
            this.ucOldMix1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucOldMix1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ucOldMix1.Location = new System.Drawing.Point(0, 0);
            this.ucOldMix1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucOldMix1.Name = "ucOldMix1";
            this.ucOldMix1.Size = new System.Drawing.Size(1067, 692);
            this.ucOldMix1.TabIndex = 0;
            // 
            // OldMixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.ucOldMix1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OldMixForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Старые миксы";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ucOldMix ucOldMix1;
    }
}