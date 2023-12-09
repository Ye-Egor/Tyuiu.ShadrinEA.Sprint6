
namespace Tyuiu.ShadrinEA.Sprint6.Task5.V25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTask_SEA = new System.Windows.Forms.Panel();
            this.buttonOpen_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.groupBoxCondition_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxcCondition_SEA = new System.Windows.Forms.TextBox();
            this.panelRes_SEA = new System.Windows.Forms.Panel();
            this.panelChart_SEA = new System.Windows.Forms.Panel();
            this.chartDiag_SEA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxRas_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewNums_SEA = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTask_SEA.SuspendLayout();
            this.groupBoxCondition_SEA.SuspendLayout();
            this.panelRes_SEA.SuspendLayout();
            this.panelChart_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SEA)).BeginInit();
            this.groupBoxRas_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTask_SEA
            // 
            this.panelTask_SEA.Controls.Add(this.buttonOpen_SEA);
            this.panelTask_SEA.Controls.Add(this.buttonHelp_SEA);
            this.panelTask_SEA.Controls.Add(this.buttonDone_SEA);
            this.panelTask_SEA.Controls.Add(this.groupBoxCondition_SEA);
            this.panelTask_SEA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_SEA.Location = new System.Drawing.Point(0, 0);
            this.panelTask_SEA.Name = "panelTask_SEA";
            this.panelTask_SEA.Size = new System.Drawing.Size(784, 77);
            this.panelTask_SEA.TabIndex = 0;
            // 
            // buttonOpen_SEA
            // 
            this.buttonOpen_SEA.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonOpen_SEA.Location = new System.Drawing.Point(644, 28);
            this.buttonOpen_SEA.Name = "buttonOpen_SEA";
            this.buttonOpen_SEA.Size = new System.Drawing.Size(82, 40);
            this.buttonOpen_SEA.TabIndex = 11;
            this.buttonOpen_SEA.Text = "Открыть фаил";
            this.buttonOpen_SEA.UseVisualStyleBackColor = false;
            this.buttonOpen_SEA.Click += new System.EventHandler(this.buttonOpen_SEA_Click);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_SEA.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(732, 28);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(41, 40);
            this.buttonHelp_SEA.TabIndex = 10;
            this.buttonHelp_SEA.Text = "?";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.LightGreen;
            this.buttonDone_SEA.Location = new System.Drawing.Point(556, 28);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(82, 40);
            this.buttonDone_SEA.TabIndex = 9;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // groupBoxCondition_SEA
            // 
            this.groupBoxCondition_SEA.Controls.Add(this.textBoxcCondition_SEA);
            this.groupBoxCondition_SEA.Location = new System.Drawing.Point(12, 3);
            this.groupBoxCondition_SEA.Name = "groupBoxCondition_SEA";
            this.groupBoxCondition_SEA.Size = new System.Drawing.Size(538, 68);
            this.groupBoxCondition_SEA.TabIndex = 7;
            this.groupBoxCondition_SEA.TabStop = false;
            this.groupBoxCondition_SEA.Text = "Условие";
            // 
            // textBoxcCondition_SEA
            // 
            this.textBoxcCondition_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxcCondition_SEA.Location = new System.Drawing.Point(3, 16);
            this.textBoxcCondition_SEA.Multiline = true;
            this.textBoxcCondition_SEA.Name = "textBoxcCondition_SEA";
            this.textBoxcCondition_SEA.ReadOnly = true;
            this.textBoxcCondition_SEA.Size = new System.Drawing.Size(532, 49);
            this.textBoxcCondition_SEA.TabIndex = 0;
            this.textBoxcCondition_SEA.Text = resources.GetString("textBoxcCondition_SEA.Text");
            // 
            // panelRes_SEA
            // 
            this.panelRes_SEA.Controls.Add(this.groupBoxRas_SEA);
            this.panelRes_SEA.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelRes_SEA.Location = new System.Drawing.Point(0, 77);
            this.panelRes_SEA.Margin = new System.Windows.Forms.Padding(5);
            this.panelRes_SEA.Name = "panelRes_SEA";
            this.panelRes_SEA.Size = new System.Drawing.Size(113, 334);
            this.panelRes_SEA.TabIndex = 1;
            // 
            // panelChart_SEA
            // 
            this.panelChart_SEA.Controls.Add(this.splitter1);
            this.panelChart_SEA.Controls.Add(this.chartDiag_SEA);
            this.panelChart_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart_SEA.Location = new System.Drawing.Point(113, 77);
            this.panelChart_SEA.Name = "panelChart_SEA";
            this.panelChart_SEA.Size = new System.Drawing.Size(671, 334);
            this.panelChart_SEA.TabIndex = 2;
            // 
            // chartDiag_SEA
            // 
            chartArea3.Name = "ChartArea1";
            this.chartDiag_SEA.ChartAreas.Add(chartArea3);
            this.chartDiag_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartDiag_SEA.Legends.Add(legend3);
            this.chartDiag_SEA.Location = new System.Drawing.Point(0, 0);
            this.chartDiag_SEA.Name = "chartDiag_SEA";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartDiag_SEA.Series.Add(series3);
            this.chartDiag_SEA.Size = new System.Drawing.Size(671, 334);
            this.chartDiag_SEA.TabIndex = 0;
            this.chartDiag_SEA.Text = "chart1";
            // 
            // groupBoxRas_SEA
            // 
            this.groupBoxRas_SEA.Controls.Add(this.dataGridViewNums_SEA);
            this.groupBoxRas_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRas_SEA.Location = new System.Drawing.Point(0, 0);
            this.groupBoxRas_SEA.Name = "groupBoxRas_SEA";
            this.groupBoxRas_SEA.Size = new System.Drawing.Size(113, 334);
            this.groupBoxRas_SEA.TabIndex = 0;
            this.groupBoxRas_SEA.TabStop = false;
            this.groupBoxRas_SEA.Text = "Вывод данных";
            // 
            // dataGridViewNums_SEA
            // 
            this.dataGridViewNums_SEA.AllowUserToAddRows = false;
            this.dataGridViewNums_SEA.AllowUserToDeleteRows = false;
            this.dataGridViewNums_SEA.AllowUserToResizeRows = false;
            this.dataGridViewNums_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNums_SEA.ColumnHeadersVisible = false;
            this.dataGridViewNums_SEA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNums_SEA.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewNums_SEA.Name = "dataGridViewNums_SEA";
            this.dataGridViewNums_SEA.ReadOnly = true;
            this.dataGridViewNums_SEA.RowHeadersVisible = false;
            this.dataGridViewNums_SEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNums_SEA.Size = new System.Drawing.Size(107, 315);
            this.dataGridViewNums_SEA.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 334);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panelChart_SEA);
            this.Controls.Add(this.panelRes_SEA);
            this.Controls.Add(this.panelTask_SEA);
            this.MinimumSize = new System.Drawing.Size(800, 450);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 5 | Вариант 25 | Шадрин Е.А";
            this.panelTask_SEA.ResumeLayout(false);
            this.groupBoxCondition_SEA.ResumeLayout(false);
            this.groupBoxCondition_SEA.PerformLayout();
            this.panelRes_SEA.ResumeLayout(false);
            this.panelChart_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDiag_SEA)).EndInit();
            this.groupBoxRas_SEA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNums_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTask_SEA;
        private System.Windows.Forms.Button buttonOpen_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SEA;
        private System.Windows.Forms.TextBox textBoxcCondition_SEA;
        private System.Windows.Forms.Panel panelRes_SEA;
        private System.Windows.Forms.Panel panelChart_SEA;
        private System.Windows.Forms.GroupBox groupBoxRas_SEA;
        private System.Windows.Forms.DataGridView dataGridViewNums_SEA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_SEA;
        private System.Windows.Forms.Splitter splitter1;
    }
}

