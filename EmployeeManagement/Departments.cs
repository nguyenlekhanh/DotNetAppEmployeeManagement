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
    public partial class Departments : Form
    {
        MDepartment mDepartment;
        public Departments()
        {
            InitializeComponent();
            mDepartment = new MDepartment();
            ShowDepartments();
        }

        private void ShowDepartments()
        {
            DepList.DataSource = mDepartment.GetDepartments();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if(DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                } else
                {
                    string Dep = DepNameTb.Text;
                    if(mDepartment.AddDepartment(DepNameTb.Text))
                    {
                        ShowDepartments();
                        MessageBox.Show("Deparment Added!!");
                        DepNameTb.Text = "";
                    } else
                    {
                        MessageBox.Show("Something went wrong!!");
                    }
                    
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        int Key = 0;
        private void DepList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = DepList.Rows[e.RowIndex];
            DepNameTb.Text = Convert.ToString(row.Cells[1].Value);
            if (DepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(row.Cells[0].Value);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DepNameTb.Text == "")
                {
                    MessageBox.Show("Missing Data!!");
                }
                else
                {
                    string Dep = DepNameTb.Text;
                   
                    if (mDepartment.UpdateDepartment(Dep, Key))
                    {
                        Key = 0;
                        ShowDepartments();
                        MessageBox.Show("Deparment Updated!!");
                        DepNameTb.Text = "";
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

        private void DeleteTbl_Click(object sender, EventArgs e)
        {
            if(Key > 0) { 
                DialogResult dr = MessageBox.Show("Are you sure to delete this employee?", "Title", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        if (DepNameTb.Text == "")
                        {
                            MessageBox.Show("Missing Data!!");
                        }
                        else
                        {
                            if (mDepartment.DeleteDepartment(Key))
                            {
                                Key = 0;
                                ShowDepartments();
                                MessageBox.Show("Deparment Deleted!!");
                                DepNameTb.Text = "";
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

        private void LogoutLbl_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();
        }

        private void EmpLbl_Click(object sender, EventArgs e)
        {
            Employees Obj = new Employees();
            Obj.Show();
            this.Hide();
        }

        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SalaryLbl_Click(object sender, EventArgs e)
        {
            Salaries Obj = new Salaries();
            Obj.Show();
            this.Hide();
        }
    }
}
