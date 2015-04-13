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
    public partial class FormMain : Form
    {
        public FormWords formWords;
        public FormCategory formCat;
        public FormSetting formSet;
        public int timeShowTest = 60000;
        private int _trueAnswerPos;
        private RadioButton[] _arrRadioBtn = new RadioButton[5];
        private InactiveTimeCalculator _inactiveTimeCalc;
        private const int TIME_FOR_SLEEP = 10; //  константа задающая время простоя в минутах
        
      

        


        public FormMain()
        {
            InitializeComponent();
            _inactiveTimeCalc = new InactiveTimeCalculator();

        } 
      
           
        private void FormMain_Load(object sender, EventArgs e)
        {
            HideMainWindow();
          

                _arrRadioBtn[0] = rbtnAnswer1;
                _arrRadioBtn[1] = rbtnAnswer2;
                _arrRadioBtn[2] = rbtnAnswer3;
                _arrRadioBtn[3] = rbtnAnswer4;
                _arrRadioBtn[4] = rbtnAnswer5;
            

            timerShowTest.Interval = timeShowTest;
            timerShowTest.Start();
            timerInactivity.Start();
            ApplicationDataService.Instance.InitLists();
        }

    

        private void FormMain_Resize(object sender, EventArgs e)
        {

            HideMainWindow();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowMainWindow();
        }

     
        private void wordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerShowTest.Stop();
            using (formWords = new FormWords())
            {
                formWords.ShowDialog();
            }
            timerShowTest.Start();
        }

     
        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerShowTest.Stop();
            using (formCat = new FormCategory())
            {
                formCat.ShowDialog();
            }
            timerShowTest.Start();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HideMainWindow()
        {
            if (WindowState == FormWindowState.Minimized)
                Hide();
        }

        private void ShowMainWindow()
        {
            if (SetRandomWord())
            {
                Show();
                WindowState = FormWindowState.Normal;
            }
            else MessageBox.Show("Необходимо выбрать хотя бы одну категорию в пункте меню 'Настройки'");
            
        }

        private void TimerEventProcessor(Object myObject,
                                           EventArgs myEventArgs)
        {
            ShowMainWindow();
        }

        //заполняет елементы главной формы случайными словом и переводами к нему
        //возваращает false, если выборка пуста и заполнять нечем (в этом случае нам не надо выводить тест на экран, а предложить пользователю
        //зайти в настройка и выбрать категории для тестирования)
      

        private bool SetRandomWord()
        {

            var selectedWords = ApplicationDataService.Instance.GetWordsFromSelectedCategories();
            int countWords = selectedWords.Count;

            if (countWords != 0)
            {
                int[] arrayOfRandomIds = new int[5];
        
                var rnd = new Random((int)DateTime.Now.Ticks);
                int rnum = 0;
               
                //массив случайных чисел - используются в качестве индексов строк со словами-переводами 
                for (int i = 0; i < 5; i++)
                {
                    rnum = rnd.Next(0, countWords);

                    for (int j = 0; j < 5; j++)
                    {
                        if (arrayOfRandomIds[j] == rnum)
                            break;
                        else
                            arrayOfRandomIds[i] = rnum;
                    }
                }


                //случайная позиция радиокнопки для правильного ответа
                //чтобы он не был всегда первым
                rnd = new Random();
                SetTrueAnswerPos(rnd.Next(0, 4));


                lblCategory.Text = selectedWords.ElementAt(arrayOfRandomIds[0]).CategoryName;
                lblWord.Text = selectedWords.ElementAt(arrayOfRandomIds[0]).WordName;

                for (int i = 0; i < _arrRadioBtn.Length; i++)
                {
                    _arrRadioBtn[i].Text = selectedWords.ElementAt(arrayOfRandomIds[i]).Translate;
                    _arrRadioBtn[i].Checked = false;
                }

                RadioButton temp = _arrRadioBtn[_trueAnswerPos];
                _arrRadioBtn[_trueAnswerPos] = _arrRadioBtn[0];
                _arrRadioBtn[0] = temp;
    
                return true;
            }
            return false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowMainWindow();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 5; i++)
            {
                if (_arrRadioBtn[i].Checked)
                {
                    if (i == _trueAnswerPos)
                    {
                        MessageBox.Show("Правильно");
                    }
                                            
                }
            }

            WindowState = FormWindowState.Minimized;
 
        }

        private void SetTrueAnswerPos(int pos)
        {
            this._trueAnswerPos = pos;
        }

        private int GetTrueAnswerPos()
        {
            return this._trueAnswerPos;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timerShowTest.Stop();
            using (formSet = new FormSetting(this))
            {
                formSet.ShowDialog();
            }
            timerShowTest.Start();
            
        }

        private void btnNoAns_Click(object sender, EventArgs e)
        {

            WindowState = FormWindowState.Minimized;
        }
        
        private void timerInactivity_Tick(object sender, EventArgs e)
        {
            var inactiveTime = _inactiveTimeCalc.GetInactiveTime();

            if (inactiveTime != null)
            {
                if (inactiveTime.Value.TotalMinutes > TIME_FOR_SLEEP)
                {
                    timerShowTest.Stop();
                    timerShowTest.Enabled = false;
                }
                else if (!timerShowTest.Enabled)
                {
                    timerShowTest.Enabled = true;
                    timerShowTest.Start();
                }
            }
        }
    }
}
