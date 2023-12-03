using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task0.V21.Lib;

namespace Tyuiu.ShadrinEA.Sprint6.Task0.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

       

       

        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService(); 
            try
            {
                textBoxRes.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarA_TextChanged(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonWhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Task0 выполнил студент группы ИСТНб-23-1 Шадрин Егор Андреевич", "Сообщение", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
