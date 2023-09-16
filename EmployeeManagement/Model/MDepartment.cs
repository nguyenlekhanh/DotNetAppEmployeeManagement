using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement
{
    class MDepartment : BaseModel
    {
        string table = "DepartmentTbl";

        public DataTable GetDepartments()
        {
            string Query = "Select * from " + table;

            return base.GetData(Query);
        }

        public bool AddDepartment(string departmentName)
        {
            try { 
                string Query = "insert into " + table + " values('{0}')";
                Query = string.Format(Query, departmentName);
                base.SetData(Query);
                return true;
            } catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateDepartment(string departmentName, int key)
        {
            try
            {
                string Query = "Update " + table + " set DepName = '{0}' where DepId = {1}";
                Query = string.Format(Query, departmentName, key);
                base.SetData(Query);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteDepartment(int key)
        {
            try
            {
                string Query = "Delete from " + table + " where DepId = " + key;
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
