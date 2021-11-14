
namespace MyFirstApp
{
    partial class ComboBoxDemo
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
            this.countryLab = new System.Windows.Forms.Label();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.cityLab = new System.Windows.Forms.Label();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.resLab = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.addToListBtn = new System.Windows.Forms.Button();
            this.citiesListBox = new System.Windows.Forms.ListBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countryLab
            // 
            this.countryLab.AutoSize = true;
            this.countryLab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.countryLab.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLab.Location = new System.Drawing.Point(12, 24);
            this.countryLab.Name = "countryLab";
            this.countryLab.Size = new System.Drawing.Size(63, 19);
            this.countryLab.TabIndex = 0;
            this.countryLab.Text = "Country";
            // 
            // countryComboBox
            // 
            this.countryComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.countryComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.countryComboBox.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Items.AddRange(new object[] {
            "China",
            "India",
            "South Africa",
            "US",
            "West Indies"});
            this.countryComboBox.Location = new System.Drawing.Point(12, 46);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(244, 25);
            this.countryComboBox.Sorted = true;
            this.countryComboBox.TabIndex = 0;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cityLab
            // 
            this.cityLab.AutoSize = true;
            this.cityLab.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cityLab.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLab.Location = new System.Drawing.Point(12, 87);
            this.cityLab.Name = "cityLab";
            this.cityLab.Size = new System.Drawing.Size(35, 19);
            this.cityLab.TabIndex = 2;
            this.cityLab.Text = "City";
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(12, 109);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(244, 25);
            this.cityComboBox.Sorted = true;
            this.cityComboBox.TabIndex = 1;
            // 
            // resLab
            // 
            this.resLab.AutoSize = true;
            this.resLab.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resLab.Location = new System.Drawing.Point(12, 176);
            this.resLab.Name = "resLab";
            this.resLab.Size = new System.Drawing.Size(23, 19);
            this.resLab.TabIndex = 4;
            this.resLab.Text = "--";
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(181, 154);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(75, 23);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // addToListBtn
            // 
            this.addToListBtn.Font = new System.Drawing.Font("Segoe UI Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToListBtn.Location = new System.Drawing.Point(100, 154);
            this.addToListBtn.Name = "addToListBtn";
            this.addToListBtn.Size = new System.Drawing.Size(75, 23);
            this.addToListBtn.TabIndex = 5;
            this.addToListBtn.Text = "Add";
            this.addToListBtn.UseVisualStyleBackColor = true;
            this.addToListBtn.Click += new System.EventHandler(this.addToListBtn_Click);
            // 
            // citiesListBox
            // 
            this.citiesListBox.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citiesListBox.FormattingEnabled = true;
            this.citiesListBox.ItemHeight = 17;
            this.citiesListBox.Items.AddRange(new object[] {
            "India",
            "US",
            "China",
            "Sount Africa",
            "West Indies"});
            this.citiesListBox.Location = new System.Drawing.Point(12, 213);
            this.citiesListBox.Name = "citiesListBox";
            this.citiesListBox.Size = new System.Drawing.Size(244, 157);
            this.citiesListBox.TabIndex = 6;
            this.citiesListBox.Visible = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(181, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 23);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // ComboBoxDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 209);
            this.ControlBox = false;
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.citiesListBox);
            this.Controls.Add(this.addToListBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.resLab);
            this.Controls.Add(this.cityComboBox);
            this.Controls.Add(this.cityLab);
            this.Controls.Add(this.countryComboBox);
            this.Controls.Add(this.countryLab);
            this.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.MaximizeBox = false;
            this.Name = "ComboBoxDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBoxDemo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ComboBoxDemo_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label countryLab;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Label cityLab;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.Label resLab;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button addToListBtn;
        private System.Windows.Forms.ListBox citiesListBox;
        private System.Windows.Forms.Button backBtn;
    }
}