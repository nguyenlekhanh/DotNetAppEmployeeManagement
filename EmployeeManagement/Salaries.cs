﻿using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EmployeeManagement
{
    public partial class Salaries : Form
    {
        MEmployee mEmployee;
        MSalary mSalary;

        public Salaries()
        {
            InitializeComponent();
            mEmployee = new MEmployee();
            mSalary = new MSalary();
            ShowSalaries();
            GetEmployees();
            SetMyCustomFormat();
        }

        private void ResetField()
        {
            Key = 0;
            DaysTb.Text = "";
            AmountTb.Text = "";

        }

        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string.
            PeriodDtp.Format = DateTimePickerFormat.Custom;
            PeriodDtp.CustomFormat = "MM/yyyy";
        }

        private void ShowSalaries()
        {
            SalaryList.DataSource = mSalary.GetSalaries();
        }

        private void GetEmployees()
        {
            DataTable employeeDt = mEmployee.GetEmployees();
            DataRow newRow = employeeDt.NewRow();
            newRow[0] = "-1";
            newRow[1] = "Select one";
            employeeDt.Rows.InsertAt(newRow, 0);

            EmpCb.DisplayMember = employeeDt.Columns["EmpName"].ToString();
            EmpCb.ValueMember = employeeDt.Columns["EmpId"].ToString();
            EmpCb.DataSource = employeeDt;
        }

        int DSal = 0;
        string Period = "";
        private void GetSalary()
        {
            DataTable employeeDt = mEmployee.GetEmployees();
            foreach(DataRow dr in employeeDt.Rows)
            {
                DSal = Convert.ToInt32(dr["EmpSal"].ToString());
            }

            if(DaysTb.Text == "")
            {
                AmountTb.Text = "$" + (d * DSal);
            } else if(Convert.ToInt32(DaysTb.Text) > 31)
            {
                MessageBox.Show("Days Can not be Greater Than 31");
            } else
            {
                d = Convert.ToInt32(DaysTb.Text);
                AmountTb.Text = "$" + (d * DSal);
            }
        }

        int d = 1;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(EmpCb.SelectedIndex <= 0 || DaysTb.Text == "" || PeriodDtp.Text == "")
            {
                MessageBox.Show("Missing Data!!!");
            } else
            {
                Period = PeriodDtp.Value.Date.Month.ToString() + "-" + PeriodDtp.Value.Date.Year.ToString();
                int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                int Days = Convert.ToInt32(DaysTb.Text);
                
                if (mSalary.AddSalary(Convert.ToInt32(EmpCb.SelectedValue), Days, Period, Amount, DateTime.Today.Date.ToString()))
                {
                    ShowSalaries();
                    MessageBox.Show("Salary Added!!");
                    ResetField();
                }
                else
                {
                    MessageBox.Show("Something went wrong!!");
                }
            }
        }

        private void EmpCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetSalary();
        }

        private void DaysTb_TextChanged(object sender, EventArgs e)
        {

            //if (Convert.ToInt32(DaysTb.Text) >= 300 && Convert.ToInt32(DaysTb.Text) <= 470)
            //{
            //    DaysTb.Text = string.Empty;
            //}
        }

        private void DaysTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                
            }
        }


        private void DaysTb_Validated(object sender, EventArgs e)
        {
            if(DaysTb.TextLength > 0) {
                try
                {
                    int number = Convert.ToInt32(DaysTb.Text);
                    if (number < 0)
                    {
                        DaysTb.Text = "0";
                    }
                    else if (number > 31)
                    {
                        DaysTb.Text = "31";
                    }
                }
                catch (Exception ex)
                {
                    DaysTb.Text = "0";
                }
                GetSalary();
            }
        }

        int Key = 0;
        private void SalaryList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = SalaryList.Rows[e.RowIndex];
            //MessageBox.Show(SalaryList.Rows.Count.ToString() + ":" + e.RowIndex.ToString());
            int SalaryListCount = SalaryList.Rows.Count - 1;
            if (SalaryListCount > 0 && e.RowIndex+1 <= SalaryListCount) { 
                EmpCb.SelectedValue = Convert.ToString(row.Cells[1].Value);
                DaysTb.Text = Convert.ToString(row.Cells[2].Value);
                PeriodDtp.Text = Convert.ToString(row.Cells[3].Value);
                AmountTb.Text = Convert.ToString(row.Cells[4].Value);
                if (EmpCb.Text == "")
                {
                    Key = 0;
                }
                else
                {
                    Key = Convert.ToInt32(row.Cells[0].Value);
                }
                
            } else
            {
                Key = 0;
            }
        }

        private void SalaryList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this salary?", "Title", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (EmpCb.Text == "")
                        {
                            MessageBox.Show("Missing Data!!");
                        }
                        else
                        {
                            if (mSalary.DeleteSalary(Key))
                            {
                                ShowSalaries();
                                MessageBox.Show("Salary Deleted!!");
                                ResetField();
                            }
                            else
                            {
                                MessageBox.Show("Something went wrong!!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {


            try
            {
                if (EmpCb.SelectedIndex <= 0 || DaysTb.Text == "" || PeriodDtp.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    Period = PeriodDtp.Value.Date.Month.ToString() + "-" + PeriodDtp.Value.Date.Year.ToString();
                    int Amount = DSal * Convert.ToInt32(DaysTb.Text);
                    int Days = Convert.ToInt32(DaysTb.Text);

                    if (mSalary.UpdateSalary(Days, Period, Amount, DateTime.Today.Date.ToString(), Key))
                    {
                        ShowSalaries();
                        MessageBox.Show("Salary Updated!!");
                        ResetField();
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong!!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmployeeLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void DepartmentLbl_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }
    }
}
