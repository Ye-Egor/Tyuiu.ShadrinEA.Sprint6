using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShadrinEA.Sprint6.Task7.V6.Lib;
using System.IO;

namespace Tyuiu.ShadrinEA.Sprint6.Task7.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPut_SEA.ColumnCount = 50;
            dataGridViewOutPut_SEA.ColumnCount = 50;

            dataGridViewInPut_SEA.RowCount = 50;
            dataGridViewOutPut_SEA.RowCount = 50;
        }

        private void buttonOpenFile_SEA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_SEA.ShowDialog();
            openFilePath = openFileDialogTask_SEA.FileName;

            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);
            
            dataGridViewInPut_SEA.ColumnCount = columns;
            dataGridViewInPut_SEA.RowCount = rows;
            dataGridViewOutPut_SEA.RowCount = rows;
            dataGridViewOutPut_SEA.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPut_SEA.Columns[i].Width = 25;
                dataGridViewOutPut_SEA.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_SEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            arrayValues = ds.GetMatrix(openFilePath);
            buttonDone_SEA.Enabled = true;
        }

        private void buttonDone_SEA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_SEA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSave_SEA.Enabled = true;
        }

        private void buttonHelp_SEA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonSave_SEA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_SEA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_SEA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_SEA.ShowDialog();

            string path = saveFileDialogMatrix_SEA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_SEA.RowCount;
            int columns = dataGridViewOutPut_SEA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_SEA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_SEA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }
    }
}
