using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;
using System.Windows.Forms;

namespace EmployeeManagement.Model
{
    class MEmployee : BaseModel
    {
        string table = "EmployeeTbl";

        public DataTable GetEmployees()
        {
            string Query = "Select * from " + table;
            return base.GetData(Query);
        }

        public bool AddEmployee(string Name, string Gender, int Dep, string DOB, string JDate, int Salary)
        {
            try
            {
                string Query = "insert into " + table + " values('{0}', '{1}', {2}, '{3}', '{4}', {5})";
                Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateEmployee(int key, string Name, string Gender, int Dep, string DOB, string JDate, int Salary)
        {
            try
            {
                string Query = "Update " + table + " set EmpName = '{0}', EmpGen = '{1}', EmpDep = '{2}', EmpDOB= '{3}', EmpJDate = '{4}', EmpSal = '{6}' where EmpId = {6}";
                Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, key);
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
        
        public bool DeleteEmployee(int key)
        {
            try
            {
                string Query = "Delete from " + table + " where EmpId = " + key;
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
