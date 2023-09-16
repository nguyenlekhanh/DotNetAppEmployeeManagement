namespace EmployeeManagement
{
    partial class Salaries
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.PeriodDtp = new System.Windows.Forms.DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EmpCb = new System.Windows.Forms.ComboBox();
            this.DaysTb = new System.Windows.Forms.TextBox();
            this.LogoutLbl = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.DepartmentLbl = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.EmployeeLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SalaryList = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.AmountTb = new System.Windows.Forms.TextBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.Teal;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(173, 496);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(125, 41);
            this.UpdateBtn.TabIndex = 41;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Teal;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(10, 496);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(125, 41);
            this.AddBtn.TabIndex = 40;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // PeriodDtp
            // 
            this.PeriodDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PeriodDtp.Location = new System.Drawing.Point(10, 377);
            this.PeriodDtp.Name = "PeriodDtp";
            this.PeriodDtp.Size = new System.Drawing.Size(288, 30);
            this.PeriodDtp.TabIndex = 38;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(120, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 681);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1144, 21);
            this.panel2.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(8, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 31;
            this.label6.Text = "Period";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(8, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 24);
            this.label4.TabIndex = 29;
            this.label4.Text = "Days Attended";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(7, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "Employee";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(447, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System Version 1.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.ForeColor = System.Drawing.Color.Teal;
            this.label7.Location = new System.Drawing.Point(9, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 32;
            this.label7.Text = "Salary Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 100);
            this.panel1.TabIndex = 24;
            // 
            // EmpCb
            // 
            this.EmpCb.FormattingEnabled = true;
            this.EmpCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.EmpCb.Location = new System.Drawing.Point(12, 235);
            this.EmpCb.Name = "EmpCb";
            this.EmpCb.Size = new System.Drawing.Size(288, 33);
            this.EmpCb.TabIndex = 42;
            this.EmpCb.SelectedIndexChanged += new System.EventHandler(this.EmpCb_SelectedIndexChanged);
            // 
            // DaysTb
            // 
            this.DaysTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DaysTb.Location = new System.Drawing.Point(11, 306);
            this.DaysTb.Name = "DaysTb";
            this.DaysTb.Size = new System.Drawing.Size(288, 30);
            this.DaysTb.TabIndex = 43;
            this.DaysTb.TextChanged += new System.EventHandler(this.DaysTb_TextChanged);
            this.DaysTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysTb_KeyPress);
            this.DaysTb.Validated += new System.EventHandler(this.DaysTb_Validated);
            // 
            // LogoutLbl
            // 
            this.LogoutLbl.AutoSize = true;
            this.LogoutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.LogoutLbl.ForeColor = System.Drawing.Color.Teal;
            this.LogoutLbl.Location = new System.Drawing.Point(973, 116);
            this.LogoutLbl.Name = "LogoutLbl";
            this.LogoutLbl.Size = new System.Drawing.Size(68, 24);
            this.LogoutLbl.TabIndex = 52;
            this.LogoutLbl.Text = "Logout";
            this.LogoutLbl.Click += new System.EventHandler(this.LogoutLbl_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(923, 109);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 35);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.SalaryLbl.ForeColor = System.Drawing.Color.Teal;
            this.SalaryLbl.Location = new System.Drawing.Point(823, 116);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(61, 24);
            this.SalaryLbl.TabIndex = 50;
            this.SalaryLbl.Text = "Salary";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(773, 109);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 49;
            this.pictureBox4.TabStop = false;
            // 
            // DepartmentLbl
            // 
            this.DepartmentLbl.AutoSize = true;
            this.DepartmentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.DepartmentLbl.ForeColor = System.Drawing.Color.Teal;
            this.DepartmentLbl.Location = new System.Drawing.Point(624, 116);
            this.DepartmentLbl.Name = "DepartmentLbl";
            this.DepartmentLbl.Size = new System.Drawing.Size(116, 24);
            this.DepartmentLbl.TabIndex = 48;
            this.DepartmentLbl.Text = "Departments";
            this.DepartmentLbl.Click += new System.EventHandler(this.DepartmentLbl_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(574, 109);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // EmployeeLbl
            // 
            this.EmployeeLbl.AutoSize = true;
            this.EmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.EmployeeLbl.ForeColor = System.Drawing.Color.Teal;
            this.EmployeeLbl.Location = new System.Drawing.Point(445, 116);
            this.EmployeeLbl.Name = "EmployeeLbl";
            this.EmployeeLbl.Size = new System.Drawing.Size(96, 24);
            this.EmployeeLbl.TabIndex = 46;
            this.EmployeeLbl.Text = "Employee";
            this.EmployeeLbl.Click += new System.EventHandler(this.EmployeeLbl_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(395, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.ForeColor = System.Drawing.Color.Teal;
            this.label5.Location = new System.Drawing.Point(629, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Manage Salary";
            // 
            // SalaryList
            // 
            this.SalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalaryList.Location = new System.Drawing.Point(330, 235);
            this.SalaryList.Name = "SalaryList";
            this.SalaryList.RowHeadersWidth = 51;
            this.SalaryList.RowTemplate.Height = 24;
            this.SalaryList.Size = new System.Drawing.Size(785, 382);
            this.SalaryList.TabIndex = 53;
            this.SalaryList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalaryList_CellClick);
            this.SalaryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalaryList_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label13.ForeColor = System.Drawing.Color.Teal;
            this.label13.Location = new System.Drawing.Point(651, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 24);
            this.label13.TabIndex = 56;
            this.label13.Text = "Salary List";
            // 
            // AmountTb
            // 
            this.AmountTb.Enabled = false;
            this.AmountTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AmountTb.Location = new System.Drawing.Point(10, 447);
            this.AmountTb.Name = "AmountTb";
            this.AmountTb.Size = new System.Drawing.Size(288, 30);
            this.AmountTb.TabIndex = 57;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Teal;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(87, 543);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(125, 41);
            this.DeleteBtn.TabIndex = 58;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // Salaries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1144, 702);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AmountTb);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SalaryList);
            this.Controls.Add(this.LogoutLbl);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.SalaryLbl);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.DepartmentLbl);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.EmployeeLbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DaysTb);
            this.Controls.Add(this.EmpCb);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.PeriodDtp);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Salaries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker PeriodDtp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EmpCb;
        private System.Windows.Forms.TextBox DaysTb;
        private System.Windows.Forms.Label LogoutLbl;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label DepartmentLbl;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label EmployeeLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView SalaryList;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox AmountTb;
        private System.Windows.Forms.Button DeleteBtn;
    }
}