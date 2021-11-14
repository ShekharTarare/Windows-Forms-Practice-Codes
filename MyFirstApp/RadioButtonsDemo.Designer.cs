
namespace MyFirstApp
{
    partial class RadioButtonsDemo
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.genderLlabel = new System.Windows.Forms.Label();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.showBtn = new System.Windows.Forms.Button();
            this.displayLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.englishRadioButton = new System.Windows.Forms.RadioButton();
            this.hindiRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 38);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(37, 58);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(220, 25);
            this.nameTextBox.TabIndex = 1;
            // 
            // genderLlabel
            // 
            this.genderLlabel.AutoSize = true;
            this.genderLlabel.Location = new System.Drawing.Point(34, 104);
            this.genderLlabel.Name = "genderLlabel";
            this.genderLlabel.Size = new System.Drawing.Size(52, 17);
            this.genderLlabel.TabIndex = 2;
            this.genderLlabel.Text = "Gender";
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(37, 124);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(56, 21);
            this.maleRadioButton.TabIndex = 3;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(150, 124);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(70, 21);
            this.femaleRadioButton.TabIndex = 4;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(37, 161);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(220, 23);
            this.showBtn.TabIndex = 5;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // displayLabel
            // 
            this.displayLabel.AutoSize = true;
            this.displayLabel.Location = new System.Drawing.Point(34, 212);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(60, 17);
            this.displayLabel.TabIndex = 6;
            this.displayLabel.Text = ".............";
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(37, 252);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(68, 17);
            this.languageLabel.TabIndex = 7;
            this.languageLabel.Text = "Language";
            // 
            // englishRadioButton
            // 
            this.englishRadioButton.AutoSize = true;
            this.englishRadioButton.Location = new System.Drawing.Point(10, 3);
            this.englishRadioButton.Name = "englishRadioButton";
            this.englishRadioButton.Size = new System.Drawing.Size(71, 21);
            this.englishRadioButton.TabIndex = 8;
            this.englishRadioButton.TabStop = true;
            this.englishRadioButton.Text = "English";
            this.englishRadioButton.UseVisualStyleBackColor = true;
            // 
            // hindiRadioButton
            // 
            this.hindiRadioButton.AutoSize = true;
            this.hindiRadioButton.Location = new System.Drawing.Point(123, 4);
            this.hindiRadioButton.Name = "hindiRadioButton";
            this.hindiRadioButton.Size = new System.Drawing.Size(60, 21);
            this.hindiRadioButton.TabIndex = 9;
            this.hindiRadioButton.TabStop = true;
            this.hindiRadioButton.Text = "Hindi";
            this.hindiRadioButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.englishRadioButton);
            this.panel1.Controls.Add(this.hindiRadioButton);
            this.panel1.Location = new System.Drawing.Point(27, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 28);
            this.panel1.TabIndex = 10;
            // 
            // RadioButtonsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.displayLabel);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.femaleRadioButton);
            this.Controls.Add(this.maleRadioButton);
            this.Controls.Add(this.genderLlabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "RadioButtonsDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radio Buttons Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label genderLlabel;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label displayLabel;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.RadioButton englishRadioButton;
        private System.Windows.Forms.RadioButton hindiRadioButton;
        private System.Windows.Forms.Panel panel1;
    }
}