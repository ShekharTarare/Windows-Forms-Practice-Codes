
namespace MyFirstApp
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBtn = new System.Windows.Forms.Button();
            this.checkBoxBtn = new System.Windows.Forms.Button();
            this.maskedTextBoxBtn = new System.Windows.Forms.Button();
            this.pictureBoxBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Home";
            // 
            // comboBoxBtn
            // 
            this.comboBoxBtn.Location = new System.Drawing.Point(50, 84);
            this.comboBoxBtn.Name = "comboBoxBtn";
            this.comboBoxBtn.Size = new System.Drawing.Size(125, 23);
            this.comboBoxBtn.TabIndex = 1;
            this.comboBoxBtn.Text = "ComboBox";
            this.comboBoxBtn.UseVisualStyleBackColor = true;
            this.comboBoxBtn.Click += new System.EventHandler(this.comboBoxBtn_Click);
            // 
            // checkBoxBtn
            // 
            this.checkBoxBtn.Location = new System.Drawing.Point(50, 125);
            this.checkBoxBtn.Name = "checkBoxBtn";
            this.checkBoxBtn.Size = new System.Drawing.Size(125, 23);
            this.checkBoxBtn.TabIndex = 2;
            this.checkBoxBtn.Text = "CheckBox";
            this.checkBoxBtn.UseVisualStyleBackColor = true;
            this.checkBoxBtn.Click += new System.EventHandler(this.checkBoxBtn_Click);
            // 
            // maskedTextBoxBtn
            // 
            this.maskedTextBoxBtn.Location = new System.Drawing.Point(50, 168);
            this.maskedTextBoxBtn.Name = "maskedTextBoxBtn";
            this.maskedTextBoxBtn.Size = new System.Drawing.Size(125, 23);
            this.maskedTextBoxBtn.TabIndex = 3;
            this.maskedTextBoxBtn.Text = "MaskedTextBox";
            this.maskedTextBoxBtn.UseVisualStyleBackColor = true;
            this.maskedTextBoxBtn.Click += new System.EventHandler(this.maskedTextBoxBtn_Click);
            // 
            // pictureBoxBtn
            // 
            this.pictureBoxBtn.Location = new System.Drawing.Point(50, 214);
            this.pictureBoxBtn.Name = "pictureBoxBtn";
            this.pictureBoxBtn.Size = new System.Drawing.Size(125, 23);
            this.pictureBoxBtn.TabIndex = 4;
            this.pictureBoxBtn.Text = "PictureBox";
            this.pictureBoxBtn.UseVisualStyleBackColor = true;
            this.pictureBoxBtn.Click += new System.EventHandler(this.pictureBoxBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 428);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxBtn);
            this.Controls.Add(this.maskedTextBoxBtn);
            this.Controls.Add(this.checkBoxBtn);
            this.Controls.Add(this.comboBoxBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button comboBoxBtn;
        private System.Windows.Forms.Button checkBoxBtn;
        private System.Windows.Forms.Button maskedTextBoxBtn;
        private System.Windows.Forms.Button pictureBoxBtn;
    }
}