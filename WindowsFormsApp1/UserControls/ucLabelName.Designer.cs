
namespace WindowsFormsApp1.UserControls
{
    partial class ucLabelName
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
            this.dgvLabelName_View = new System.Windows.Forms.DataGridView();
            this.lIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиелейблаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsLabelName_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsLabelName = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabelName_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabelName_View)).BeginInit();
            this.tsLabelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLabelName_View
            // 
            this.dgvLabelName_View.AllowUserToAddRows = false;
            this.dgvLabelName_View.AllowUserToDeleteRows = false;
            this.dgvLabelName_View.AutoGenerateColumns = false;
            this.dgvLabelName_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvLabelName_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLabelName_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLabelName_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lIdDataGridViewTextBoxColumn,
            this.названиелейблаDataGridViewTextBoxColumn});
            this.dgvLabelName_View.DataSource = this.bsLabelName_View;
            this.dgvLabelName_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLabelName_View.Location = new System.Drawing.Point(0, 25);
            this.dgvLabelName_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLabelName_View.Name = "dgvLabelName_View";
            this.dgvLabelName_View.ReadOnly = true;
            this.dgvLabelName_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvLabelName_View.TabIndex = 2;
            // 
            // lIdDataGridViewTextBoxColumn
            // 
            this.lIdDataGridViewTextBoxColumn.DataPropertyName = "lId";
            this.lIdDataGridViewTextBoxColumn.HeaderText = "lId";
            this.lIdDataGridViewTextBoxColumn.Name = "lIdDataGridViewTextBoxColumn";
            this.lIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.lIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.lIdDataGridViewTextBoxColumn.Visible = false;
            this.lIdDataGridViewTextBoxColumn.Width = 24;
            // 
            // названиелейблаDataGridViewTextBoxColumn
            // 
            this.названиелейблаDataGridViewTextBoxColumn.DataPropertyName = "Название_лейбла";
            this.названиелейблаDataGridViewTextBoxColumn.HeaderText = "Название лейбла";
            this.названиелейблаDataGridViewTextBoxColumn.Name = "названиелейблаDataGridViewTextBoxColumn";
            this.названиелейблаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиелейблаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.названиелейблаDataGridViewTextBoxColumn.Width = 123;
            // 
            // bsLabelName_View
            // 
            this.bsLabelName_View.DataSource = typeof(WindowsFormsApp1.Model.LabelName_View);
            this.bsLabelName_View.CurrentChanged += new System.EventHandler(this.bsLabelName_View_CurrentChanged);
            // 
            // tsLabelName
            // 
            this.tsLabelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsLabelName.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsLabelName.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsLabelName.Location = new System.Drawing.Point(0, 0);
            this.tsLabelName.Name = "tsLabelName";
            this.tsLabelName.Size = new System.Drawing.Size(1297, 25);
            this.tsLabelName.TabIndex = 3;
            this.tsLabelName.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(76, 22);
            this.tsAdd.Text = "Добавить";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsChange
            // 
            this.tsChange.Name = "tsChange";
            this.tsChange.Size = new System.Drawing.Size(78, 22);
            this.tsChange.Text = "Изменить";
            this.tsChange.Click += new System.EventHandler(this.tsChange_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(65, 22);
            this.tsDelete.Text = "Удалить";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(160, 25);
            // 
            // tsFilter
            // 
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(99, 22);
            this.tsFilter.Text = "Фильтровать";
            this.tsFilter.Click += new System.EventHandler(this.tsFilter_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 25);
            // 
            // tsSearch
            // 
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(52, 22);
            this.tsSearch.Text = "Поиск";
            this.tsSearch.Click += new System.EventHandler(this.tsSearch_Click);
            // 
            // tsReset
            // 
            this.tsReset.Name = "tsReset";
            this.tsReset.Size = new System.Drawing.Size(123, 22);
            this.tsReset.Text = "Сброс фильтров";
            this.tsReset.Click += new System.EventHandler(this.tsReset_Click);
            // 
            // ucLabelName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvLabelName_View);
            this.Controls.Add(this.tsLabelName);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucLabelName";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucLabelName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLabelName_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLabelName_View)).EndInit();
            this.tsLabelName.ResumeLayout(false);
            this.tsLabelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLabelName_View;
        private System.Windows.Forms.ToolStrip tsLabelName;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn lIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиелейблаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsLabelName_View;
    }
}
