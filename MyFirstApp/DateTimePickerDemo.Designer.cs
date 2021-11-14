
namespace MyFirstApp
{
    partial class DateTimePickerDemo
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
            this.datetimeLab = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.showBtn = new System.Windows.Forms.Button();
            this.showHereLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // datetimeLab
            // 
            this.datetimeLab.AutoSize = true;
            this.datetimeLab.Location = new System.Drawing.Point(30, 41);
            this.datetimeLab.Name = "datetimeLab";
            this.datetimeLab.Size = new System.Drawing.Size(101, 17);
            this.datetimeLab.TabIndex = 0;
            this.datetimeLab.Text = "Choose Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd-MMM-yyyy";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(33, 61);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.ShowCheckBox = true;
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 1;
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(73, 101);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(117, 23);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show Date";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // showHereLab
            // 
            this.showHereLab.AutoSize = true;
            this.showHereLab.Location = new System.Drawing.Point(30, 137);
            this.showHereLab.Name = "showHereLab";
            this.showHereLab.Size = new System.Drawing.Size(0, 17);
            this.showHereLab.TabIndex = 3;
            // 
            // DateTimePickerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 193);
            this.Controls.Add(this.showHereLab);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.datetimeLab);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "DateTimePickerDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DateTimePickerDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label datetimeLab;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Label showHereLab;
    }
}