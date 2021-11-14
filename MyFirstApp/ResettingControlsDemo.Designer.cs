
namespace MyFirstApp
{
    partial class ResettingControlsDemo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.skillsLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.csharpCheckBox = new System.Windows.Forms.CheckBox();
            this.sqlCheckBox = new System.Windows.Forms.CheckBox();
            this.maleRadioButton = new System.Windows.Forms.RadioButton();
            this.femaleRadioButton = new System.Windows.Forms.RadioButton();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.resetBtn);
            this.panel1.Controls.Add(this.femaleRadioButton);
            this.panel1.Controls.Add(this.maleRadioButton);
            this.panel1.Controls.Add(this.sqlCheckBox);
            this.panel1.Controls.Add(this.csharpCheckBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.skillsLabel);
            this.panel1.Controls.Add(this.statusComboBox);
            this.panel1.Controls.Add(this.statusLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 300);
            this.panel1.TabIndex = 0;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 49);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(228, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 89);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(48, 17);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Status";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.statusComboBox.Location = new System.Drawing.Point(16, 110);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(228, 24);
            this.statusComboBox.TabIndex = 3;
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.Location = new System.Drawing.Point(13, 161);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(40, 17);
            this.skillsLabel.TabIndex = 4;
            this.skillsLabel.Text = "Skills";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // csharpCheckBox
            // 
            this.csharpCheckBox.AutoSize = true;
            this.csharpCheckBox.Location = new System.Drawing.Point(13, 182);
            this.csharpCheckBox.Name = "csharpCheckBox";
            this.csharpCheckBox.Size = new System.Drawing.Size(44, 21);
            this.csharpCheckBox.TabIndex = 6;
            this.csharpCheckBox.Text = "C#";
            this.csharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // sqlCheckBox
            // 
            this.sqlCheckBox.AutoSize = true;
            this.sqlCheckBox.Location = new System.Drawing.Point(128, 182);
            this.sqlCheckBox.Name = "sqlCheckBox";
            this.sqlCheckBox.Size = new System.Drawing.Size(55, 21);
            this.sqlCheckBox.TabIndex = 7;
            this.sqlCheckBox.Text = "SQL";
            this.sqlCheckBox.UseVisualStyleBackColor = true;
            // 
            // maleRadioButton
            // 
            this.maleRadioButton.AutoSize = true;
            this.maleRadioButton.Location = new System.Drawing.Point(13, 251);
            this.maleRadioButton.Name = "maleRadioButton";
            this.maleRadioButton.Size = new System.Drawing.Size(56, 21);
            this.maleRadioButton.TabIndex = 8;
            this.maleRadioButton.TabStop = true;
            this.maleRadioButton.Text = "Male";
            this.maleRadioButton.UseVisualStyleBackColor = true;
            // 
            // femaleRadioButton
            // 
            this.femaleRadioButton.AutoSize = true;
            this.femaleRadioButton.Location = new System.Drawing.Point(128, 251);
            this.femaleRadioButton.Name = "femaleRadioButton";
            this.femaleRadioButton.Size = new System.Drawing.Size(72, 21);
            this.femaleRadioButton.TabIndex = 9;
            this.femaleRadioButton.TabStop = true;
            this.femaleRadioButton.Text = "Female";
            this.femaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // resetBtn
            // 
            this.resetBtn.FlatAppearance.BorderSize = 2;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Location = new System.Drawing.Point(169, 9);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 32);
            this.resetBtn.TabIndex = 10;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // ResettingControlsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 304);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResettingControlsDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resetting Controls Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton femaleRadioButton;
        private System.Windows.Forms.RadioButton maleRadioButton;
        private System.Windows.Forms.CheckBox sqlCheckBox;
        private System.Windows.Forms.CheckBox csharpCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label skillsLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button resetBtn;
    }
}