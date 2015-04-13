using System;
using System.Windows.Forms;
using EnglishStudyHelper.Services;
using EnglishStudyHelper.Entities;

//using System.Data.SQLite;

namespace EnglishStudyHelper
{
    public partial class FormWords : Form
    {
        FormEditWords frmEdit;
        

        public FormWords()
        {

            InitializeComponent();
           
        }

  
        public int GetIdCategory()
        {
            return this.cmbCategories.SelectedIndex + 1;
        }

    
  
        public void SetBindingWords(int categoryId)
        {
            bindingSourceWords.ResetBindings(true);

            if (categoryId == 0)
                bindingSourceWords.DataSource = ApplicationDataService.Instance.Words;
            else
                bindingSourceWords.DataSource = ApplicationDataService.Instance.GetWordsByCategory(categoryId);
       }

        public void SetBindingCategories()
        {
            bindingSourceCategories.ResetBindings(true);
            bindingSourceCategories.DataSource = ApplicationDataService.Instance.Categories;
        }
   
        private void bntNew_Click(object sender, EventArgs e)
        {
            using (frmEdit = new FormEditWords(this))
            {
                if (checkFilterOff.Checked)
                    frmEdit.Text = "Добавление слова без категории"; 
                else
                    frmEdit.Text = "Добавление слова в категорию " + cmbCategories.SelectedValue; 
               
                frmEdit.ShowDialog();
                selectWords(!checkFilterOff.Checked);
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormWords_Load(object sender, EventArgs e)
        {
            checkFilterOff.Checked = true;
            SetBindingCategories();
            cmbCategories.SelectedIndex = -1;
          
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategories_DropDownClosed(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedIndex != -1)
            {
                selectWords(true);
                checkFilterOff.Checked = false;
            }
      
        }

        private void selectWords(bool isFilter)
        {

            if (isFilter)
            {
                
                SetBindingWords(cmbCategories.SelectedIndex + 1);

            }
            else
            {
                SetBindingWords(0);
            }
        }

        private void checkFilterOff_CheckStateChanged(object sender, EventArgs e)
        {

        }

        private void checkFilterOff_CheckedChanged(object sender, EventArgs e)
        {
            selectWords(!checkFilterOff.Checked);

            if (checkFilterOff.Checked)
                cmbCategories.SelectedIndex = -1;
        

        }

        private void gridWords_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridWords.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Word wordToDelete = new Word();

            wordToDelete = (Word)gridWords.CurrentRow.DataBoundItem;

            ApplicationDataService.Instance.DeleteWord(wordToDelete);
            selectWords(!checkFilterOff.Checked);
        }
    }
}
