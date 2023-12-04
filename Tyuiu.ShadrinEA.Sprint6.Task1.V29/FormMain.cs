using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task1.V29.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task1.V29
{
    public partial class FormMain_SEA : Form
    {
        public FormMain_SEA()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_GAM_Click(object sender, EventArgs e)
        {
            try
            {
                int startValue = Convert.ToInt32(textBoxStartValue_SEA.Text);
                int stopValue = Convert.ToInt32(textBoxStopValue_SEA.Text);
                int len = ds.GetMassFunction(startValue, stopValue).Length;
                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startValue, stopValue);
                textBoxResult_SEA.Text = "";
                textBoxResult_SEA.AppendText("+------------+------------+" + Environment.NewLine);
                textBoxResult_SEA.AppendText("|     X      +    f(x)    |" + Environment.NewLine);
                textBoxResult_SEA.AppendText("+------------+------------+" + Environment.NewLine);

                string str;
                for (int i = 0; i <= len - 1; i++)
                {
                    str = String.Format("|{0,7:d}     |  {1,7:f2}   |", startValue, valueArray[i]);
                    textBoxResult_SEA.AppendText(str + Environment.NewLine);
                    startValue++;
                }
                textBoxResult_SEA.AppendText("+------------+------------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_GAM_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИИПБ-23-3, Григорян Арсен Мовсесович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxInPut_GAM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxResult_GAM_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxCondition_GAM_Enter(object sender, EventArgs e)
        {

        }

        private void buttonHelp_GAM_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Task1 выполнил студент группы ИСТНб-23-1 Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK);
        }
    }
}
