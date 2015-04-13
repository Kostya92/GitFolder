namespace EnglishStudyHelper
{
    partial class FormWords
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkFilterOff = new System.Windows.Forms.CheckBox();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.bindingSourceCategories = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.bntNew = new System.Windows.Forms.Button();
            this.gridWords = new System.Windows.Forms.DataGridView();
            this.ColumnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wordNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceWords = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkFilterOff);
            this.panel1.Controls.Add(this.cmbCategories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 60);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Установить для отмены выбора";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выбрать категорию для добавления слов";
            // 
            // checkFilterOff
            // 
            this.checkFilterOff.AutoSize = true;
            this.checkFilterOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkFilterOff.Location = new System.Drawing.Point(264, 30);
            this.checkFilterOff.Name = "checkFilterOff";
            this.checkFilterOff.Size = new System.Drawing.Size(186, 21);
            this.checkFilterOff.TabIndex = 1;
            this.checkFilterOff.Text = "Показать все категории";
            this.checkFilterOff.UseVisualStyleBackColor = false;
            this.checkFilterOff.CheckedChanged += new System.EventHandler(this.checkFilterOff_CheckedChanged);
            this.checkFilterOff.CheckStateChanged += new System.EventHandler(this.checkFilterOff_CheckStateChanged);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DataSource = this.bindingSourceCategories;
            this.cmbCategories.DisplayMember = "CategoryName";
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(3, 30);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(199, 24);
            this.cmbCategories.TabIndex = 0;
            this.cmbCategories.ValueMember = "CategoryName";
            this.cmbCategories.DropDownClosed += new System.EventHandler(this.cmbCategories_DropDownClosed);
            // 
            // bindingSourceCategories
            // 
            this.bindingSourceCategories.DataSource = typeof(EnglishStudyHelper.Entities.Category);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.bntNew);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 328);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(113, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(89, 37);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Удалить слово";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(366, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 37);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Закрыть окно";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bntNew
            // 
            this.bntNew.Location = new System.Drawing.Point(12, 20);
            this.bntNew.Name = "bntNew";
            this.bntNew.Size = new System.Drawing.Size(89, 37);
            this.bntNew.TabIndex = 3;
            this.bntNew.Text = "Добавить слово";
            this.bntNew.UseVisualStyleBackColor = true;
            this.bntNew.Click += new System.EventHandler(this.bntNew_Click);
            // 
            // gridWords
            // 
            this.gridWords.AutoGenerateColumns = false;
            this.gridWords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridWords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridWords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnIndex,
            this.wordNameDataGridViewTextBoxColumn,
            this.translateDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn});
            this.gridWords.DataSource = this.bindingSourceWords;
            this.gridWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWords.Location = new System.Drawing.Point(0, 60);
            this.gridWords.Name = "gridWords";
            this.gridWords.ReadOnly = true;
            this.gridWords.Size = new System.Drawing.Size(453, 268);
            this.gridWords.TabIndex = 2;
            this.gridWords.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.gridWords_RowPostPaint);
            // 
            // ColumnIndex
            // 
            this.ColumnIndex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColumnIndex.FillWeight = 101.5228F;
            this.ColumnIndex.HeaderText = "№";
            this.ColumnIndex.Name = "ColumnIndex";
            this.ColumnIndex.ReadOnly = true;
            this.ColumnIndex.Width = 43;
            // 
            // wordNameDataGridViewTextBoxColumn
            // 
            this.wordNameDataGridViewTextBoxColumn.DataPropertyName = "WordName";
            this.wordNameDataGridViewTextBoxColumn.FillWeight = 99.49239F;
            this.wordNameDataGridViewTextBoxColumn.HeaderText = "Слово";
            this.wordNameDataGridViewTextBoxColumn.Name = "wordNameDataGridViewTextBoxColumn";
            this.wordNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // translateDataGridViewTextBoxColumn
            // 
            this.translateDataGridViewTextBoxColumn.DataPropertyName = "Translate";
            this.translateDataGridViewTextBoxColumn.FillWeight = 99.49239F;
            this.translateDataGridViewTextBoxColumn.HeaderText = "Перевод";
            this.translateDataGridViewTextBoxColumn.Name = "translateDataGridViewTextBoxColumn";
            this.translateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.FillWeight = 99.49239F;
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSourceWords
            // 
            this.bindingSourceWords.DataSource = typeof(EnglishStudyHelper.Entities.Word);
            // 
            // FormWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 398);
            this.Controls.Add(this.gridWords);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWords";
            this.Text = "Форма слов";
            this.Load += new System.EventHandler(this.FormWords_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCategories)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceWords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridWords;
        private System.Windows.Forms.Button bntNew;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkFilterOff;
        private System.Windows.Forms.BindingSource bindingSourceWords;
        private System.Windows.Forms.BindingSource bindingSourceCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn wordNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRemove;

    }
}