using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task3.V27.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task3.V27
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mx = { { 9, 13, -14, 23, 1},
                      { 15, -17, 21, 25, 23},
                      { -4, 29, -20, -10, 14},
                      { 27, 33, 12, 33, -12},
                      { 18, -9, -5, 6, 3} };

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = mx.GetUpperBound(0) + 1;
            int col = mx.Length / rows;

            dataGridViewMatrix_SEA.ColumnCount = col;
            dataGridViewMatrix_SEA.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix_SEA.Columns[i].Width = 25;

            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_SEA.Rows[i].Cells[j].Value = Convert.ToString(mx[i, j]);
                }
            }
        }

       

        private void labelResult_GAM_Click(object sender, EventArgs e)
        {

        }

       

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            textBoxRes_SEA.Text = "Выполнено!";
            int rows = mx.GetUpperBound(0) + 1;
            int col = mx.Length / rows;

            dataGridViewMatrix_SEA.ColumnCount = col;
            dataGridViewMatrix_SEA.RowCount = rows;

            for (int i = 0; i < col; i++)
            {
                dataGridViewMatrix_SEA.Columns[i].Width = 25;

            }
            int[,] result = ds.Calculate(mx);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    dataGridViewMatrix_SEA.Rows[i].Cells[j].Value = Convert.ToString(result[i, j]);
                }
            }
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-23-1, Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxRes_SEA_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMatrix_SEA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
