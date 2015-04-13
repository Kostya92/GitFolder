using System;
using System.Windows.Forms;
using EnglishStudyHelper.Services;

namespace EnglishStudyHelper
{
    public partial class FormSetting : Form
    {
        FormMain frmMain;

        public FormSetting()
        {
            InitializeComponent();
          
        }

        public FormSetting(FormMain frmMain)
        {
            InitializeComponent();
            this.frmMain = frmMain;
        }


        private void FormSetting_Load(object sender, EventArgs e)
        {

            var categories = ApplicationDataService.Instance.Categories;
            
            lstCategories.Items.Clear();
            
          
            
            foreach (var category in categories)
            {
                lstCategories.Items.Add(category.CategoryName, category.IsSelected);
               
            }

    

            int timeInMinutes = frmMain.timeShowTest/60000;
            timerSetting.Text = timeInMinutes.ToString();
        }

        //сохранить настройки и закрыть форму
        private void button1_Click(object sender, EventArgs e)
        {
           
            int count = lstCategories.CheckedItems.Count;
            var categories = ApplicationDataService.Instance.Categories;
       
          foreach (var category in categories)
          {
              category.IsSelected = lstCategories.CheckedItems.Contains(category.CategoryName);
               ApplicationDataService.Instance.UpdateCategoryFlag(category);
              
          }
        

            if (timerSetting.Text != "")
                frmMain.timeShowTest = Convert.ToInt32(timerSetting.Text) * 60000; 

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
