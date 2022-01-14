
namespace WindowsFormsApp1.UserControls
{
    partial class ucMusicMix
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
            this.dgvMusicMix = new System.Windows.Forms.DataGridView();
            this.песняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.альбомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsView = new System.Windows.Forms.BindingSource(this.components);
            this.bsGenres = new System.Windows.Forms.BindingSource(this.components);
            this.bsArtists = new System.Windows.Forms.BindingSource(this.components);
            this.pComboBox = new System.Windows.Forms.Panel();
            this.cbArtists = new System.Windows.Forms.ComboBox();
            this.cbGenres = new System.Windows.Forms.ComboBox();
            this.cbGorA = new System.Windows.Forms.ComboBox();
            this.pLabelPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lCreate = new System.Windows.Forms.Label();
            this.lSave = new System.Windows.Forms.Label();
            this.lOld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicMix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArtists)).BeginInit();
            this.pComboBox.SuspendLayout();
            this.pLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMusicMix
            // 
            this.dgvMusicMix.AllowUserToAddRows = false;
            this.dgvMusicMix.AllowUserToDeleteRows = false;
            this.dgvMusicMix.AutoGenerateColumns = false;
            this.dgvMusicMix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMusicMix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMusicMix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusicMix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.песняDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn,
            this.альбомDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn});
            this.dgvMusicMix.DataSource = this.bsView;
            this.dgvMusicMix.Location = new System.Drawing.Point(0, 42);
            this.dgvMusicMix.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvMusicMix.Name = "dgvMusicMix";
            this.dgvMusicMix.ReadOnly = true;
            this.dgvMusicMix.Size = new System.Drawing.Size(1297, 708);
            this.dgvMusicMix.TabIndex = 1;
            // 
            // песняDataGridViewTextBoxColumn
            // 
            this.песняDataGridViewTextBoxColumn.DataPropertyName = "Песня";
            this.песняDataGridViewTextBoxColumn.HeaderText = "Песня";
            this.песняDataGridViewTextBoxColumn.Name = "песняDataGridViewTextBoxColumn";
            this.песняDataGridViewTextBoxColumn.ReadOnly = true;
            this.песняDataGridViewTextBoxColumn.Width = 77;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.ReadOnly = true;
            this.исполнительDataGridViewTextBoxColumn.Width = 126;
            // 
            // альбомDataGridViewTextBoxColumn
            // 
            this.альбомDataGridViewTextBoxColumn.DataPropertyName = "Альбом";
            this.альбомDataGridViewTextBoxColumn.HeaderText = "Альбом";
            this.альбомDataGridViewTextBoxColumn.Name = "альбомDataGridViewTextBoxColumn";
            this.альбомDataGridViewTextBoxColumn.ReadOnly = true;
            this.альбомDataGridViewTextBoxColumn.Width = 89;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.ReadOnly = true;
            this.жанрDataGridViewTextBoxColumn.Width = 73;
            // 
            // bsView
            // 
            this.bsView.DataSource = typeof(WindowsFormsApp1.Model.MusicMix_View);
            // 
            // bsGenres
            // 
            this.bsGenres.DataSource = typeof(WindowsFormsApp1.Model.Genre_View);
            // 
            // bsArtists
            // 
            this.bsArtists.DataSource = typeof(WindowsFormsApp1.Model.Artist_View);
            // 
            // pComboBox
            // 
            this.pComboBox.Controls.Add(this.cbArtists);
            this.pComboBox.Controls.Add(this.cbGenres);
            this.pComboBox.Controls.Add(this.cbGorA);
            this.pComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pComboBox.Location = new System.Drawing.Point(0, 0);
            this.pComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pComboBox.Name = "pComboBox";
            this.pComboBox.Size = new System.Drawing.Size(565, 749);
            this.pComboBox.TabIndex = 2;
            // 
            // cbArtists
            // 
            this.cbArtists.DataSource = this.bsArtists;
            this.cbArtists.DisplayMember = "Исполнитель";
            this.cbArtists.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbArtists.FormattingEnabled = true;
            this.cbArtists.Location = new System.Drawing.Point(360, 0);
            this.cbArtists.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbArtists.Name = "cbArtists";
            this.cbArtists.Size = new System.Drawing.Size(180, 28);
            this.cbArtists.TabIndex = 2;
            this.cbArtists.Visible = false;
            // 
            // cbGenres
            // 
            this.cbGenres.DataSource = this.bsGenres;
            this.cbGenres.DisplayMember = "Название_жанра";
            this.cbGenres.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbGenres.FormattingEnabled = true;
            this.cbGenres.Location = new System.Drawing.Point(180, 0);
            this.cbGenres.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGenres.Name = "cbGenres";
            this.cbGenres.Size = new System.Drawing.Size(180, 28);
            this.cbGenres.TabIndex = 1;
            this.cbGenres.Visible = false;
            // 
            // cbGorA
            // 
            this.cbGorA.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbGorA.FormattingEnabled = true;
            this.cbGorA.Items.AddRange(new object[] {
            "По жанрам",
            "По исполнителям"});
            this.cbGorA.Location = new System.Drawing.Point(0, 0);
            this.cbGorA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbGorA.Name = "cbGorA";
            this.cbGorA.Size = new System.Drawing.Size(180, 28);
            this.cbGorA.TabIndex = 0;
            this.cbGorA.SelectedIndexChanged += new System.EventHandler(this.cbGorA_SelectedIndexChanged);
            // 
            // pLabelPanel
            // 
            this.pLabelPanel.Controls.Add(this.lCreate);
            this.pLabelPanel.Controls.Add(this.lSave);
            this.pLabelPanel.Controls.Add(this.lOld);
            this.pLabelPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLabelPanel.Location = new System.Drawing.Point(565, 0);
            this.pLabelPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pLabelPanel.Name = "pLabelPanel";
            this.pLabelPanel.Size = new System.Drawing.Size(407, 749);
            this.pLabelPanel.TabIndex = 3;
            // 
            // lCreate
            // 
            this.lCreate.AutoSize = true;
            this.lCreate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lCreate.Location = new System.Drawing.Point(4, 0);
            this.lCreate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCreate.Name = "lCreate";
            this.lCreate.Size = new System.Drawing.Size(116, 20);
            this.lCreate.TabIndex = 0;
            this.lCreate.Text = "Создать список";
            this.lCreate.Click += new System.EventHandler(this.lCreate_Click);
            // 
            // lSave
            // 
            this.lSave.AutoSize = true;
            this.lSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.lSave.Location = new System.Drawing.Point(128, 0);
            this.lSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lSave.Name = "lSave";
            this.lSave.Size = new System.Drawing.Size(135, 20);
            this.lSave.TabIndex = 1;
            this.lSave.Text = "Сохранить список";
            this.lSave.Click += new System.EventHandler(this.lSave_Click);
            // 
            // lOld
            // 
            this.lOld.AutoSize = true;
            this.lOld.Dock = System.Windows.Forms.DockStyle.Left;
            this.lOld.Location = new System.Drawing.Point(271, 0);
            this.lOld.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lOld.Name = "lOld";
            this.lOld.Size = new System.Drawing.Size(112, 20);
            this.lOld.TabIndex = 2;
            this.lOld.Text = "Старые списки";
            this.lOld.Click += new System.EventHandler(this.lOld_Click);
            // 
            // ucMusicMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvMusicMix);
            this.Controls.Add(this.pLabelPanel);
            this.Controls.Add(this.pComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucMusicMix";
            this.Size = new System.Drawing.Size(975, 749);
            this.Load += new System.EventHandler(this.ucMusicMix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusicMix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsArtists)).EndInit();
            this.pComboBox.ResumeLayout(false);
            this.pLabelPanel.ResumeLayout(false);
            this.pLabelPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMusicMix;
        private System.Windows.Forms.BindingSource bsGenres;
        private System.Windows.Forms.BindingSource bsArtists;
        private System.Windows.Forms.Panel pComboBox;
        private System.Windows.Forms.ComboBox cbArtists;
        private System.Windows.Forms.ComboBox cbGenres;
        private System.Windows.Forms.ComboBox cbGorA;
        private System.Windows.Forms.FlowLayoutPanel pLabelPanel;
        private System.Windows.Forms.Label lCreate;
        private System.Windows.Forms.Label lSave;
        private System.Windows.Forms.Label lOld;
        private System.Windows.Forms.BindingSource bsView;
        private System.Windows.Forms.DataGridViewTextBoxColumn песняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn альбомDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
    }
}
