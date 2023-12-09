using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task4.V21.Lib;
using System.IO;

namespace Tyuiu.ShadrinEA.Sprint6.Task4.V21
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

                this.chartRes_SEA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartRes_SEA.ChartAreas[0].AxisY.Title = "Ось Y";
                textBoxRes_SEA.Text = "";
                chartRes_SEA.Series[0].Points.Clear();
                for (int i = 0; i < len; i++)
                {
                    this.chartRes_SEA.Series[0].Points.AddXY(start, valueArray[i]);
                    textBoxRes_SEA.AppendText(valueArray[i] + Environment.NewLine);
                    start++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_SEA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFile.Task4.txt";
                File.WriteAllText(path, textBoxRes_SEA.Text);
                DialogResult dialogResult = MessageBox.Show("Файл" + path + "сохранен успешно!\nОткрыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }

            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИСТНБ-23-1, Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chartRes_SEA_Click(object sender, EventArgs e)
        {

        }

        private void textBoxS_SEA_Click(object sender, EventArgs e)
        {

        }
    }
}
