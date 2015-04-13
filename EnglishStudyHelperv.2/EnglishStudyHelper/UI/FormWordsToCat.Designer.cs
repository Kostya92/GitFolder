namespace EnglishStudyHelper
{
    partial class FormWordsToCat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gridWords = new System.Windows.Forms.DataGridView();
            this.IndexGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceWords = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridWords);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 308);
            this.panel1.TabIndex = 2;
            // 
            // gridWords
            // 
            this.gridWords.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.gridWords.AutoGenerateColumns = false;
            this.gridWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexGrid,
            this.wordNameDataGridViewTextBoxColumn,
            this.translateDataGridViewTextBoxColumn});
            this.gridWords.DataSource = this.bindingSourceWords;
            this.gridWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWords.Location = new System.Drawing.Point(0, 0);
            this.gridWords.Name = "gridWords";
            this.gridWords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridWords.Size = new System.Drawing.Size(343, 308);
            this.gridWords.TabIndex = 3;
            // 
            // IndexGrid
            // 
            this.IndexGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IndexGrid.HeaderText = "№";
            this.IndexGrid.Name = "IndexGrid";
            this.IndexGrid.ReadOnly = true;
            this.IndexGrid.Width = 43;
            // 
            // wordNameDataGridViewTextBoxColumn
            // 
            this.wordNameDataGridViewTextBoxColumn.DataPropertyName = "WordName";
            this.wordNameDataGridViewTextBoxColumn.HeaderText = "WordName";
            this.wordNameDataGridViewTextBoxColumn.Name = "wordNameDataGridViewTextBoxColumn";
            // 
            // translateDataGridViewTextBoxColumn
            // 
            this.translateDataGridViewTextBoxColumn.DataPropertyName = "Translate";
            this.translateDataGridViewTextBoxColumn.HeaderText = "Translate";
            this.translateDataGridViewTextBoxColumn.Name = "translateDataGridViewTextBoxColumn";
            // 
            // bindingSourceWords
            // 
            this.bindingSourceWords.DataSource = typeof(EnglishStudyHelper.Entities.Word);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 32);
            this.panel2.TabIndex = 3;
            // 
            // FormWordsToCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 308);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWordsToCat";
            this.Text = "Слова в категории";
            this.Load += new System.EventHandler(this.FormWordsToCat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridWords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource bindingSourceWords;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateDataGridViewTextBoxColumn;

    }
}