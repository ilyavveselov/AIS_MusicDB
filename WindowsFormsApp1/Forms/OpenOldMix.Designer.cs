
namespace WindowsFormsApp1.Forms
{
    partial class OpenOldMix
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvOld_View = new System.Windows.Forms.DataGridView();
            this.mMIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.песняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.исполнительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.альбомDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.жанрDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsOldMix = new System.Windows.Forms.BindingSource(this.components);
            this.bOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOld_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOldMix)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOld_View
            // 
            this.dgvOld_View.AllowUserToAddRows = false;
            this.dgvOld_View.AllowUserToDeleteRows = false;
            this.dgvOld_View.AutoGenerateColumns = false;
            this.dgvOld_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvOld_View.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOld_View.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOld_View.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mMIdDataGridViewTextBoxColumn,
            this.песняDataGridViewTextBoxColumn,
            this.исполнительDataGridViewTextBoxColumn,
            this.альбомDataGridViewTextBoxColumn,
            this.жанрDataGridViewTextBoxColumn});
            this.dgvOld_View.DataSource = this.bsOldMix;
            this.dgvOld_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOld_View.Location = new System.Drawing.Point(0, 0);
            this.dgvOld_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvOld_View.Name = "dgvOld_View";
            this.dgvOld_View.Size = new System.Drawing.Size(1067, 692);
            this.dgvOld_View.TabIndex = 0;
            // 
            // mMIdDataGridViewTextBoxColumn
            // 
            this.mMIdDataGridViewTextBoxColumn.DataPropertyName = "mMId";
            this.mMIdDataGridViewTextBoxColumn.HeaderText = "mMId";
            this.mMIdDataGridViewTextBoxColumn.Name = "mMIdDataGridViewTextBoxColumn";
            this.mMIdDataGridViewTextBoxColumn.Visible = false;
            this.mMIdDataGridViewTextBoxColumn.Width = 58;
            // 
            // песняDataGridViewTextBoxColumn
            // 
            this.песняDataGridViewTextBoxColumn.DataPropertyName = "Песня";
            this.песняDataGridViewTextBoxColumn.HeaderText = "Песня";
            this.песняDataGridViewTextBoxColumn.Name = "песняDataGridViewTextBoxColumn";
            this.песняDataGridViewTextBoxColumn.Width = 77;
            // 
            // исполнительDataGridViewTextBoxColumn
            // 
            this.исполнительDataGridViewTextBoxColumn.DataPropertyName = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.HeaderText = "Исполнитель";
            this.исполнительDataGridViewTextBoxColumn.Name = "исполнительDataGridViewTextBoxColumn";
            this.исполнительDataGridViewTextBoxColumn.Width = 126;
            // 
            // альбомDataGridViewTextBoxColumn
            // 
            this.альбомDataGridViewTextBoxColumn.DataPropertyName = "Альбом";
            this.альбомDataGridViewTextBoxColumn.HeaderText = "Альбом";
            this.альбомDataGridViewTextBoxColumn.Name = "альбомDataGridViewTextBoxColumn";
            this.альбомDataGridViewTextBoxColumn.Width = 89;
            // 
            // жанрDataGridViewTextBoxColumn
            // 
            this.жанрDataGridViewTextBoxColumn.DataPropertyName = "Жанр";
            this.жанрDataGridViewTextBoxColumn.HeaderText = "Жанр";
            this.жанрDataGridViewTextBoxColumn.Name = "жанрDataGridViewTextBoxColumn";
            this.жанрDataGridViewTextBoxColumn.Width = 73;
            // 
            // bsOldMix
            // 
            this.bsOldMix.DataSource = typeof(WindowsFormsApp1.Model.MusicMix_View);
            // 
            // bOpen
            // 
            this.bOpen.Location = new System.Drawing.Point(904, 0);
            this.bOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(163, 35);
            this.bOpen.TabIndex = 1;
            this.bOpen.Text = "Отобразить список";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.bOpen_Click);
            // 
            // OpenOldMix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 692);
            this.Controls.Add(this.bOpen);
            this.Controls.Add(this.dgvOld_View);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OpenOldMix";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Открыть старый микс";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OpenOldMix_FormClosed);
            this.Load += new System.EventHandler(this.OpenOldMix_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOld_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsOldMix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOld_View;
        private System.Windows.Forms.BindingSource bsOldMix;
        private System.Windows.Forms.Button bOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn mMIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn песняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn исполнительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn альбомDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn жанрDataGridViewTextBoxColumn;
    }
}