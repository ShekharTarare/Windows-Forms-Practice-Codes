
namespace MyFirstApp
{
    partial class MyBrowser
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.myWebBrowser = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.addressTB = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.goBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.homePageLL = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homePageLL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 29);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(712, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MyBrowser";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.myWebBrowser);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 476);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 24);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(712, 10);
            this.panel6.TabIndex = 2;
            // 
            // myWebBrowser
            // 
            this.myWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myWebBrowser.Location = new System.Drawing.Point(0, 34);
            this.myWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.myWebBrowser.Name = "myWebBrowser";
            this.myWebBrowser.Size = new System.Drawing.Size(712, 442);
            this.myWebBrowser.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 24);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.addressTB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(205, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 24);
            this.panel4.TabIndex = 0;
            // 
            // addressTB
            // 
            this.addressTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTB.Location = new System.Drawing.Point(0, 0);
            this.addressTB.Name = "addressTB";
            this.addressTB.Size = new System.Drawing.Size(374, 23);
            this.addressTB.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.forwardBtn);
            this.panel5.Controls.Add(this.backBtn);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(205, 24);
            this.panel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter Address";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.goBtn);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(579, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(133, 24);
            this.panel7.TabIndex = 3;
            // 
            // goBtn
            // 
            this.goBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.goBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBtn.Location = new System.Drawing.Point(0, 0);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(133, 24);
            this.goBtn.TabIndex = 0;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.backBtn.Location = new System.Drawing.Point(0, 0);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(56, 24);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "<<";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.forwardBtn.Location = new System.Drawing.Point(56, 0);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(51, 24);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.Text = ">>";
            this.forwardBtn.UseVisualStyleBackColor = true;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // homePageLL
            // 
            this.homePageLL.Dock = System.Windows.Forms.DockStyle.Right;
            this.homePageLL.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.homePageLL.Location = new System.Drawing.Point(602, 0);
            this.homePageLL.Name = "homePageLL";
            this.homePageLL.Size = new System.Drawing.Size(110, 29);
            this.homePageLL.TabIndex = 1;
            this.homePageLL.TabStop = true;
            this.homePageLL.Text = "Home Page";
            this.homePageLL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homePageLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homePageLL_LinkClicked);
            // 
            // MyBrowser
            // 
            this.AcceptButton = this.goBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBrowser";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.WebBrowser myWebBrowser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox addressTB;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.LinkLabel homePageLL;
    }
}