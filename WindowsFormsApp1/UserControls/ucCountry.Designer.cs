
namespace WindowsFormsApp1.UserControls
{
    partial class ucCountry
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
            this.dgvCountry_View = new System.Windows.Forms.DataGridView();
            this.cIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsCountry_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsCountry = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry_View)).BeginInit();
            this.tsCountry.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCountry_View
            // 
            this.dgvCountry_View.AllowUserToAddRows = false;
            this.dgvCountry_View.AllowUserToDeleteRows = false;
            this.dgvCountry_View.AutoGenerateColumns = false;
            this.dgvCountry_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCountry_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCountry_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCountry_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIdDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn});
            this.dgvCountry_View.DataSource = this.bsCountry_View;
            this.dgvCountry_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCountry_View.Location = new System.Drawing.Point(0, 25);
            this.dgvCountry_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCountry_View.Name = "dgvCountry_View";
            this.dgvCountry_View.ReadOnly = true;
            this.dgvCountry_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvCountry_View.TabIndex = 2;
            // 
            // cIdDataGridViewTextBoxColumn
            // 
            this.cIdDataGridViewTextBoxColumn.DataPropertyName = "cId";
            this.cIdDataGridViewTextBoxColumn.HeaderText = "cId";
            this.cIdDataGridViewTextBoxColumn.Name = "cIdDataGridViewTextBoxColumn";
            this.cIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cIdDataGridViewTextBoxColumn.Visible = false;
            this.cIdDataGridViewTextBoxColumn.Width = 28;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.ReadOnly = true;
            this.странаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.странаDataGridViewTextBoxColumn.Width = 64;
            // 
            // bsCountry_View
            // 
            this.bsCountry_View.DataSource = typeof(WindowsFormsApp1.Model.Country_View);
            this.bsCountry_View.CurrentChanged += new System.EventHandler(this.bsCountry_View_CurrentChanged);
            // 
            // tsCountry
            // 
            this.tsCountry.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsCountry.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsCountry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsCountry.Location = new System.Drawing.Point(0, 0);
            this.tsCountry.Name = "tsCountry";
            this.tsCountry.Size = new System.Drawing.Size(1297, 25);
            this.tsCountry.TabIndex = 3;
            this.tsCountry.Text = "toolStrip1";
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
            // ucCountry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvCountry_View);
            this.Controls.Add(this.tsCountry);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucCountry";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucCountry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCountry_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCountry_View)).EndInit();
            this.tsCountry.ResumeLayout(false);
            this.tsCountry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCountry_View;
        private System.Windows.Forms.ToolStrip tsCountry;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.BindingSource bsCountry_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
    }
}
