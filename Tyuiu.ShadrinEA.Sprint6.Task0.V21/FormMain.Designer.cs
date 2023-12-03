
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
            this.groupBoxTaskk = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBoxTask = new System.Windows.Forms.TextBox();
            this.groupBoxVar = new System.Windows.Forms.GroupBox();
            this.textBoxVarA = new System.Windows.Forms.TextBox();
            this.groupBoxRess = new System.Windows.Forms.GroupBox();
            this.textBoxRes = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonWhat = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBoxTaskk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxVar.SuspendLayout();
            this.groupBoxRess.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTaskk
            // 
            this.groupBoxTaskk.Controls.Add(this.pictureBox1);
            this.groupBoxTaskk.Controls.Add(this.textBoxTask);
            this.groupBoxTaskk.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTaskk.Name = "groupBoxTaskk";
            this.groupBoxTaskk.Size = new System.Drawing.Size(776, 184);
            this.groupBoxTaskk.TabIndex = 0;
            this.groupBoxTaskk.TabStop = false;
            this.groupBoxTaskk.Text = "Условие";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tyuiu.ShadrinEA.Sprint6.Task0.V21.Properties.Resources.Tasko;
            this.pictureBox1.Location = new System.Drawing.Point(482, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 44);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBoxTask
            // 
            this.textBoxTask.Location = new System.Drawing.Point(6, 19);
            this.textBoxTask.Multiline = true;
            this.textBoxTask.Name = "textBoxTask";
            this.textBoxTask.ReadOnly = true;
            this.textBoxTask.Size = new System.Drawing.Size(470, 159);
            this.textBoxTask.TabIndex = 0;
            // 
            // groupBoxVar
            // 
            this.groupBoxVar.Controls.Add(this.textBox);
            this.groupBoxVar.Controls.Add(this.textBoxVarA);
            this.groupBoxVar.Location = new System.Drawing.Point(18, 202);
            this.groupBoxVar.Name = "groupBoxVar";
            this.groupBoxVar.Size = new System.Drawing.Size(236, 81);
            this.groupBoxVar.TabIndex = 1;
            this.groupBoxVar.TabStop = false;
            this.groupBoxVar.Text = "Ввод данных";
            // 
            // textBoxVarA
            // 
            this.textBoxVarA.Location = new System.Drawing.Point(6, 48);
            this.textBoxVarA.Name = "textBoxVarA";
            this.textBoxVarA.Size = new System.Drawing.Size(224, 20);
            this.textBoxVarA.TabIndex = 3;
            // 
            // groupBoxRess
            // 
            this.groupBoxRess.Controls.Add(this.textBox1);
            this.groupBoxRess.Controls.Add(this.textBoxRes);
            this.groupBoxRess.Location = new System.Drawing.Point(260, 203);
            this.groupBoxRess.Name = "groupBoxRess";
            this.groupBoxRess.Size = new System.Drawing.Size(228, 80);
            this.groupBoxRess.TabIndex = 2;
            this.groupBoxRess.TabStop = false;
            this.groupBoxRess.Text = "Вывод данных";
            // 
            // textBoxRes
            // 
            this.textBoxRes.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRes.Location = new System.Drawing.Point(6, 47);
            this.textBoxRes.Name = "textBoxRes";
            this.textBoxRes.ReadOnly = true;
            this.textBoxRes.Size = new System.Drawing.Size(216, 20);
            this.textBoxRes.TabIndex = 0;
            // 
            // buttonDone
            // 
            this.buttonDone.ForeColor = System.Drawing.Color.Black;
            this.buttonDone.Location = new System.Drawing.Point(559, 226);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(229, 44);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Выполнить";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonWhat
            // 
            this.buttonWhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWhat.Location = new System.Drawing.Point(494, 226);
            this.buttonWhat.Name = "buttonWhat";
            this.buttonWhat.Size = new System.Drawing.Size(65, 44);
            this.buttonWhat.TabIndex = 4;
            this.buttonWhat.Text = "?";
            this.buttonWhat.UseVisualStyleBackColor = true;
            this.buttonWhat.Click += new System.EventHandler(this.buttonWhat_Click);
            // 
            // textBox
            // 
            this.textBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox.BackColor = System.Drawing.SystemColors.Control;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Enabled = false;
            this.textBox.Location = new System.Drawing.Point(6, 22);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(100, 13);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "Переменная Х:";
            // 
            // textBox1
            // 
            this.textBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Результат:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 316);
            this.Controls.Add(this.buttonWhat);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.groupBoxRess);
            this.Controls.Add(this.groupBoxVar);
            this.Controls.Add(this.groupBoxTaskk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6  | Task 0 | Вариант 21 | Шадрин Е.А";
            this.groupBoxTaskk.ResumeLayout(false);
            this.groupBoxTaskk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxVar.ResumeLayout(false);
            this.groupBoxVar.PerformLayout();
            this.groupBoxRess.ResumeLayout(false);
            this.groupBoxRess.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTaskk;
        private System.Windows.Forms.TextBox textBoxTask;
        private System.Windows.Forms.GroupBox groupBoxVar;
        private System.Windows.Forms.GroupBox groupBoxRess;
        private System.Windows.Forms.TextBox textBoxRes;
        private System.Windows.Forms.TextBox textBoxVarA;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonWhat;
    }
}

