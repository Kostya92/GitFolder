using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishStudyHelper.Services;
using EnglishStudyHelper.Entities;

namespace EnglishStudyHelper
{
    public partial class FormEditWords : Form
    {
        FormWords frmWords;
        ErrorProvider errorTextBoxProvider;
       
        public FormEditWords()
        {
            InitializeComponent();
            errorTextBoxProvider = new ErrorProvider();
        }

        public FormEditWords(FormWords frm)
        {
            InitializeComponent();
            this.frmWords = frm;
            errorTextBoxProvider = new ErrorProvider();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddWord_Click(object sender, EventArgs e)
        {
       
         
            if (textWord.Text != "" && textTranslate.Text != "")
            {
                int idCategory = frmWords.GetIdCategory();

                var newWord = new Word(textWord.Text, textTranslate.Text, idCategory);
                ApplicationDataService.Instance.InsertWord(newWord);
           
                
            }

            
        }

        private void textWord_Validating(object sender, CancelEventArgs e)
        {
            textBox_Validating(sender, e, Validator.Alphabets.En);
        }

      

        private void textWord_Validated(object sender, EventArgs e)
        {
            textBox_Validated(sender, e);
        }

        private void textTranslate_Validating(object sender, CancelEventArgs e)
        {
            textBox_Validating(sender, e, Validator.Alphabets.Ru);
            
        }

        private void textTranslate_Validated(object sender, EventArgs e)
        {
            textBox_Validated(sender, e);
        }

        //проверка ввода в текстовое поле
        private void textBox_Validating(object sender, CancelEventArgs e, Validator.Alphabets alphabet)
        {
            string errorMessage;
            if (!Validator.ValidText(((TextBox)sender).Text, alphabet, out errorMessage))
            {
                e.Cancel = true;
                ((TextBox)sender).Select(0, ((TextBox)sender).Text.Length);
                errorTextBoxProvider.SetError((TextBox)sender, errorMessage);
                
            }
        }

        //проверка прошла успешно
        private void textBox_Validated(object sender, EventArgs e)
        {
            errorTextBoxProvider.SetError((TextBox)sender, String.Empty);
        }




    }
}
