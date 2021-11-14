
namespace UserManagement
{
    partial class Form1
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.viewAllUsersBtn = new System.Windows.Forms.Button();
            this.viewUserBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 326);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 326);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD Operations";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(504, 326);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.addUserBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewAllUsersBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewUserBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 326);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addUserBtn
            // 
            this.addUserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addUserBtn.FlatAppearance.BorderSize = 2;
            this.addUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserBtn.ForeColor = System.Drawing.Color.Green;
            this.addUserBtn.Location = new System.Drawing.Point(3, 3);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(246, 157);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // viewAllUsersBtn
            // 
            this.viewAllUsersBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewAllUsersBtn.FlatAppearance.BorderSize = 2;
            this.viewAllUsersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewAllUsersBtn.ForeColor = System.Drawing.Color.Green;
            this.viewAllUsersBtn.Location = new System.Drawing.Point(255, 3);
            this.viewAllUsersBtn.Name = "viewAllUsersBtn";
            this.viewAllUsersBtn.Size = new System.Drawing.Size(246, 157);
            this.viewAllUsersBtn.TabIndex = 1;
            this.viewAllUsersBtn.Text = "View All Users";
            this.viewAllUsersBtn.UseVisualStyleBackColor = true;
            this.viewAllUsersBtn.Click += new System.EventHandler(this.viewAllUsersBtn_Click);
            // 
            // viewUserBtn
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.viewUserBtn, 2);
            this.viewUserBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewUserBtn.FlatAppearance.BorderSize = 2;
            this.viewUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewUserBtn.ForeColor = System.Drawing.Color.Green;
            this.viewUserBtn.Location = new System.Drawing.Point(3, 166);
            this.viewUserBtn.Name = "viewUserBtn";
            this.viewUserBtn.Size = new System.Drawing.Size(498, 157);
            this.viewUserBtn.TabIndex = 2;
            this.viewUserBtn.Text = "View/Update/Delete User";
            this.viewUserBtn.UseVisualStyleBackColor = true;
            this.viewUserBtn.Click += new System.EventHandler(this.viewUserBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 326);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button viewAllUsersBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewUserBtn;
    }
}

