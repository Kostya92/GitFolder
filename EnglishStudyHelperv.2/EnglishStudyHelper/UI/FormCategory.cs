using System;
using System.Data;
using System.Windows.Forms;
using EnglishStudyHelper.Services;
using EnglishStudyHelper.Entities;

namespace EnglishStudyHelper
{
    public partial class FormCategory : Form
    {
        EditCategory frmEditCat;
        FormWordsToCat frmWords;
        int idCat; //ид выбранной категории для передачи в дочернюю форму

        public FormCategory()
        {
            InitializeComponent();
  
        }

        private void SetIdCat(int idCat)
        {
            this.idCat = idCat;
        }

        public int GetIdCat()
        {
            return idCat;
        }

     
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCategory_Load(object sender, EventArgs e)
        {
            SetBinding();
        }

        private void SetBinding()
        {
            bindingSourceCategories.ResetBindings(true);
            bindingSourceCategories.DataSource = ApplicationDataService.Instance.Categories;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmEditCat = new EditCategory(this))
            {
                frmEditCat.ShowDialog();
                SetBinding();
            }
          
        }

        
        private void gridCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdCat(ApplicationDataService.Instance.Categories[e.RowIndex].CategoryId);

            using (frmWords = new FormWordsToCat(this))
            {
               frmWords.Text = "Список слов в категории " + ApplicationDataService.Instance.Categories[e.RowIndex].CategoryName;
               frmWords.ShowDialog();
            }
           
        }

     

        private void gridCategory_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            this.gridCategory.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
             Category categoryToDelete = new Category();

             categoryToDelete = (Category)gridCategory.CurrentRow.DataBoundItem;

             ApplicationDataService.Instance.DeleteCategory(categoryToDelete);

             SetBinding();

        }
         

     
    }
}
