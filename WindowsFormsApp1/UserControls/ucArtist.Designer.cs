
namespace WindowsFormsApp1.UserControls
{
    partial class ucArtist
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
            this.dgvArtist_View = new System.Windows.Forms.DataGridView();
            this.artIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.странаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsArtist_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsArtist = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArtist_View)).BeginInit();
            this.tsArtist.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArtist_View
            // 
            this.dgvArtist_View.AllowUserToAddRows = false;
            this.dgvArtist_View.AllowUserToDeleteRows = false;
            this.dgvArtist_View.AutoGenerateColumns = false;
            this.dgvArtist_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArtist_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArtist_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArtist_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.artIdDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn,
            this.странаDataGridViewTextBoxColumn});
            this.dgvArtist_View.DataSource = this.bsArtist_View;
            this.dgvArtist_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvArtist_View.Location = new System.Drawing.Point(0, 25);
            this.dgvArtist_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArtist_View.Name = "dgvArtist_View";
            this.dgvArtist_View.ReadOnly = true;
            this.dgvArtist_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvArtist_View.TabIndex = 2;
            // 
            // artIdDataGridViewTextBoxColumn
            // 
            this.artIdDataGridViewTextBoxColumn.DataPropertyName = "artId";
            this.artIdDataGridViewTextBoxColumn.HeaderText = "artId";
            this.artIdDataGridViewTextBoxColumn.Name = "artIdDataGridViewTextBoxColumn";
            this.artIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.artIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.artIdDataGridViewTextBoxColumn.Visible = false;
            this.artIdDataGridViewTextBoxColumn.Width = 34;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.ReadOnly = true;
            this.исполнительDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.исполнительDataGridViewTextBoxColumn.Width = 80;
            // 
            // странаDataGridViewTextBoxColumn
            // 
            this.странаDataGridViewTextBoxColumn.DataPropertyName = "Страна";
            this.странаDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.странаDataGridViewTextBoxColumn.Name = "странаDataGridViewTextBoxColumn";
            this.странаDataGridViewTextBoxColumn.ReadOnly = true;
            this.странаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.странаDataGridViewTextBoxColumn.Width = 49;
            // 
            // bsArtist_View
            // 
            this.bsArtist_View.DataSource = typeof(WindowsFormsApp1.Model.Artist_View);
            this.bsArtist_View.CurrentChanged += new System.EventHandler(this.bsArtist_View_CurrentChanged);
            // 
            // tsArtist
            // 
            this.tsArtist.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsArtist.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsArtist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsArtist.Location = new System.Drawing.Point(0, 0);
            this.tsArtist.Name = "tsArtist";
            this.tsArtist.Size = new System.Drawing.Size(1297, 25);
            this.tsArtist.TabIndex = 3;
            this.tsArtist.Text = "toolStrip1";
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
            // ucArtist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvArtist_View);
            this.Controls.Add(this.tsArtist);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucArtist";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucArtist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArtist_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArtist_View)).EndInit();
            this.tsArtist.ResumeLayout(false);
            this.tsArtist.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArtist_View;
        private System.Windows.Forms.ToolStrip tsArtist;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.BindingSource bsArtist_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn artIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn странаDataGridViewTextBoxColumn;
    }
}
