
namespace MyFirstApp
{
    partial class RichTextBoxExample
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
            this.components = new System.ComponentModel.Container();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.textLab = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.filenameLab = new System.Windows.Forms.Label();
            this.filenameTextBox = new System.Windows.Forms.TextBox();
            this.myToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Location = new System.Drawing.Point(23, 43);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(604, 140);
            this.textRichTextBox.TabIndex = 0;
            this.textRichTextBox.Text = "";
            this.myToolTip.SetToolTip(this.textRichTextBox, "Please enter any text");
            // 
            // textLab
            // 
            this.textLab.AutoSize = true;
            this.textLab.Location = new System.Drawing.Point(20, 23);
            this.textLab.Name = "textLab";
            this.textLab.Size = new System.Drawing.Size(100, 17);
            this.textLab.TabIndex = 1;
            this.textLab.Text = "Enter your text";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(23, 254);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "SAVE";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(552, 254);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 3;
            this.openBtn.Text = "OPEN";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // filenameLab
            // 
            this.filenameLab.AutoSize = true;
            this.filenameLab.Location = new System.Drawing.Point(23, 190);
            this.filenameLab.Name = "filenameLab";
            this.filenameLab.Size = new System.Drawing.Size(110, 17);
            this.filenameLab.TabIndex = 4;
            this.filenameLab.Text = "Give a Filename";
            // 
            // filenameTextBox
            // 
            this.filenameTextBox.Location = new System.Drawing.Point(23, 211);
            this.filenameTextBox.Name = "filenameTextBox";
            this.filenameTextBox.Size = new System.Drawing.Size(604, 23);
            this.filenameTextBox.TabIndex = 5;
            this.myToolTip.SetToolTip(this.filenameTextBox, "Please give any filename");
            // 
            // myToolTip
            // 
            this.myToolTip.AutomaticDelay = 0;
            this.myToolTip.AutoPopDelay = 5000;
            this.myToolTip.InitialDelay = 500;
            this.myToolTip.IsBalloon = true;
            this.myToolTip.ReshowDelay = 100;
            this.myToolTip.ShowAlways = true;
            this.myToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.myToolTip.ToolTipTitle = "Info";
            // 
            // RichTextBoxExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 301);
            this.Controls.Add(this.filenameTextBox);
            this.Controls.Add(this.filenameLab);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.textLab);
            this.Controls.Add(this.textRichTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RichTextBoxExample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rich TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.Label textLab;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Label filenameLab;
        private System.Windows.Forms.TextBox filenameTextBox;
        private System.Windows.Forms.ToolTip myToolTip;
    }
}