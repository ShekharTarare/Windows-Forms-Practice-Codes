
namespace MyFirstApp
{
    partial class MaskedTextBoxDemo
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
            this.phoneMTB = new System.Windows.Forms.MaskedTextBox();
            this.phoneLab = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneMTB
            // 
            this.phoneMTB.Location = new System.Drawing.Point(79, 77);
            this.phoneMTB.Mask = "0000-0000";
            this.phoneMTB.Name = "phoneMTB";
            this.phoneMTB.Size = new System.Drawing.Size(80, 23);
            this.phoneMTB.TabIndex = 0;
            // 
            // phoneLab
            // 
            this.phoneLab.AutoSize = true;
            this.phoneLab.Location = new System.Drawing.Point(76, 57);
            this.phoneLab.Name = "phoneLab";
            this.phoneLab.Size = new System.Drawing.Size(54, 17);
            this.phoneLab.TabIndex = 1;
            this.phoneLab.Text = "Phone";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(81, 122);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(13, 13);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // MaskedTextBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 201);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.phoneLab);
            this.Controls.Add(this.phoneMTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MaskedTextBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masked TextBox Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaskedTextBoxDemo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox phoneMTB;
        private System.Windows.Forms.Label phoneLab;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button backBtn;
    }
}