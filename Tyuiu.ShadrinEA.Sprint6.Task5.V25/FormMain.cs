using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task5.V25
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        
        DataService ds = new DataService();
        string path = @"C:\Users\meteo\source\repos\Tyuiu.ShadrinEA.Sprint6\Tyuiu.ShadrinEA.Sprint6.Task5.V25\bin\Debug\InPutFileTask5V25.txt";

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_SEA.ColumnCount = 2;
            dataGridViewNums_SEA.Columns[0].Width = 20;
            dataGridViewNums_SEA.Columns[1].Width = 50;
            this.chartDiag_SEA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_SEA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_SEA.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_SEA.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_SEA.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void buttonOpen_SEA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНБ-23-1, Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
