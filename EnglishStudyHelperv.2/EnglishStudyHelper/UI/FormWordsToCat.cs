using System;
using System.Windows.Forms;
using EnglishStudyHelper.Services;

namespace EnglishStudyHelper
{
    public partial class FormWordsToCat : Form
    {
        FormCategory frmCategor;

        public FormWordsToCat()
        {
            InitializeComponent();
        }

        public FormWordsToCat(FormCategory frm)
        {
            InitializeComponent();
            this.frmCategor = frm;
        }


        private void FormWordsToCat_Load(object sender, EventArgs e)
        {

            SetBinding();
         
        }

     
        private void SetBinding()
        {

            int idCategory = frmCategor.GetIdCat();
            bindingSourceWords.ResetBindings(true);
            bindingSourceWords.DataSource = ApplicationDataService.Instance.GetWordsByCategory(idCategory);
        }
     
    }
}
