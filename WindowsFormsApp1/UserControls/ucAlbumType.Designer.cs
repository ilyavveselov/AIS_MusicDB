
namespace WindowsFormsApp1.UserControls
{
    partial class ucAlbumType
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
            this.dgvAlbumType_View = new System.Windows.Forms.DataGridView();
            this.aTypeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типальбомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAlbumType = new System.Windows.Forms.BindingSource(this.components);
            this.tsAlbumType = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumType_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbumType)).BeginInit();
            this.tsAlbumType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlbumType_View
            // 
            this.dgvAlbumType_View.AllowUserToAddRows = false;
            this.dgvAlbumType_View.AllowUserToDeleteRows = false;
            this.dgvAlbumType_View.AutoGenerateColumns = false;
            this.dgvAlbumType_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlbumType_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbumType_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbumType_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.aTypeIdDataGridViewTextBoxColumn,
            this.типальбомаDataGridViewTextBoxColumn});
            this.dgvAlbumType_View.DataSource = this.bsAlbumType;
            this.dgvAlbumType_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlbumType_View.Location = new System.Drawing.Point(0, 25);
            this.dgvAlbumType_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlbumType_View.Name = "dgvAlbumType_View";
            this.dgvAlbumType_View.ReadOnly = true;
            this.dgvAlbumType_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvAlbumType_View.TabIndex = 0;
            // 
            // aTypeIdDataGridViewTextBoxColumn
            // 
            this.aTypeIdDataGridViewTextBoxColumn.DataPropertyName = "aTypeId";
            this.aTypeIdDataGridViewTextBoxColumn.HeaderText = "aTypeId";
            this.aTypeIdDataGridViewTextBoxColumn.Name = "aTypeIdDataGridViewTextBoxColumn";
            this.aTypeIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.aTypeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.aTypeIdDataGridViewTextBoxColumn.Visible = false;
            this.aTypeIdDataGridViewTextBoxColumn.Width = 52;
            // 
            // типальбомаDataGridViewTextBoxColumn
            // 
            this.типальбомаDataGridViewTextBoxColumn.DataPropertyName = "Тип_альбома";
            this.типальбомаDataGridViewTextBoxColumn.HeaderText = "Тип альбома";
            this.типальбомаDataGridViewTextBoxColumn.Name = "типальбомаDataGridViewTextBoxColumn";
            this.типальбомаDataGridViewTextBoxColumn.ReadOnly = true;
            this.типальбомаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.типальбомаDataGridViewTextBoxColumn.Width = 79;
            // 
            // bsAlbumType
            // 
            this.bsAlbumType.DataSource = typeof(WindowsFormsApp1.Model.AlbumType_View);
            this.bsAlbumType.CurrentChanged += new System.EventHandler(this.bsAlbumType_CurrentChanged);
            // 
            // tsAlbumType
            // 
            this.tsAlbumType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsAlbumType.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAlbumType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsAlbumType.Location = new System.Drawing.Point(0, 0);
            this.tsAlbumType.Name = "tsAlbumType";
            this.tsAlbumType.Size = new System.Drawing.Size(1297, 25);
            this.tsAlbumType.TabIndex = 1;
            this.tsAlbumType.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(59, 22);
            this.tsAdd.Text = "Добавить";
            this.tsAdd.Click += new System.EventHandler(this.tsAdd_Click);
            // 
            // tsChange
            // 
            this.tsChange.Name = "tsChange";
            this.tsChange.Size = new System.Drawing.Size(61, 22);
            this.tsChange.Text = "Изменить";
            this.tsChange.Click += new System.EventHandler(this.tsChange_Click);
            // 
            // tsDelete
            // 
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(51, 22);
            this.tsDelete.Text = "Удалить";
            this.tsDelete.Click += new System.EventHandler(this.tsDelete_Click);
            // 
            // cbOrderBy
            // 
            this.cbOrderBy.Items.AddRange(new object[] {
            "По возрастанию",
            "По убыванию"});
            this.cbOrderBy.Name = "cbOrderBy";
            this.cbOrderBy.Size = new System.Drawing.Size(121, 25);
            // 
            // tsFilter
            // 
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(78, 22);
            this.tsFilter.Text = "Фильтровать";
            this.tsFilter.Click += new System.EventHandler(this.tsFilter_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(200, 25);
            // 
            // tsSearch
            // 
            this.tsSearch.Name = "tsSearch";
            this.tsSearch.Size = new System.Drawing.Size(42, 22);
            this.tsSearch.Text = "Поиск";
            this.tsSearch.Click += new System.EventHandler(this.tsSearch_Click);
            // 
            // tsReset
            // 
            this.tsReset.Name = "tsReset";
            this.tsReset.Size = new System.Drawing.Size(99, 22);
            this.tsReset.Text = "Сброс фильтров";
            this.tsReset.Click += new System.EventHandler(this.tsReset_Click);
            // 
            // ucAlbumType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAlbumType_View);
            this.Controls.Add(this.tsAlbumType);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAlbumType";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucAlbumType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbumType_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbumType)).EndInit();
            this.tsAlbumType.ResumeLayout(false);
            this.tsAlbumType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbumType_View;
        private System.Windows.Forms.ToolStrip tsAlbumType;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn aTypeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типальбомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsAlbumType;
    }
}
