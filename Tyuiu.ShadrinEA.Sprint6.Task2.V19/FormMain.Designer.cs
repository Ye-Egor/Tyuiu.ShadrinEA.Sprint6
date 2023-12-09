
namespace Tyuiu.ShadrinEA.Sprint6.Task2.V19
{
    partial class FormMain_SEA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutput_SEA = new System.Windows.Forms.GroupBox();
            this.chartResult_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.dataGridViewFunction_SEA = new System.Windows.Forms.DataGridView();
            this.X_GAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F_GAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.groupBoxInput_SEA = new System.Windows.Forms.GroupBox();
            this.labelstop_SEA = new System.Windows.Forms.Label();
            this.labelstart_SEA = new System.Windows.Forms.Label();
            this.textBoxStop_SEA = new System.Windows.Forms.TextBox();
            this.textBoxStart_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SEA = new System.Windows.Forms.GroupBox();
            this.pictureBox_SEA = new System.Windows.Forms.PictureBox();
            this.textBoxCondition_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxOutput_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SEA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SEA)).BeginInit();
            this.groupBoxInput_SEA.SuspendLayout();
            this.groupBoxCondition_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutput_SEA
            // 
            this.groupBoxOutput_SEA.Controls.Add(this.chartResult_SEA);
            this.groupBoxOutput_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxOutput_SEA.Controls.Add(this.dataGridViewFunction_SEA);
            this.groupBoxOutput_SEA.Location = new System.Drawing.Point(469, 12);
            this.groupBoxOutput_SEA.Name = "groupBoxOutput_SEA";
            this.groupBoxOutput_SEA.Size = new System.Drawing.Size(547, 297);
            this.groupBoxOutput_SEA.TabIndex = 8;
            this.groupBoxOutput_SEA.TabStop = false;
            this.groupBoxOutput_SEA.Text = "Вывод данных";
            // 
            // chartResult_SEA
            // 
            chartArea5.Name = "ChartArea1";
            this.chartResult_SEA.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartResult_SEA.Legends.Add(legend5);
            this.chartResult_SEA.Location = new System.Drawing.Point(152, 38);
            this.chartResult_SEA.Name = "chartResult_SEA";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.IsVisibleInLegend = false;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chartResult_SEA.Series.Add(series5);
            this.chartResult_SEA.Size = new System.Drawing.Size(394, 250);
            this.chartResult_SEA.TabIndex = 5;
            this.chartResult_SEA.Text = "chartResult";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(7, 19);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SEA.TabIndex = 4;
            this.labelResult_SEA.Text = "Результат:";
            // 
            // dataGridViewFunction_SEA
            // 
            this.dataGridViewFunction_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_SEA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X_GAM,
            this.F_GAM});
            this.dataGridViewFunction_SEA.Location = new System.Drawing.Point(10, 35);
            this.dataGridViewFunction_SEA.Name = "dataGridViewFunction_SEA";
            this.dataGridViewFunction_SEA.RowHeadersVisible = false;
            this.dataGridViewFunction_SEA.Size = new System.Drawing.Size(117, 254);
            this.dataGridViewFunction_SEA.TabIndex = 3;
            // 
            // X_GAM
            // 
            this.X_GAM.HeaderText = "x";
            this.X_GAM.Name = "X_GAM";
            this.X_GAM.ReadOnly = true;
            this.X_GAM.Width = 50;
            // 
            // F_GAM
            // 
            this.F_GAM.HeaderText = "f(x)";
            this.F_GAM.Name = "F_GAM";
            this.F_GAM.ReadOnly = true;
            this.F_GAM.Width = 50;
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonDone_SEA.Location = new System.Drawing.Point(331, 254);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(122, 55);
            this.buttonDone_SEA.TabIndex = 6;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            this.buttonDone_SEA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_SEA_MouseDown);
            this.buttonDone_SEA.MouseEnter += new System.EventHandler(this.buttonDone_SEA_MouseEnter);
            this.buttonDone_SEA.MouseLeave += new System.EventHandler(this.buttonDone_SEA_MouseLeave);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(250, 254);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(75, 55);
            this.buttonHelp_SEA.TabIndex = 7;
            this.buttonHelp_SEA.Text = "Справка";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click_1);
            // 
            // groupBoxInput_SEA
            // 
            this.groupBoxInput_SEA.Controls.Add(this.labelstop_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.labelstart_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.textBoxStop_SEA);
            this.groupBoxInput_SEA.Controls.Add(this.textBoxStart_SEA);
            this.groupBoxInput_SEA.Location = new System.Drawing.Point(15, 249);
            this.groupBoxInput_SEA.Name = "groupBoxInput_SEA";
            this.groupBoxInput_SEA.Size = new System.Drawing.Size(228, 60);
            this.groupBoxInput_SEA.TabIndex = 5;
            this.groupBoxInput_SEA.TabStop = false;
            this.groupBoxInput_SEA.Text = "Ввод данных";
            // 
            // labelstop_SEA
            // 
            this.labelstop_SEA.AutoSize = true;
            this.labelstop_SEA.Location = new System.Drawing.Point(110, 16);
            this.labelstop_SEA.Name = "labelstop_SEA";
            this.labelstop_SEA.Size = new System.Drawing.Size(69, 13);
            this.labelstop_SEA.TabIndex = 1;
            this.labelstop_SEA.Text = "Конец шага:";
            // 
            // labelstart_SEA
            // 
            this.labelstart_SEA.AutoSize = true;
            this.labelstart_SEA.Location = new System.Drawing.Point(7, 16);
            this.labelstart_SEA.Name = "labelstart_SEA";
            this.labelstart_SEA.Size = new System.Drawing.Size(67, 13);
            this.labelstart_SEA.TabIndex = 1;
            this.labelstart_SEA.Text = "Старт шага:";
            // 
            // textBoxStop_SEA
            // 
            this.textBoxStop_SEA.Location = new System.Drawing.Point(113, 32);
            this.textBoxStop_SEA.Name = "textBoxStop_SEA";
            this.textBoxStop_SEA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStop_SEA.TabIndex = 0;
            // 
            // textBoxStart_SEA
            // 
            this.textBoxStart_SEA.Location = new System.Drawing.Point(7, 32);
            this.textBoxStart_SEA.Name = "textBoxStart_SEA";
            this.textBoxStart_SEA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStart_SEA.TabIndex = 0;
            // 
            // groupBoxCondition_SEA
            // 
            this.groupBoxCondition_SEA.Controls.Add(this.pictureBox_SEA);
            this.groupBoxCondition_SEA.Controls.Add(this.textBoxCondition_SEA);
            this.groupBoxCondition_SEA.Location = new System.Drawing.Point(15, 12);
            this.groupBoxCondition_SEA.Name = "groupBoxCondition_SEA";
            this.groupBoxCondition_SEA.Size = new System.Drawing.Size(441, 231);
            this.groupBoxCondition_SEA.TabIndex = 4;
            this.groupBoxCondition_SEA.TabStop = false;
            this.groupBoxCondition_SEA.Text = "Условие";
            // 
            // pictureBox_SEA
            // 
            this.pictureBox_SEA.BackgroundImage = global::Tyuiu.ShadrinEA.Sprint6.Task2.V19.Properties.Resources.formula2;
            this.pictureBox_SEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_SEA.Location = new System.Drawing.Point(69, 124);
            this.pictureBox_SEA.Name = "pictureBox_SEA";
            this.pictureBox_SEA.Size = new System.Drawing.Size(303, 39);
            this.pictureBox_SEA.TabIndex = 1;
            this.pictureBox_SEA.TabStop = false;
            // 
            // textBoxCondition_SEA
            // 
            this.textBoxCondition_SEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCondition_SEA.Location = new System.Drawing.Point(3, 16);
            this.textBoxCondition_SEA.Multiline = true;
            this.textBoxCondition_SEA.Name = "textBoxCondition_SEA";
            this.textBoxCondition_SEA.ReadOnly = true;
            this.textBoxCondition_SEA.Size = new System.Drawing.Size(432, 209);
            this.textBoxCondition_SEA.TabIndex = 0;
            this.textBoxCondition_SEA.Text = "Протабулировать функцию F(x)\r\nна заданном диапазоне.\r\nРезультат вывести в DataGri" +
    "dView и построить график функции";
            // 
            // FormMain_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 317);
            this.Controls.Add(this.groupBoxOutput_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.groupBoxInput_SEA);
            this.Controls.Add(this.groupBoxCondition_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 2 | Вариант 19 | Шадрин Е.А";
            this.groupBoxOutput_SEA.ResumeLayout(false);
            this.groupBoxOutput_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_SEA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_SEA)).EndInit();
            this.groupBoxInput_SEA.ResumeLayout(false);
            this.groupBoxInput_SEA.PerformLayout();
            this.groupBoxCondition_SEA.ResumeLayout(false);
            this.groupBoxCondition_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutput_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
        private System.Windows.Forms.DataGridView dataGridViewFunction_SEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn X_SEA;
        private System.Windows.Forms.DataGridViewTextBoxColumn F_GAM;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.GroupBox groupBoxInput_SEA;
        private System.Windows.Forms.Label labelstop_SEA;
        private System.Windows.Forms.Label labelstart_SEA;
        private System.Windows.Forms.TextBox textBoxStop_SEA;
        private System.Windows.Forms.TextBox textBoxStart_SEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SEA;
        private System.Windows.Forms.TextBox textBoxCondition_SEA;
        private System.Windows.Forms.PictureBox pictureBox_SEA;
    }
}

