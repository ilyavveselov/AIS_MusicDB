
namespace WindowsFormsApp1.UserControls
{
    partial class ucSong
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
            this.dgvSong_View = new System.Windows.Forms.DataGridView();
            this.sngIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеальбомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиепесниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsSong_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsSong = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.cbOrderBy = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSong_View)).BeginInit();
            this.tsSong.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSong_View
            // 
            this.dgvSong_View.AllowUserToAddRows = false;
            this.dgvSong_View.AllowUserToDeleteRows = false;
            this.dgvSong_View.AutoGenerateColumns = false;
            this.dgvSong_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSong_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSong_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sngIdDataGridViewTextBoxColumn,
            this.названиеальбомаDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn,
            this.названиепесниDataGridViewTextBoxColumn});
            this.dgvSong_View.DataSource = this.bsSong_View;
            this.dgvSong_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSong_View.Location = new System.Drawing.Point(0, 25);
            this.dgvSong_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSong_View.Name = "dgvSong_View";
            this.dgvSong_View.ReadOnly = true;
            this.dgvSong_View.Size = new System.Drawing.Size(1297, 724);
            this.dgvSong_View.TabIndex = 2;
            // 
            // sngIdDataGridViewTextBoxColumn
            // 
            this.sngIdDataGridViewTextBoxColumn.DataPropertyName = "sngId";
            this.sngIdDataGridViewTextBoxColumn.HeaderText = "sngId";
            this.sngIdDataGridViewTextBoxColumn.Name = "sngIdDataGridViewTextBoxColumn";
            this.sngIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.sngIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sngIdDataGridViewTextBoxColumn.Visible = false;
            this.sngIdDataGridViewTextBoxColumn.Width = 39;
            // 
            // названиеальбомаDataGridViewTextBoxColumn
            // 
            this.названиеальбомаDataGridViewTextBoxColumn.DataPropertyName = "Название_альбома";
            this.названиеальбомаDataGridViewTextBoxColumn.HeaderText = "Название альбома";
            this.названиеальбомаDataGridViewTextBoxColumn.Name = "названиеальбомаDataGridViewTextBoxColumn";
            this.названиеальбомаDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиеальбомаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.названиеальбомаDataGridViewTextBoxColumn.Width = 133;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.ReadOnly = true;
            this.исполнительDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.исполнительDataGridViewTextBoxColumn.Width = 107;
            // 
            // названиепесниDataGridViewTextBoxColumn
            // 
            this.названиепесниDataGridViewTextBoxColumn.DataPropertyName = "Название_песни";
            this.названиепесниDataGridViewTextBoxColumn.HeaderText = "Название песни";
            this.названиепесниDataGridViewTextBoxColumn.Name = "названиепесниDataGridViewTextBoxColumn";
            this.названиепесниDataGridViewTextBoxColumn.ReadOnly = true;
            this.названиепесниDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.названиепесниDataGridViewTextBoxColumn.Width = 116;
            // 
            // bsSong_View
            // 
            this.bsSong_View.DataSource = typeof(WindowsFormsApp1.Model.Song_View);
            this.bsSong_View.CurrentChanged += new System.EventHandler(this.bsSong_View_CurrentChanged);
            // 
            // tsSong
            // 
            this.tsSong.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsSong.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsSong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.cbOrderBy,
            this.tsFilter,
            this.tbSearch,
            this.tsSearch,
            this.tsReset});
            this.tsSong.Location = new System.Drawing.Point(0, 0);
            this.tsSong.Name = "tsSong";
            this.tsSong.Size = new System.Drawing.Size(1297, 25);
            this.tsSong.TabIndex = 3;
            this.tsSong.Text = "toolStrip1";
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
            // ucSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvSong_View);
            this.Controls.Add(this.tsSong);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucSong";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSong_View)).EndInit();
            this.tsSong.ResumeLayout(false);
            this.tsSong.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSong_View;
        private System.Windows.Forms.ToolStrip tsSong;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox cbOrderBy;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripTextBox tbSearch;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.BindingSource bsSong_View;
        private System.Windows.Forms.DataGridViewTextBoxColumn sngIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеальбомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиепесниDataGridViewTextBoxColumn;
    }
}
