using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagement.Model
{
    class MSalary : BaseModel
    {
        string table = "SalaryTbl";

        public DataTable GetSalaries()
        {
            string Query = "Select * from " + table;
            return base.GetData(Query);
        }

        public bool AddSalary(int employeeID, int Days, string Period, int Amount, string payDate)
        {
            try
            {
                string Query = "insert into " + table + " values({0}, {1}, '{2}', {3}, '{4}')";
                Query = string.Format(Query, employeeID, Days, Period, Amount, payDate);
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                //TODO Log to Database
                //MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool UpdateSalary(int Days, string Period, int Amount, string payDate, int key)
        {
            try
            {
                string Query = "Update " + table + " set Attendance = {0}, Period = '{1}', Amount = {2}, PayDate= '{3}' where SCode = {4}";
                Query = string.Format(Query, Days, Period, Amount, payDate, key);
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                //TODO Log to Database
                //MessageBox.Show(ex.ToString());
                return false;
            }
        }
        

        public bool DeleteSalary(int key)
        {
            try
            {
                string Query = "Delete from " + table + " where SCode = " + key;
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
    }
}
