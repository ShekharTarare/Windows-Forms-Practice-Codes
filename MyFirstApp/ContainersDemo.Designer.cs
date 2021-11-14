
namespace MyFirstApp
{
    partial class ContainersDemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.createUserTab = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.viewUserTab = new System.Windows.Forms.TabPage();
            this.updateUserTab = new System.Windows.Forms.TabPage();
            this.deleteUserTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.createUserTab.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 499);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.createUserTab);
            this.tabControl1.Controls.Add(this.viewUserTab);
            this.tabControl1.Controls.Add(this.updateUserTab);
            this.tabControl1.Controls.Add(this.deleteUserTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 499);
            this.tabControl1.TabIndex = 0;
            // 
            // createUserTab
            // 
            this.createUserTab.BackColor = System.Drawing.Color.Silver;
            this.createUserTab.Controls.Add(this.flowLayoutPanel1);
            this.createUserTab.Controls.Add(this.panel2);
            this.createUserTab.Location = new System.Drawing.Point(4, 22);
            this.createUserTab.Name = "createUserTab";
            this.createUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.createUserTab.Size = new System.Drawing.Size(753, 473);
            this.createUserTab.TabIndex = 0;
            this.createUserTab.Text = "Create User";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(747, 58);
            this.panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(747, 58);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Location = new System.Drawing.Point(561, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 52);
            this.button4.TabIndex = 3;
            this.button4.Text = "Four";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Location = new System.Drawing.Point(375, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Three";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(189, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Two";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "One";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // viewUserTab
            // 
            this.viewUserTab.BackColor = System.Drawing.Color.Gainsboro;
            this.viewUserTab.Location = new System.Drawing.Point(4, 22);
            this.viewUserTab.Name = "viewUserTab";
            this.viewUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.viewUserTab.Size = new System.Drawing.Size(753, 473);
            this.viewUserTab.TabIndex = 1;
            this.viewUserTab.Text = "View User";
            // 
            // updateUserTab
            // 
            this.updateUserTab.BackColor = System.Drawing.Color.DarkSalmon;
            this.updateUserTab.Location = new System.Drawing.Point(4, 22);
            this.updateUserTab.Name = "updateUserTab";
            this.updateUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.updateUserTab.Size = new System.Drawing.Size(753, 473);
            this.updateUserTab.TabIndex = 2;
            this.updateUserTab.Text = "Update User";
            // 
            // deleteUserTab
            // 
            this.deleteUserTab.BackColor = System.Drawing.Color.Khaki;
            this.deleteUserTab.Location = new System.Drawing.Point(4, 22);
            this.deleteUserTab.Name = "deleteUserTab";
            this.deleteUserTab.Size = new System.Drawing.Size(753, 473);
            this.deleteUserTab.TabIndex = 3;
            this.deleteUserTab.Text = "Delete User";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 61);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(369, 409);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 55);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // ContainersDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 499);
            this.Controls.Add(this.panel1);
            this.Name = "ContainersDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Containers Demo";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.createUserTab.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage createUserTab;
        private System.Windows.Forms.TabPage viewUserTab;
        private System.Windows.Forms.TabPage updateUserTab;
        private System.Windows.Forms.TabPage deleteUserTab;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}