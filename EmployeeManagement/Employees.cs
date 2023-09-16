using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement
{
    public partial class Employees : Form
    {
        MEmployee mEmployee;
        MDepartment mDepartment;
        public Employees()
        {
            InitializeComponent();
            mEmployee = new MEmployee();
            mDepartment = new MDepartment();
            ShowEmployees();
            GetDepartments();
        }

        private void ShowEmployees()
        {
            EmployeeList.DataSource = mEmployee.GetEmployees();
        }

        private void GetDepartments()
        {
            DataTable departmentDt = mDepartment.GetDepartments();
            DepCb.DisplayMember = departmentDt.Columns["DepName"].ToString();
            DepCb.ValueMember = departmentDt.Columns["DepId"].ToString();
            DepCb.DataSource = departmentDt;
        }

        private void ResetField()
        {
            EmpNameTb.Text = "";
            DailySalTb.Text = "";
            GenCb.SelectedIndex = -1;
            Key = 0;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 ||
                    DepCb.SelectedIndex == -1 || DailySalTb.Text == ""
                    )
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBDtp.Value.ToString();
                    string JDate = JDateDtp.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    if (mEmployee.AddEmployee(Name, Gender, Dep, DOB, JDate, Salary))
                    {
                        
                        ShowEmployees();
                        MessageBox.Show("Employee Added!!");
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

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 ||
                    DepCb.SelectedIndex == -1 || DailySalTb.Text == ""
                    )
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBDtp.Value.ToString();
                    string JDate = JDateDtp.Value.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);

                    if (mEmployee.UpdateEmployee(Key, Name, Gender, Dep, DOB, JDate, Salary))
                    {
                        ShowEmployees();
                        MessageBox.Show("Employee Updated!!");
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

        
        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int Key = 0;
        private void EmployeeList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = EmployeeList.Rows[e.RowIndex];
            EmpNameTb.Text = Convert.ToString(row.Cells[1].Value);
            GenCb.Text = Convert.ToString(row.Cells[2].Value);
            DepCb.SelectedValue = row.Cells[3].Value;
            DOBDtp.Text = Convert.ToString(row.Cells[4].Value);
            JDateDtp.Text = Convert.ToString(row.Cells[5].Value);
            DailySalTb.Text = Convert.ToString(row.Cells[6].Value);
            if (EmpNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key > 0)
            {
                DialogResult dr = MessageBox.Show("Are you sure to delete this employee?", "Title", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (EmpNameTb.Text == "")
                        {
                            MessageBox.Show("Missing Data!!");
                        }
                        else
                        {
                            if (mEmployee.DeleteEmployee(Key))
                            {
                                ShowEmployees();
                                MessageBox.Show("Employee Deleted!!");
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

        private void DepartmentLbl_Click(object sender, EventArgs e)
        {
            Departments Obj = new Departments();
            Obj.Show();
            this.Hide();
        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
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
