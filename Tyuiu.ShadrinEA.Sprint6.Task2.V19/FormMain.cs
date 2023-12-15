using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task2.V19.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task2.V19
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            try
            { 
                int start = Convert.ToInt32(textBoxStart_SEA.Text);
                int stop = Convert.ToInt32(textBoxStop_SEA.Text);
                int len = ds.GetMassFunction(start, stop).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(start, stop);
                this.chartRes_SEA.Titles.Add("График функции");
                this.chartRes_SEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes_SEA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_SEA.Rows.Add(Convert.ToString(start), Convert.ToString(valueArray[i]));
                    this.chartRes_SEA.Series[0].Points.AddXY(start, valueArray[i]);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonDone_SEA_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_SEA.BackColor = Color.IndianRed;
        }

        private void buttonDone_SEA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_SEA.BackColor = Color.AliceBlue;
        }

        private void buttonDone_SEA_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_SEA.BackColor = Color.SeaGreen;
        }


        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task2 выполнил студент группы ИСТНб-23-1 Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStart_SEA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
