
namespace Tyuiu.ShadrinEA.Sprint6.Task2.V19
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxRes_SEA = new System.Windows.Forms.GroupBox();
            this.chartRes_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewFunction_SEA = new System.Windows.Forms.DataGridView();
            this.groupBoxInput_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxS_SEA = new System.Windows.Forms.Label();
            this.textBoxlSt_SEA = new System.Windows.Forms.Label();
            this.textBoxStop_SEA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SEA = new System.Windows.Forms.TextBox();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.pictureBoxForm_SEA = new System.Windows.Forms.PictureBox();
            this.groupBoxTask_SEA.SuspendLayout();
            this.groupBoxRes_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SEA)).BeginInit();
            this.groupBoxInput_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_SEA
            // 
            this.groupBoxTask_SEA.Controls.Add(this.pictureBoxForm_SEA);
            this.groupBoxTask_SEA.Controls.Add(this.textBoxTask_SEA);
            this.groupBoxTask_SEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SEA.Name = "groupBoxTask_SEA";
            this.groupBoxTask_SEA.Size = new System.Drawing.Size(346, 186);
            this.groupBoxTask_SEA.TabIndex = 0;
            this.groupBoxTask_SEA.TabStop = false;
            this.groupBoxTask_SEA.Text = "Усовие";
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTask_SEA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SEA.Multiline = true;
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.ReadOnly = true;
            this.textBoxTask_SEA.Size = new System.Drawing.Size(334, 36);
            this.textBoxTask_SEA.TabIndex = 1;
            this.textBoxTask_SEA.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в DataGrid" +
    "View и построить график функции.";
            // 
            // groupBoxRes_SEA
            // 
            this.groupBoxRes_SEA.Controls.Add(this.chartRes_SEA);
            this.groupBoxRes_SEA.Controls.Add(this.dataGridViewFunction_SEA);
            this.groupBoxRes_SEA.Location = new System.Drawing.Point(364, 12);
            this.groupBoxRes_SEA.Name = "groupBoxRes_SEA";
            this.groupBoxRes_SEA.Size = new System.Drawing.Size(638, 264);
            this.groupBoxRes_SEA.TabIndex = 1;
            this.groupBoxRes_SEA.TabStop = false;
            this.groupBoxRes_SEA.Text = "Вывоод данных";
            // 
            // chartRes_SEA
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRes_SEA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRes_SEA.Legends.Add(legend1);
            this.chartRes_SEA.Location = new System.Drawing.Point(132, 19);
            this.chartRes_SEA.Name = "chartRes_SEA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRes_SEA.Series.Add(series1);
            this.chartRes_SEA.Size = new System.Drawing.Size(500, 239);
            this.chartRes_SEA.TabIndex = 3;
            this.chartRes_SEA.Text = "chart1";
            // 
            // dataGridViewFunction_SEA
            // 
            this.dataGridViewFunction_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SEA.ColumnHeadersVisible = false;
            this.dataGridViewFunction_SEA.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewFunction_SEA.Name = "dataGridViewFunction_SEA";
            this.dataGridViewFunction_SEA.RowHeadersVisible = false;
            this.dataGridViewFunction_SEA.Size = new System.Drawing.Size(120, 239);
            this.dataGridViewFunction_SEA.TabIndex = 2;
            // 
            // groupBoxInput_SEA
            // 
            this.groupBoxInput_SEA.Controls.Add(this.textBoxS_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.textBoxlSt_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.textBoxStop_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.textBoxStart_SEA);
            this.groupBoxInput_SEA.Location = new System.Drawing.Point(12, 204);
            this.groupBoxInput_SEA.Name = "groupBoxInput_SEA";
            this.groupBoxInput_SEA.Size = new System.Drawing.Size(152, 72);
            this.groupBoxInput_SEA.TabIndex = 4;
            this.groupBoxInput_SEA.TabStop = false;
            this.groupBoxInput_SEA.Text = "Ввод анных";
            // 
            // textBoxS_SEA
            // 
            this.textBoxS_SEA.AutoSize = true;
            this.textBoxS_SEA.Location = new System.Drawing.Point(76, 20);
            this.textBoxS_SEA.Name = "textBoxS_SEA";
            this.textBoxS_SEA.Size = new System.Drawing.Size(69, 13);
            this.textBoxS_SEA.TabIndex = 4;
            this.textBoxS_SEA.Text = "Конец шага:";
            // 
            // textBoxlSt_SEA
            // 
            this.textBoxlSt_SEA.AutoSize = true;
            this.textBoxlSt_SEA.Location = new System.Drawing.Point(3, 20);
            this.textBoxlSt_SEA.Name = "textBoxlSt_SEA";
            this.textBoxlSt_SEA.Size = new System.Drawing.Size(67, 13);
            this.textBoxlSt_SEA.TabIndex = 5;
            this.textBoxlSt_SEA.Text = "Старт шага:";
            // 
            // textBoxStop_SEA
            // 
            this.textBoxStop_SEA.Location = new System.Drawing.Point(79, 37);
            this.textBoxStop_SEA.Name = "textBoxStop_SEA";
            this.textBoxStop_SEA.Size = new System.Drawing.Size(66, 20);
            this.textBoxStop_SEA.TabIndex = 3;
            // 
            // textBoxStart_SEA
            // 
            this.textBoxStart_SEA.Location = new System.Drawing.Point(6, 37);
            this.textBoxStart_SEA.Name = "textBoxStart_SEA";
            this.textBoxStart_SEA.Size = new System.Drawing.Size(66, 20);
            this.textBoxStart_SEA.TabIndex = 2;
            this.textBoxStart_SEA.TextChanged += new System.EventHandler(this.textBoxStart_SEA_TextChanged);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(306, 224);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(52, 46);
            this.buttonHelp_SEA.TabIndex = 8;
            this.buttonHelp_SEA.Text = "?";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_SEA.Location = new System.Drawing.Point(170, 224);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(130, 46);
            this.buttonDone_SEA.TabIndex = 7;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // pictureBoxForm_SEA
            // 
            this.pictureBoxForm_SEA.BackgroundImage = global::Tyuiu.ShadrinEA.Sprint6.Task2.V19.Properties.Resources.formula2;
            this.pictureBoxForm_SEA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxForm_SEA.Location = new System.Drawing.Point(6, 61);
            this.pictureBoxForm_SEA.Name = "pictureBoxForm_SEA";
            this.pictureBoxForm_SEA.Size = new System.Drawing.Size(334, 119);
            this.pictureBoxForm_SEA.TabIndex = 2;
            this.pictureBoxForm_SEA.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 281);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.groupBoxInput_SEA);
            this.Controls.Add(this.groupBoxRes_SEA);
            this.Controls.Add(this.groupBoxTask_SEA);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.groupBoxTask_SEA.ResumeLayout(false);
            this.groupBoxTask_SEA.PerformLayout();
            this.groupBoxRes_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRes_SEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SEA)).EndInit();
            this.groupBoxInput_SEA.ResumeLayout(false);
            this.groupBoxInput_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SEA;
        private System.Windows.Forms.GroupBox groupBoxRes_SEA;
        private System.Windows.Forms.PictureBox pictureBoxForm_SEA;
        private System.Windows.Forms.TextBox textBoxTask_SEA;
        private System.Windows.Forms.GroupBox groupBoxInput_SEA;
        private System.Windows.Forms.Label textBoxS_SEA;
        private System.Windows.Forms.Label textBoxlSt_SEA;
        private System.Windows.Forms.TextBox textBoxStop_SEA;
        private System.Windows.Forms.TextBox textBoxStart_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRes_SEA;
    }
}

