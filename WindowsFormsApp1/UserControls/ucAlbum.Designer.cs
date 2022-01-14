
namespace WindowsFormsApp1.UserControls
{
    partial class ucAlbum
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
            this.dgvAlbum_View = new System.Windows.Forms.DataGridView();
            this.albIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.артистDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.альбомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавыходаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типальбомаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.лейблDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAlbum_View = new System.Windows.Forms.BindingSource(this.components);
            this.tsAlbumMain = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripLabel();
            this.tsChange = new System.Windows.Forms.ToolStripLabel();
            this.tsDelete = new System.Windows.Forms.ToolStripLabel();
            this.tsCmbBxAlbumFilter = new System.Windows.Forms.ToolStripComboBox();
            this.tsFilter = new System.Windows.Forms.ToolStripLabel();
            this.tsTBoxSearch = new System.Windows.Forms.ToolStripTextBox();
            this.tsSearch = new System.Windows.Forms.ToolStripLabel();
            this.tsReset = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum_View)).BeginInit();
            this.tsAlbumMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlbum_View
            // 
            this.dgvAlbum_View.AllowUserToAddRows = false;
            this.dgvAlbum_View.AllowUserToDeleteRows = false;
            this.dgvAlbum_View.AutoGenerateColumns = false;
            this.dgvAlbum_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlbum_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvAlbum_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlbum_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.albIdDataGridViewTextBoxColumn,
            this.артистDataGridViewTextBoxColumn,
            this.альбомDataGridViewTextBoxColumn,
            this.датавыходаDataGridViewTextBoxColumn,
            this.типальбомаDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn,
            this.лейблDataGridViewTextBoxColumn});
            this.dgvAlbum_View.DataSource = this.bsAlbum_View;
            this.dgvAlbum_View.Location = new System.Drawing.Point(0, 43);
            this.dgvAlbum_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlbum_View.MultiSelect = false;
            this.dgvAlbum_View.Name = "dgvAlbum_View";
            this.dgvAlbum_View.ReadOnly = true;
            this.dgvAlbum_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlbum_View.Size = new System.Drawing.Size(1297, 706);
            this.dgvAlbum_View.TabIndex = 0;
            // 
            // albIdDataGridViewTextBoxColumn
            // 
            this.albIdDataGridViewTextBoxColumn.DataPropertyName = "albId";
            this.albIdDataGridViewTextBoxColumn.HeaderText = "albId";
            this.albIdDataGridViewTextBoxColumn.Name = "albIdDataGridViewTextBoxColumn";
            this.albIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.albIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.albIdDataGridViewTextBoxColumn.Visible = false;
            this.albIdDataGridViewTextBoxColumn.Width = 36;
            // 
            // артистDataGridViewTextBoxColumn
            // 
            this.артистDataGridViewTextBoxColumn.DataPropertyName = "Артист";
            this.артистDataGridViewTextBoxColumn.HeaderText = "Артист";
            this.артистDataGridViewTextBoxColumn.Name = "артистDataGridViewTextBoxColumn";
            this.артистDataGridViewTextBoxColumn.ReadOnly = true;
            this.артистDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.артистDataGridViewTextBoxColumn.Width = 62;
            // 
            // альбомDataGridViewTextBoxColumn
            // 
            this.альбомDataGridViewTextBoxColumn.DataPropertyName = "Альбом";
            this.альбомDataGridViewTextBoxColumn.HeaderText = "Альбом";
            this.альбомDataGridViewTextBoxColumn.Name = "альбомDataGridViewTextBoxColumn";
            this.альбомDataGridViewTextBoxColumn.ReadOnly = true;
            this.альбомDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.альбомDataGridViewTextBoxColumn.Width = 70;
            // 
            // датавыходаDataGridViewTextBoxColumn
            // 
            this.датавыходаDataGridViewTextBoxColumn.DataPropertyName = "Дата_выхода";
            this.датавыходаDataGridViewTextBoxColumn.HeaderText = "Дата выхода";
            this.датавыходаDataGridViewTextBoxColumn.Name = "датавыходаDataGridViewTextBoxColumn";
            this.датавыходаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датавыходаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.датавыходаDataGridViewTextBoxColumn.Width = 102;
            // 
            // типальбомаDataGridViewTextBoxColumn
            // 
            this.типальбомаDataGridViewTextBoxColumn.DataPropertyName = "Тип_альбома";
            this.типальбомаDataGridViewTextBoxColumn.HeaderText = "Тип альбома";
            this.типальбомаDataGridViewTextBoxColumn.Name = "типальбомаDataGridViewTextBoxColumn";
            this.типальбомаDataGridViewTextBoxColumn.ReadOnly = true;
            this.типальбомаDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.типальбомаDataGridViewTextBoxColumn.Width = 106;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.жанрDataGridViewTextBoxColumn.Width = 54;
            // 
            // лейблDataGridViewTextBoxColumn
            // 
            this.лейблDataGridViewTextBoxColumn.DataPropertyName = "Лейбл";
            this.лейблDataGridViewTextBoxColumn.HeaderText = "Лейбл";
            this.лейблDataGridViewTextBoxColumn.Name = "лейблDataGridViewTextBoxColumn";
            this.лейблDataGridViewTextBoxColumn.ReadOnly = true;
            this.лейблDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.лейблDataGridViewTextBoxColumn.Width = 59;
            // 
            // bsAlbum_View
            // 
            this.bsAlbum_View.DataSource = typeof(WindowsFormsApp1.Model.Album_View);
            this.bsAlbum_View.CurrentChanged += new System.EventHandler(this.bsAlbum_View_CurrentChanged);
            // 
            // tsAlbumMain
            // 
            this.tsAlbumMain.Dock = System.Windows.Forms.DockStyle.None;
            this.tsAlbumMain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsAlbumMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsAlbumMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsChange,
            this.tsDelete,
            this.tsCmbBxAlbumFilter,
            this.tsFilter,
            this.tsTBoxSearch,
            this.tsSearch,
            this.tsReset});
            this.tsAlbumMain.Location = new System.Drawing.Point(0, 0);
            this.tsAlbumMain.Name = "tsAlbumMain";
            this.tsAlbumMain.Size = new System.Drawing.Size(942, 25);
            this.tsAlbumMain.TabIndex = 2;
            this.tsAlbumMain.Text = "toolStrip1";
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
            // tsCmbBxAlbumFilter
            // 
            this.tsCmbBxAlbumFilter.Items.AddRange(new object[] {
            "По возрастанию...",
            "По убыванию..."});
            this.tsCmbBxAlbumFilter.Name = "tsCmbBxAlbumFilter";
            this.tsCmbBxAlbumFilter.Size = new System.Drawing.Size(160, 25);
            // 
            // tsFilter
            // 
            this.tsFilter.Name = "tsFilter";
            this.tsFilter.Size = new System.Drawing.Size(99, 22);
            this.tsFilter.Text = "Фильтровать";
            this.tsFilter.Click += new System.EventHandler(this.tsFilter_Click);
            // 
            // tsTBoxSearch
            // 
            this.tsTBoxSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tsTBoxSearch.Name = "tsTBoxSearch";
            this.tsTBoxSearch.Size = new System.Drawing.Size(265, 25);
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
            this.tsReset.Size = new System.Drawing.Size(140, 22);
            this.tsReset.Text = "Сбросить фильтры";
            this.tsReset.Click += new System.EventHandler(this.tsReset_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAlbum_View);
            this.panel1.Controls.Add(this.tsAlbumMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1297, 749);
            this.panel1.TabIndex = 3;
            // 
            // ucAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucAlbum";
            this.Size = new System.Drawing.Size(1297, 749);
            this.Load += new System.EventHandler(this.ucAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlbum_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAlbum_View)).EndInit();
            this.tsAlbumMain.ResumeLayout(false);
            this.tsAlbumMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlbum_View;
        private System.Windows.Forms.BindingSource bsAlbum_View;
        private System.Windows.Forms.ToolStrip tsAlbumMain;
        private System.Windows.Forms.ToolStripLabel tsAdd;
        private System.Windows.Forms.ToolStripLabel tsChange;
        private System.Windows.Forms.ToolStripLabel tsDelete;
        private System.Windows.Forms.ToolStripComboBox tsCmbBxAlbumFilter;
        private System.Windows.Forms.ToolStripTextBox tsTBoxSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripLabel tsFilter;
        private System.Windows.Forms.ToolStripLabel tsSearch;
        private System.Windows.Forms.ToolStripLabel tsReset;
        private System.Windows.Forms.DataGridViewTextBoxColumn albIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn артистDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn альбомDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавыходаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типальбомаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn лейблDataGridViewTextBoxColumn;
    }
}
