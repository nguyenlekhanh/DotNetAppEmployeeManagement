using EmployeeManagement.Model;
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
        }

        private void ResetField()
        {
            
        }

        private void ShowSalaries()
        {
            SalaryList.DataSource = mSalary.GetSalaries();
        }

        private void GetEmployees()
        {
            DataTable employeeDt = mEmployee.GetEmployees();
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
            if(EmpCb.SelectedIndex == -1 || DaysTb.Text == "" || PeriodDtp.Text == "")
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
    }
}
