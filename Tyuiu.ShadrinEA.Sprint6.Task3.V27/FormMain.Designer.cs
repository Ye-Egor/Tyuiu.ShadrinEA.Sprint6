
namespace Tyuiu.ShadrinEA.Sprint6.Task3.V27
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
            this.groupBoxTask_SEA = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_SEA = new System.Windows.Forms.DataGridView();
            this.textBoxTask_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_SEA = new System.Windows.Forms.GroupBox();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.textBoxRes_SEA = new System.Windows.Forms.TextBox();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.groupBoxTask_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SEA)).BeginInit();
            this.groupBoxOutPut_SEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SEA
            // 
            this.groupBoxTask_SEA.Controls.Add(this.dataGridViewMatrix_SEA);
            this.groupBoxTask_SEA.Controls.Add(this.textBoxTask_SEA);
            this.groupBoxTask_SEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SEA.Name = "groupBoxTask_SEA";
            this.groupBoxTask_SEA.Size = new System.Drawing.Size(479, 243);
            this.groupBoxTask_SEA.TabIndex = 0;
            this.groupBoxTask_SEA.TabStop = false;
            this.groupBoxTask_SEA.Text = "Условие";
            // 
            // dataGridViewMatrix_SEA
            // 
            this.dataGridViewMatrix_SEA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SEA.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_SEA.Location = new System.Drawing.Point(244, 22);
            this.dataGridViewMatrix_SEA.Name = "dataGridViewMatrix_SEA";
            this.dataGridViewMatrix_SEA.RowHeadersVisible = false;
            this.dataGridViewMatrix_SEA.Size = new System.Drawing.Size(229, 218);
            this.dataGridViewMatrix_SEA.TabIndex = 1;
            this.dataGridViewMatrix_SEA.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_SEA_CellContentClick);
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SEA.Multiline = true;
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.ReadOnly = true;
            this.textBoxTask_SEA.Size = new System.Drawing.Size(232, 218);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.Text = " Дан массив 5 на 5 элемтов. Выполнить сортировку по\r\n возрастанию в четвером стол" +
    "бце.";
            // 
            // groupBoxOutPut_SEA
            // 
            this.groupBoxOutPut_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxOutPut_SEA.Controls.Add(this.textBoxRes_SEA);
            this.groupBoxOutPut_SEA.Location = new System.Drawing.Point(499, 12);
            this.groupBoxOutPut_SEA.Name = "groupBoxOutPut_SEA";
            this.groupBoxOutPut_SEA.Size = new System.Drawing.Size(153, 66);
            this.groupBoxOutPut_SEA.TabIndex = 1;
            this.groupBoxOutPut_SEA.TabStop = false;
            this.groupBoxOutPut_SEA.Text = "Выввод данных";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(6, 22);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SEA.TabIndex = 3;
            this.labelResult_SEA.Text = "Результат:";
            this.labelResult_SEA.Click += new System.EventHandler(this.labelResult_GAM_Click);
            // 
            // textBoxRes_SEA
            // 
            this.textBoxRes_SEA.Location = new System.Drawing.Point(6, 38);
            this.textBoxRes_SEA.Name = "textBoxRes_SEA";
            this.textBoxRes_SEA.ReadOnly = true;
            this.textBoxRes_SEA.Size = new System.Drawing.Size(141, 20);
            this.textBoxRes_SEA.TabIndex = 0;
            this.textBoxRes_SEA.TabStop = false;
            this.textBoxRes_SEA.Text = "Не выполнено";
            this.textBoxRes_SEA.TextChanged += new System.EventHandler(this.textBoxRes_SEA_TextChanged);
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.Location = new System.Drawing.Point(537, 225);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(115, 30);
            this.buttonDone_SEA.TabIndex = 2;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = true;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_SEA_Click);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.Location = new System.Drawing.Point(499, 225);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(32, 30);
            this.buttonHelp_SEA.TabIndex = 3;
            this.buttonHelp_SEA.Text = "?";
            this.buttonHelp_SEA.UseVisualStyleBackColor = true;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_SEA_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 264);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.groupBoxOutPut_SEA);
            this.Controls.Add(this.groupBoxTask_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 3 | Вариант 27 | Шадрин Е.А";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_SEA.ResumeLayout(false);
            this.groupBoxTask_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SEA)).EndInit();
            this.groupBoxOutPut_SEA.ResumeLayout(false);
            this.groupBoxOutPut_SEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxTask_SEA;
        private System.Windows.Forms.GroupBox groupBoxOutPut_SEA;
        private System.Windows.Forms.TextBox textBoxRes_SEA;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
    }
}

