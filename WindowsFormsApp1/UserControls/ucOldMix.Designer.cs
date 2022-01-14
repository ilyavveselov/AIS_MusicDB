
namespace WindowsFormsApp1.UserControls
{
    partial class ucOldMix
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
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.bsList = new System.Windows.Forms.BindingSource(this.components);
            this.tsList = new System.Windows.Forms.ToolStrip();
            this.tsOpen = new System.Windows.Forms.ToolStripLabel();
            this.номерспискаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяПользователяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).BeginInit();
            this.tsList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoGenerateColumns = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерспискаDataGridViewTextBoxColumn,
            this.имяПользователяDataGridViewTextBoxColumn});
            this.dgvList.DataSource = this.bsList;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.Location = new System.Drawing.Point(0, 25);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(1297, 724);
            this.dgvList.TabIndex = 0;
            // 
            // bsList
            // 
            this.bsList.DataSource = typeof(WindowsFormsApp1.Model.List_View);
            this.bsList.CurrentChanged += new System.EventHandler(this.bsList_CurrentChanged);
            // 
            // tsList
            // 
            this.tsList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsList.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen});
            this.tsList.Location = new System.Drawing.Point(0, 0);
            this.tsList.Name = "tsList";
            this.tsList.Size = new System.Drawing.Size(1297, 25);
            this.tsList.TabIndex = 1;
            this.tsList.Text = "toolStrip1";
            // 
            // tsOpen
            // 
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(119, 22);
            this.tsOpen.Text = "Открыть список";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // номерспискаDataGridViewTextBoxColumn
            // 
            this.номерспискаDataGridViewTextBoxColumn.DataPropertyName = "Номер_списка";
            this.номерспискаDataGridViewTextBoxColumn.HeaderText = "Номер списка";
            this.номерспискаDataGridViewTextBoxColumn.Name = "номерспискаDataGridViewTextBoxColumn";
            this.номерспискаDataGridViewTextBoxColumn.Width = 133;
            // 
            // имяПользователяDataGridViewTextBoxColumn
            // 
            this.имяПользователяDataGridViewTextBoxColumn.DataPropertyName = "Имя_Пользователя";
            this.имяПользователяDataGridViewTextBoxColumn.HeaderText = "Имя Пользователя";
            this.имяПользователяDataGridViewTextBoxColumn.Name = "имяПользователяDataGridViewTextBoxColumn";
            this.имяПользователяDataGridViewTextBoxColumn.Width = 151;
            // 
            // ucOldMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.tsList);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucOldMix";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucOldMix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsList)).EndInit();
            this.tsList.ResumeLayout(false);
            this.tsList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ToolStrip tsList;
        private System.Windows.Forms.ToolStripLabel tsOpen;
        private System.Windows.Forms.BindingSource bsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерспискаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяПользователяDataGridViewTextBoxColumn;
    }
}
