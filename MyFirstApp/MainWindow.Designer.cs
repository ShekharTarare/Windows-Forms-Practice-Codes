
namespace MyFirstApp
{
    partial class MainWindow
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
            this.numTxt1 = new System.Windows.Forms.TextBox();
            this.numLab1 = new System.Windows.Forms.Label();
            this.numLab2 = new System.Windows.Forms.Label();
            this.resLab = new System.Windows.Forms.Label();
            this.numTxt2 = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.outputLab = new System.Windows.Forms.Label();
            this.num1ErrorLab = new System.Windows.Forms.Label();
            this.num2ErrorLab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numTxt1
            // 
            this.numTxt1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTxt1.Location = new System.Drawing.Point(166, 119);
            this.numTxt1.MaxLength = 50;
            this.numTxt1.Name = "numTxt1";
            this.numTxt1.Size = new System.Drawing.Size(335, 29);
            this.numTxt1.TabIndex = 0;
            this.numTxt1.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // numLab1
            // 
            this.numLab1.AutoSize = true;
            this.numLab1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLab1.Location = new System.Drawing.Point(162, 95);
            this.numLab1.Name = "numLab1";
            this.numLab1.Size = new System.Drawing.Size(83, 21);
            this.numLab1.TabIndex = 1;
            this.numLab1.Text = "Number 1";
            this.numLab1.Click += new System.EventHandler(this.label1_Click);
            // 
            // numLab2
            // 
            this.numLab2.AutoSize = true;
            this.numLab2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLab2.Location = new System.Drawing.Point(162, 182);
            this.numLab2.Name = "numLab2";
            this.numLab2.Size = new System.Drawing.Size(85, 21);
            this.numLab2.TabIndex = 2;
            this.numLab2.Text = "Number 2";
            // 
            // resLab
            // 
            this.resLab.AutoSize = true;
            this.resLab.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLab.Location = new System.Drawing.Point(162, 332);
            this.resLab.Name = "resLab";
            this.resLab.Size = new System.Drawing.Size(66, 21);
            this.resLab.TabIndex = 3;
            this.resLab.Text = "Result: ";
            this.resLab.Click += new System.EventHandler(this.label2_Click);
            // 
            // numTxt2
            // 
            this.numTxt2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numTxt2.Location = new System.Drawing.Point(166, 206);
            this.numTxt2.MaxLength = 50;
            this.numTxt2.Name = "numTxt2";
            this.numTxt2.Size = new System.Drawing.Size(335, 29);
            this.numTxt2.TabIndex = 4;
            this.numTxt2.TextChanged += new System.EventHandler(this.numTxt2_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(278, 281);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(88, 27);
            this.addBtn.TabIndex = 6;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // outputLab
            // 
            this.outputLab.AutoSize = true;
            this.outputLab.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLab.Location = new System.Drawing.Point(233, 332);
            this.outputLab.Name = "outputLab";
            this.outputLab.Size = new System.Drawing.Size(0, 21);
            this.outputLab.TabIndex = 7;
            // 
            // num1ErrorLab
            // 
            this.num1ErrorLab.AutoSize = true;
            this.num1ErrorLab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1ErrorLab.ForeColor = System.Drawing.Color.Red;
            this.num1ErrorLab.Location = new System.Drawing.Point(166, 155);
            this.num1ErrorLab.Name = "num1ErrorLab";
            this.num1ErrorLab.Size = new System.Drawing.Size(0, 15);
            this.num1ErrorLab.TabIndex = 8;
            // 
            // num2ErrorLab
            // 
            this.num2ErrorLab.AutoSize = true;
            this.num2ErrorLab.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2ErrorLab.ForeColor = System.Drawing.Color.Red;
            this.num2ErrorLab.Location = new System.Drawing.Point(166, 238);
            this.num2ErrorLab.Name = "num2ErrorLab";
            this.num2ErrorLab.Size = new System.Drawing.Size(0, 15);
            this.num2ErrorLab.TabIndex = 9;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 409);
            this.Controls.Add(this.num2ErrorLab);
            this.Controls.Add(this.num1ErrorLab);
            this.Controls.Add(this.outputLab);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.numTxt2);
            this.Controls.Add(this.resLab);
            this.Controls.Add(this.numLab2);
            this.Controls.Add(this.numLab1);
            this.Controls.Add(this.numTxt1);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add two numbers";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numTxt1;
        private System.Windows.Forms.Label numLab1;
        private System.Windows.Forms.Label numLab2;
        private System.Windows.Forms.Label resLab;
        private System.Windows.Forms.TextBox numTxt2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label outputLab;
        private System.Windows.Forms.Label num1ErrorLab;
        private System.Windows.Forms.Label num2ErrorLab;
    }
}

