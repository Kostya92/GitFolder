namespace EnglishStudyHelper
{
    partial class FormCategory
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelCatExp = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gridCategory = new System.Windows.Forms.DataGridView();
            this.IndexGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordsInCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceCategories = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRemove);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 81);
            this.panel1.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(297, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 46);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Закрыть окно";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Добавить категорию";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelCatExp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 38);
            this.panel3.TabIndex = 3;
            // 
            // labelCatExp
            // 
            this.labelCatExp.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCatExp.Location = new System.Drawing.Point(0, 0);
            this.labelCatExp.Name = "labelCatExp";
            this.labelCatExp.Size = new System.Drawing.Size(326, 38);
            this.labelCatExp.TabIndex = 5;
            this.labelCatExp.Text = "Кликните два раза на категорию,что бы просмотпеть слова в категории";
            this.labelCatExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(114, 16);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(96, 46);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить категорию";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // gridCategory
            // 
            this.gridCategory.AutoGenerateColumns = false;
            this.gridCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IndexGrid,
            this.categoryNameDataGridViewTextBoxColumn,
            this.wordsInCategoryDataGridViewTextBoxColumn});
            this.gridCategory.DataSource = this.bindingSourceCategories;
            this.gridCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategory.Location = new System.Drawing.Point(0, 38);
            this.gridCategory.Name = "gridCategory";
            this.gridCategory.ReadOnly = true;
            this.gridCategory.Size = new System.Drawing.Size(410, 286);
            this.gridCategory.TabIndex = 4;
            this.gridCategory.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCategory_CellDoubleClick);
            this.gridCategory.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridCategory_RowPostPaint);
            // 
            // IndexGrid
            // 
            this.IndexGrid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.IndexGrid.HeaderText = "№";
            this.IndexGrid.Name = "IndexGrid";
            this.IndexGrid.ReadOnly = true;
            this.IndexGrid.Width = 43;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Название категории";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // wordsInCategoryDataGridViewTextBoxColumn
            // 
            this.wordsInCategoryDataGridViewTextBoxColumn.DataPropertyName = "WordsInCategory";
            this.wordsInCategoryDataGridViewTextBoxColumn.HeaderText = "Слов в категории";
            this.wordsInCategoryDataGridViewTextBoxColumn.Name = "wordsInCategoryDataGridViewTextBoxColumn";
            this.wordsInCategoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceCategories
            // 
            this.bindingSourceCategories.DataSource = typeof(EnglishStudyHelper.Entities.Category);
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 405);
            this.Controls.Add(this.gridCategory);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCategory";
            this.Text = "Окно категорий";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.BindingSource bindingSourceCategories;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCatExp;
        private System.Windows.Forms.DataGridView gridCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordsInCategoryDataGridViewTextBoxColumn;
    }
}