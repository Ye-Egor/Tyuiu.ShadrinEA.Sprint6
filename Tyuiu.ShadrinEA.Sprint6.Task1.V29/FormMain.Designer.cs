
namespace Tyuiu.ShadrinEA.Sprint6.Task1.V29
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
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonHelp_SEA = new System.Windows.Forms.Button();
            this.groupBoxInPut_SEA = new System.Windows.Forms.GroupBox();
            this.labelVarStop_SEA = new System.Windows.Forms.Label();
            this.labelVarStart_SEA = new System.Windows.Forms.Label();
            this.textBoxStopValue_SEA = new System.Windows.Forms.TextBox();
            this.textBoxStartValue_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxResult_SEA = new System.Windows.Forms.GroupBox();
            this.labelResult_SEA = new System.Windows.Forms.Label();
            this.textBoxResult_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxCondition_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxTask_SEA = new System.Windows.Forms.TextBox();
            this.pictureBoxFormula1_SEA = new System.Windows.Forms.PictureBox();
            this.groupBoxInPut_SEA.SuspendLayout();
            this.groupBoxResult_SEA.SuspendLayout();
            this.groupBoxCondition_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula1_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonDone_SEA.Location = new System.Drawing.Point(346, 250);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(113, 54);
            this.buttonDone_SEA.TabIndex = 7;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = false;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_GAM_Click);
            // 
            // buttonHelp_SEA
            // 
            this.buttonHelp_SEA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonHelp_SEA.Location = new System.Drawing.Point(268, 250);
            this.buttonHelp_SEA.Name = "buttonHelp_SEA";
            this.buttonHelp_SEA.Size = new System.Drawing.Size(72, 54);
            this.buttonHelp_SEA.TabIndex = 8;
            this.buttonHelp_SEA.Text = "Справка";
            this.buttonHelp_SEA.UseVisualStyleBackColor = false;
            this.buttonHelp_SEA.Click += new System.EventHandler(this.buttonHelp_GAM_Click_1);
            // 
            // groupBoxInPut_SEA
            // 
            this.groupBoxInPut_SEA.Controls.Add(this.labelVarStop_SEA);
            this.groupBoxInPut_SEA.Controls.Add(this.labelVarStart_SEA);
            this.groupBoxInPut_SEA.Controls.Add(this.textBoxStopValue_SEA);
            this.groupBoxInPut_SEA.Controls.Add(this.textBoxStartValue_SEA);
            this.groupBoxInPut_SEA.Location = new System.Drawing.Point(12, 247);
            this.groupBoxInPut_SEA.Name = "groupBoxInPut_SEA";
            this.groupBoxInPut_SEA.Size = new System.Drawing.Size(250, 57);
            this.groupBoxInPut_SEA.TabIndex = 6;
            this.groupBoxInPut_SEA.TabStop = false;
            this.groupBoxInPut_SEA.Text = "Ввод данных";
            // 
            // labelVarStop_SEA
            // 
            this.labelVarStop_SEA.AutoSize = true;
            this.labelVarStop_SEA.Location = new System.Drawing.Point(109, 16);
            this.labelVarStop_SEA.Name = "labelVarStop_SEA";
            this.labelVarStop_SEA.Size = new System.Drawing.Size(69, 13);
            this.labelVarStop_SEA.TabIndex = 1;
            this.labelVarStop_SEA.Text = "Конец шага:";
            // 
            // labelVarStart_SEA
            // 
            this.labelVarStart_SEA.AutoSize = true;
            this.labelVarStart_SEA.Location = new System.Drawing.Point(7, 14);
            this.labelVarStart_SEA.Name = "labelVarStart_SEA";
            this.labelVarStart_SEA.Size = new System.Drawing.Size(67, 13);
            this.labelVarStart_SEA.TabIndex = 1;
            this.labelVarStart_SEA.Text = "Старт шага:";
            // 
            // textBoxStopValue_SEA
            // 
            this.textBoxStopValue_SEA.Location = new System.Drawing.Point(112, 30);
            this.textBoxStopValue_SEA.Multiline = true;
            this.textBoxStopValue_SEA.Name = "textBoxStopValue_SEA";
            this.textBoxStopValue_SEA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStopValue_SEA.TabIndex = 0;
            // 
            // textBoxStartValue_SEA
            // 
            this.textBoxStartValue_SEA.Location = new System.Drawing.Point(6, 30);
            this.textBoxStartValue_SEA.Multiline = true;
            this.textBoxStartValue_SEA.Name = "textBoxStartValue_SEA";
            this.textBoxStartValue_SEA.Size = new System.Drawing.Size(100, 20);
            this.textBoxStartValue_SEA.TabIndex = 0;
            // 
            // groupBoxResult_SEA
            // 
            this.groupBoxResult_SEA.Controls.Add(this.labelResult_SEA);
            this.groupBoxResult_SEA.Controls.Add(this.textBoxResult_SEA);
            this.groupBoxResult_SEA.Location = new System.Drawing.Point(465, 12);
            this.groupBoxResult_SEA.Name = "groupBoxResult_SEA";
            this.groupBoxResult_SEA.Size = new System.Drawing.Size(243, 292);
            this.groupBoxResult_SEA.TabIndex = 5;
            this.groupBoxResult_SEA.TabStop = false;
            this.groupBoxResult_SEA.Text = "Вывод данных";
            // 
            // labelResult_SEA
            // 
            this.labelResult_SEA.AutoSize = true;
            this.labelResult_SEA.Location = new System.Drawing.Point(6, 16);
            this.labelResult_SEA.Name = "labelResult_SEA";
            this.labelResult_SEA.Size = new System.Drawing.Size(62, 13);
            this.labelResult_SEA.TabIndex = 4;
            this.labelResult_SEA.Text = "Результат:";
            // 
            // textBoxResult_SEA
            // 
            this.textBoxResult_SEA.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_SEA.Location = new System.Drawing.Point(6, 32);
            this.textBoxResult_SEA.Multiline = true;
            this.textBoxResult_SEA.Name = "textBoxResult_SEA";
            this.textBoxResult_SEA.ReadOnly = true;
            this.textBoxResult_SEA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_SEA.Size = new System.Drawing.Size(231, 255);
            this.textBoxResult_SEA.TabIndex = 3;
            // 
            // groupBoxCondition_SEA
            // 
            this.groupBoxCondition_SEA.Controls.Add(this.pictureBoxFormula1_SEA);
            this.groupBoxCondition_SEA.Controls.Add(this.textBoxTask_SEA);
            this.groupBoxCondition_SEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCondition_SEA.Name = "groupBoxCondition_SEA";
            this.groupBoxCondition_SEA.Size = new System.Drawing.Size(447, 229);
            this.groupBoxCondition_SEA.TabIndex = 4;
            this.groupBoxCondition_SEA.TabStop = false;
            this.groupBoxCondition_SEA.Text = "Условие";
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Location = new System.Drawing.Point(7, 20);
            this.textBoxTask_SEA.Multiline = true;
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.ReadOnly = true;
            this.textBoxTask_SEA.Size = new System.Drawing.Size(434, 203);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.Text = "Протабулировать функцию F(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы. При делении на ноль вернуть значение 0.";
            // 
            // pictureBoxFormula1_SEA
            // 
            this.pictureBoxFormula1_SEA.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxFormula1_SEA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFormula1_SEA.Image = global::Tyuiu.ShadrinEA.Sprint6.Task1.V29.Properties.Resources.formula1;
            this.pictureBoxFormula1_SEA.Location = new System.Drawing.Point(52, 114);
            this.pictureBoxFormula1_SEA.Name = "pictureBoxFormula1_SEA";
            this.pictureBoxFormula1_SEA.Size = new System.Drawing.Size(326, 41);
            this.pictureBoxFormula1_SEA.TabIndex = 1;
            this.pictureBoxFormula1_SEA.TabStop = false;
            // 
            // FormMain_SEA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 312);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.buttonHelp_SEA);
            this.Controls.Add(this.groupBoxInPut_SEA);
            this.Controls.Add(this.groupBoxResult_SEA);
            this.Controls.Add(this.groupBoxCondition_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain_SEA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 1 | Вариант 29 | Шадрин Е.А";
            this.groupBoxInPut_SEA.ResumeLayout(false);
            this.groupBoxInPut_SEA.PerformLayout();
            this.groupBoxResult_SEA.ResumeLayout(false);
            this.groupBoxResult_SEA.PerformLayout();
            this.groupBoxCondition_SEA.ResumeLayout(false);
            this.groupBoxCondition_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula1_SEA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.Button buttonHelp_SEA;
        private System.Windows.Forms.GroupBox groupBoxInPut_SEA;
        private System.Windows.Forms.Label labelVarStop_SEA;
        private System.Windows.Forms.Label labelVarStart_SEA;
        private System.Windows.Forms.TextBox textBoxStopValue_SEA;
        private System.Windows.Forms.TextBox textBoxStartValue_SEA;
        private System.Windows.Forms.GroupBox groupBoxResult_SEA;
        private System.Windows.Forms.Label labelResult_SEA;
        private System.Windows.Forms.TextBox textBoxResult_SEA;
        private System.Windows.Forms.GroupBox groupBoxCondition_SEA;
        private System.Windows.Forms.TextBox textBoxTask_SEA;
        private System.Windows.Forms.PictureBox pictureBoxFormula1_SEA;
    }
}

