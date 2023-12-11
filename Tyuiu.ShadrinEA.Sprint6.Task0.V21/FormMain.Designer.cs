
namespace Tyuiu.ShadrinEA.Sprint6.Task0.V21
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
            this.pictureBoxForm_SEA = new System.Windows.Forms.PictureBox();
            this.textBoxTask_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxVar_SEA = new System.Windows.Forms.GroupBox();
            this.textBoxSEA = new System.Windows.Forms.TextBox();
            this.textBoxVarA_SEA = new System.Windows.Forms.TextBox();
            this.groupBoxRess_SEA = new System.Windows.Forms.GroupBox();
            this.textBox1SEA = new System.Windows.Forms.TextBox();
            this.textBoxRes_SEA = new System.Windows.Forms.TextBox();
            this.buttonDone_SEA = new System.Windows.Forms.Button();
            this.buttonWhat_SEA = new System.Windows.Forms.Button();
            this.groupBoxTask_SEA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SEA)).BeginInit();
            this.groupBoxVar_SEA.SuspendLayout();
            this.groupBoxRess_SEA.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_SEA
            // 
            this.groupBoxTask_SEA.Controls.Add(this.pictureBoxForm_SEA);
            this.groupBoxTask_SEA.Controls.Add(this.textBoxTask_SEA);
            this.groupBoxTask_SEA.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_SEA.Name = "groupBoxTask_SEA";
            this.groupBoxTask_SEA.Size = new System.Drawing.Size(696, 91);
            this.groupBoxTask_SEA.TabIndex = 0;
            this.groupBoxTask_SEA.TabStop = false;
            this.groupBoxTask_SEA.Text = "Условие";
            // 
            // pictureBoxForm_SEA
            // 
            this.pictureBoxForm_SEA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxForm_SEA.Image = global::Tyuiu.ShadrinEA.Sprint6.Task0.V21.Properties.Resources.Tasko;
            this.pictureBoxForm_SEA.Location = new System.Drawing.Point(400, 19);
            this.pictureBoxForm_SEA.Name = "pictureBoxForm_SEA";
            this.pictureBoxForm_SEA.Size = new System.Drawing.Size(288, 56);
            this.pictureBoxForm_SEA.TabIndex = 1;
            this.pictureBoxForm_SEA.TabStop = false;
            // 
            // textBoxTask_SEA
            // 
            this.textBoxTask_SEA.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask_SEA.Multiline = true;
            this.textBoxTask_SEA.Name = "textBoxTask_SEA";
            this.textBoxTask_SEA.ReadOnly = true;
            this.textBoxTask_SEA.Size = new System.Drawing.Size(388, 56);
            this.textBoxTask_SEA.TabIndex = 0;
            this.textBoxTask_SEA.Text = "Вычислить выражение по формуле";
            // 
            // groupBoxVar_SEA
            // 
            this.groupBoxVar_SEA.Controls.Add(this.textBoxSEA);
            this.groupBoxVar_SEA.Controls.Add(this.textBoxVarA_SEA);
            this.groupBoxVar_SEA.Location = new System.Drawing.Point(12, 108);
            this.groupBoxVar_SEA.Name = "groupBoxVar_SEA";
            this.groupBoxVar_SEA.Size = new System.Drawing.Size(236, 81);
            this.groupBoxVar_SEA.TabIndex = 1;
            this.groupBoxVar_SEA.TabStop = false;
            this.groupBoxVar_SEA.Text = "Ввод данных";
            // 
            // textBoxSEA
            // 
            this.textBoxSEA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBoxSEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxSEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSEA.Enabled = false;
            this.textBoxSEA.Location = new System.Drawing.Point(6, 22);
            this.textBoxSEA.Name = "textBoxSEA";
            this.textBoxSEA.ReadOnly = true;
            this.textBoxSEA.Size = new System.Drawing.Size(100, 13);
            this.textBoxSEA.TabIndex = 1;
            this.textBoxSEA.Text = "Переменная Х:";
            // 
            // textBoxVarA_SEA
            // 
            this.textBoxVarA_SEA.Location = new System.Drawing.Point(6, 48);
            this.textBoxVarA_SEA.Name = "textBoxVarA_SEA";
            this.textBoxVarA_SEA.Size = new System.Drawing.Size(224, 20);
            this.textBoxVarA_SEA.TabIndex = 3;
            // 
            // groupBoxRess_SEA
            // 
            this.groupBoxRess_SEA.Controls.Add(this.textBox1SEA);
            this.groupBoxRess_SEA.Controls.Add(this.textBoxRes_SEA);
            this.groupBoxRess_SEA.Location = new System.Drawing.Point(254, 109);
            this.groupBoxRess_SEA.Name = "groupBoxRess_SEA";
            this.groupBoxRess_SEA.Size = new System.Drawing.Size(228, 80);
            this.groupBoxRess_SEA.TabIndex = 2;
            this.groupBoxRess_SEA.TabStop = false;
            this.groupBoxRess_SEA.Text = "Вывод данных";
            // 
            // textBox1SEA
            // 
            this.textBox1SEA.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1SEA.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1SEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1SEA.Enabled = false;
            this.textBox1SEA.Location = new System.Drawing.Point(6, 21);
            this.textBox1SEA.Name = "textBox1SEA";
            this.textBox1SEA.ReadOnly = true;
            this.textBox1SEA.Size = new System.Drawing.Size(100, 13);
            this.textBox1SEA.TabIndex = 2;
            this.textBox1SEA.Text = "Результат:";
            this.textBox1SEA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxRes_SEA
            // 
            this.textBoxRes_SEA.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRes_SEA.Location = new System.Drawing.Point(6, 47);
            this.textBoxRes_SEA.Name = "textBoxRes_SEA";
            this.textBoxRes_SEA.ReadOnly = true;
            this.textBoxRes_SEA.Size = new System.Drawing.Size(216, 20);
            this.textBoxRes_SEA.TabIndex = 0;
            // 
            // buttonDone_SEA
            // 
            this.buttonDone_SEA.ForeColor = System.Drawing.Color.Black;
            this.buttonDone_SEA.Location = new System.Drawing.Point(539, 132);
            this.buttonDone_SEA.Name = "buttonDone_SEA";
            this.buttonDone_SEA.Size = new System.Drawing.Size(169, 44);
            this.buttonDone_SEA.TabIndex = 3;
            this.buttonDone_SEA.Text = "Выполнить";
            this.buttonDone_SEA.UseVisualStyleBackColor = true;
            this.buttonDone_SEA.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonWhat_SEA
            // 
            this.buttonWhat_SEA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhat_SEA.Location = new System.Drawing.Point(488, 132);
            this.buttonWhat_SEA.Name = "buttonWhat_SEA";
            this.buttonWhat_SEA.Size = new System.Drawing.Size(45, 44);
            this.buttonWhat_SEA.TabIndex = 4;
            this.buttonWhat_SEA.Text = "?";
            this.buttonWhat_SEA.UseVisualStyleBackColor = true;
            this.buttonWhat_SEA.Click += new System.EventHandler(this.buttonWhat_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 196);
            this.Controls.Add(this.buttonWhat_SEA);
            this.Controls.Add(this.buttonDone_SEA);
            this.Controls.Add(this.groupBoxRess_SEA);
            this.Controls.Add(this.groupBoxVar_SEA);
            this.Controls.Add(this.groupBoxTask_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 0 | Вариант 21 | Шадрин Е.А";
            this.groupBoxTask_SEA.ResumeLayout(false);
            this.groupBoxTask_SEA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxForm_SEA)).EndInit();
            this.groupBoxVar_SEA.ResumeLayout(false);
            this.groupBoxVar_SEA.PerformLayout();
            this.groupBoxRess_SEA.ResumeLayout(false);
            this.groupBoxRess_SEA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_SEA;
        private System.Windows.Forms.TextBox textBoxTask_SEA;
        private System.Windows.Forms.GroupBox groupBoxVar_SEA;
        private System.Windows.Forms.GroupBox groupBoxRess_SEA;
        private System.Windows.Forms.TextBox textBoxRes_SEA;
        private System.Windows.Forms.TextBox textBoxVarA_SEA;
        private System.Windows.Forms.PictureBox pictureBoxForm_SEA;
        private System.Windows.Forms.Button buttonDone_SEA;
        private System.Windows.Forms.TextBox textBoxSEA;
        private System.Windows.Forms.TextBox textBox1SEA;
        private System.Windows.Forms.Button buttonWhat_SEA;
    }
}

