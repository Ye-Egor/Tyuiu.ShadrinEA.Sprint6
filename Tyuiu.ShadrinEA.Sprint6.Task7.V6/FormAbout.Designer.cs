
namespace Tyuiu.ShadrinEA.Sprint6.Task7.V6
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.buttonOK_SEA = new System.Windows.Forms.Button();
            this.textBoxInfo_SEA = new System.Windows.Forms.TextBox();
            this.pictureBoxAv_SEA = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAv_SEA)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOK_SEA
            // 
            this.buttonOK_SEA.Location = new System.Drawing.Point(316, 136);
            this.buttonOK_SEA.Name = "buttonOK_SEA";
            this.buttonOK_SEA.Size = new System.Drawing.Size(106, 21);
            this.buttonOK_SEA.TabIndex = 5;
            this.buttonOK_SEA.Text = "OK";
            this.buttonOK_SEA.UseVisualStyleBackColor = true;
            this.buttonOK_SEA.Click += new System.EventHandler(this.buttonOK_SEA_Click);
            // 
            // textBoxInfo_SEA
            // 
            this.textBoxInfo_SEA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo_SEA.Location = new System.Drawing.Point(139, 3);
            this.textBoxInfo_SEA.Multiline = true;
            this.textBoxInfo_SEA.Name = "textBoxInfo_SEA";
            this.textBoxInfo_SEA.ReadOnly = true;
            this.textBoxInfo_SEA.Size = new System.Drawing.Size(283, 127);
            this.textBoxInfo_SEA.TabIndex = 4;
            this.textBoxInfo_SEA.Text = resources.GetString("textBoxInfo_SEA.Text");
            // 
            // pictureBoxAv_SEA
            // 
            this.pictureBoxAv_SEA.BackgroundImage = global::Tyuiu.ShadrinEA.Sprint6.Task7.V6.Properties.Resources.rrr;
            this.pictureBoxAv_SEA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAv_SEA.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxAv_SEA.Name = "pictureBoxAv_SEA";
            this.pictureBoxAv_SEA.Size = new System.Drawing.Size(130, 155);
            this.pictureBoxAv_SEA.TabIndex = 3;
            this.pictureBoxAv_SEA.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 162);
            this.Controls.Add(this.buttonOK_SEA);
            this.Controls.Add(this.textBoxInfo_SEA);
            this.Controls.Add(this.pictureBoxAv_SEA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAv_SEA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOK_SEA;
        private System.Windows.Forms.TextBox textBoxInfo_SEA;
        private System.Windows.Forms.PictureBox pictureBoxAv_SEA;
    }
}