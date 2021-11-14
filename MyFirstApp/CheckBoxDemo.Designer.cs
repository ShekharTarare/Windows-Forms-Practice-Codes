
namespace MyFirstApp
{
    partial class CheckBoxDemo
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
            this.servicesLabel = new System.Windows.Forms.Label();
            this.internetCB = new System.Windows.Forms.CheckBox();
            this.swimmingCB = new System.Windows.Forms.CheckBox();
            this.geyserCB = new System.Windows.Forms.CheckBox();
            this.lunchCB = new System.Windows.Forms.CheckBox();
            this.chargesLabel = new System.Windows.Forms.Label();
            this.totChaLab = new System.Windows.Forms.Label();
            this.totalChargesLab = new System.Windows.Forms.Label();
            this.chargesLB = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // servicesLabel
            // 
            this.servicesLabel.AutoSize = true;
            this.servicesLabel.Location = new System.Drawing.Point(12, 45);
            this.servicesLabel.Name = "servicesLabel";
            this.servicesLabel.Size = new System.Drawing.Size(70, 17);
            this.servicesLabel.TabIndex = 0;
            this.servicesLabel.Text = "Services";
            // 
            // internetCB
            // 
            this.internetCB.AutoSize = true;
            this.internetCB.Location = new System.Drawing.Point(15, 66);
            this.internetCB.Name = "internetCB";
            this.internetCB.Size = new System.Drawing.Size(174, 21);
            this.internetCB.TabIndex = 1;
            this.internetCB.Text = "Internet        Rs.500";
            this.internetCB.UseVisualStyleBackColor = true;
            this.internetCB.CheckedChanged += new System.EventHandler(this.internetCB_CheckedChanged);
            // 
            // swimmingCB
            // 
            this.swimmingCB.AutoSize = true;
            this.swimmingCB.Location = new System.Drawing.Point(15, 94);
            this.swimmingCB.Name = "swimmingCB";
            this.swimmingCB.Size = new System.Drawing.Size(173, 21);
            this.swimmingCB.TabIndex = 2;
            this.swimmingCB.Text = "Swimming     Rs.450";
            this.swimmingCB.UseVisualStyleBackColor = true;
            this.swimmingCB.CheckedChanged += new System.EventHandler(this.swimmingCB_CheckedChanged);
            // 
            // geyserCB
            // 
            this.geyserCB.AutoSize = true;
            this.geyserCB.Location = new System.Drawing.Point(15, 122);
            this.geyserCB.Name = "geyserCB";
            this.geyserCB.Size = new System.Drawing.Size(170, 21);
            this.geyserCB.TabIndex = 3;
            this.geyserCB.Text = "Geyser        Rs.200";
            this.geyserCB.UseVisualStyleBackColor = true;
            this.geyserCB.CheckedChanged += new System.EventHandler(this.geyserCB_CheckedChanged);
            // 
            // lunchCB
            // 
            this.lunchCB.AutoSize = true;
            this.lunchCB.Location = new System.Drawing.Point(15, 150);
            this.lunchCB.Name = "lunchCB";
            this.lunchCB.Size = new System.Drawing.Size(177, 21);
            this.lunchCB.TabIndex = 4;
            this.lunchCB.Text = "Lunch          Rs. 200";
            this.lunchCB.UseVisualStyleBackColor = true;
            this.lunchCB.CheckedChanged += new System.EventHandler(this.lunchCB_CheckedChanged);
            // 
            // chargesLabel
            // 
            this.chargesLabel.AutoSize = true;
            this.chargesLabel.Location = new System.Drawing.Point(208, 45);
            this.chargesLabel.Name = "chargesLabel";
            this.chargesLabel.Size = new System.Drawing.Size(68, 17);
            this.chargesLabel.TabIndex = 6;
            this.chargesLabel.Text = "Charges";
            // 
            // totChaLab
            // 
            this.totChaLab.AutoSize = true;
            this.totChaLab.Location = new System.Drawing.Point(12, 218);
            this.totChaLab.Name = "totChaLab";
            this.totChaLab.Size = new System.Drawing.Size(120, 17);
            this.totChaLab.TabIndex = 7;
            this.totChaLab.Text = "Total Charges: ";
            // 
            // totalChargesLab
            // 
            this.totalChargesLab.AutoSize = true;
            this.totalChargesLab.Location = new System.Drawing.Point(133, 218);
            this.totalChargesLab.Name = "totalChargesLab";
            this.totalChargesLab.Size = new System.Drawing.Size(41, 17);
            this.totalChargesLab.TabIndex = 8;
            this.totalChargesLab.Text = "Rs.0";
            // 
            // chargesLB
            // 
            this.chargesLB.FormattingEnabled = true;
            this.chargesLB.ItemHeight = 16;
            this.chargesLB.Location = new System.Drawing.Point(211, 66);
            this.chargesLB.Name = "chargesLB";
            this.chargesLB.Size = new System.Drawing.Size(166, 116);
            this.chargesLB.TabIndex = 9;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(15, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 10;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // CheckBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 260);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.chargesLB);
            this.Controls.Add(this.totalChargesLab);
            this.Controls.Add(this.totChaLab);
            this.Controls.Add(this.chargesLabel);
            this.Controls.Add(this.lunchCB);
            this.Controls.Add(this.geyserCB);
            this.Controls.Add(this.swimmingCB);
            this.Controls.Add(this.internetCB);
            this.Controls.Add(this.servicesLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CheckBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckBoxDemo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label servicesLabel;
        private System.Windows.Forms.CheckBox internetCB;
        private System.Windows.Forms.CheckBox swimmingCB;
        private System.Windows.Forms.CheckBox geyserCB;
        private System.Windows.Forms.CheckBox lunchCB;
        private System.Windows.Forms.Label chargesLabel;
        private System.Windows.Forms.Label totChaLab;
        private System.Windows.Forms.Label totalChargesLab;
        private System.Windows.Forms.ListBox chargesLB;
        private System.Windows.Forms.Button backBtn;
    }
}