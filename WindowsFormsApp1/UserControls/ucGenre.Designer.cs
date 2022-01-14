
namespace WindowsFormsApp1.UserControls
{
    partial class ucGenre
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
            this.dgvGenre_View = new System.Windows.Forms.DataGridView();
            this.gIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиежанраDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsGenre_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsGenre = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre_View)).BeginInit();
            this.tsGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGenre_View
            // 
            this.dgvGenre_View.AllowUserToAddRows = false;
            this.dgvGenre_View.AllowUserToDeleteRows = false;
            this.dgvGenre_View.AutoGenerateColumns = false;
            this.dgvGenre_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvGenre_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGenre_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGenre_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gIdDataGridViewTextBoxColumn,
            this.названиежанраDataGridViewTextBoxColumn});
            this.dgvGenre_View.DataSource = this.bsGenre_View;
            this.dgvGenre_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGenre_View.Location = new System.Drawing.Point(0, 25);
            this.dgvGenre_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvGenre_View.Name = "dgvGenre_View";
            this.dgvGenre_View.ReadOnly = true;
            this.dgvGenre_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvGenre_View.TabIndex = 2;
            // 
            // gIdDataGridViewTextBoxColumn
            // 
            this.gIdDataGridViewTextBoxColumn.DataPropertyName = "gId";
            this.gIdDataGridViewTextBoxColumn.HeaderText = "gId";
            this.gIdDataGridViewTextBoxColumn.Name = "gIdDataGridViewTextBoxColumn";
            this.gIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.gIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.gIdDataGridViewTextBoxColumn.Visible = false;
            this.gIdDataGridViewTextBoxColumn.Width = 28;
            // 
            // названиежанраDataGridViewTextBoxColumn
            // 
            this.названиежанраDataGridViewTextBoxColumn.DataPropertyName = "Название_жанра";
            this.названиежанраDataGridViewTextBoxColumn.HeaderText = "Название жанра";
            this.названиежанраDataGridViewTextBoxColumn.Name = "названиежанраDataGridViewTextBoxColumn";
            this.названиежанраDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиежанраDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.названиежанраDataGridViewTextBoxColumn.Width = 119;
            // 
            // bsGenre_View
            // 
            this.bsGenre_View.DataSource = typeof(WindowsFormsApp1.Model.Genre_View);
            this.bsGenre_View.CurrentChanged += new System.EventHandler(this.bsGenre_View_CurrentChanged);
            // 
            // tsGenre
            // 
            this.tsGenre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsGenre.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsGenre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsGenre.Location = new System.Drawing.Point(0, 0);
            this.tsGenre.Name = "tsGenre";
            this.tsGenre.Size = new System.Drawing.Size(1297, 25);
            this.tsGenre.TabIndex = 3;
            this.tsGenre.Text = "toolStrip1";
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
            // ucGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvGenre_View);
            this.Controls.Add(this.tsGenre);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucGenre";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucGenre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGenre_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenre_View)).EndInit();
            this.tsGenre.ResumeLayout(false);
            this.tsGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGenre_View;
        private System.Windows.Forms.ToolStrip tsGenre;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn gIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиежанраDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsGenre_View;
    }
}
