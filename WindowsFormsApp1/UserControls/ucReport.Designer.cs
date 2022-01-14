
namespace WindowsFormsApp1.UserControls
{
    partial class ucReport
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReport));
            this.bReport = new System.Windows.Forms.Button();
            this.report1 = new FastReport.Report();
            this.bsAlbum_View = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum_View)).BeginInit();
            this.SuspendLayout();
            // 
            // bReport
            // 
            this.bReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bReport.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReport.Location = new System.Drawing.Point(0, 0);
            this.bReport.Name = "bReport";
            this.bReport.Size = new System.Drawing.Size(581, 483);
            this.bReport.TabIndex = 0;
            this.bReport.Text = "Открыть отчет";
            this.bReport.UseVisualStyleBackColor = true;
            this.bReport.Click += new System.EventHandler(this.bReport_Click);
            // 
            // report1
            // 
            this.report1.NeedRefresh = false;
            this.report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            this.report1.Tag = null;
            this.report1.RegisterData(this.bsAlbum_View, "bsAlbum_View");
            // 
            // bsAlbum_View
            // 
            this.bsAlbum_View.DataSource = typeof(WindowsFormsApp1.Model.Album_View);
            // 
            // ucReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bReport);
            this.Name = "ucReport";
            this.Size = new System.Drawing.Size(581, 483);
            ((System.ComponentModel.ISupportInitialize)(this.report1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum_View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bReport;
        private FastReport.Report report1;
        private System.Windows.Forms.BindingSource bsAlbum_View;
    }
}
