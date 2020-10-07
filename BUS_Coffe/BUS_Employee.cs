using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Coffee;
using DTO_Coffee;
namespace BUS_Coffe
{
    public class BUS_Employee
    {
        //DAL_EmPloyee dalEmployee=new DAL_Employee();
        
        public BUS_Employee()
        {
          //  dalEmployee = new DAL_Employee;
        }
        public DTO_Employee GetEmpID(int id)
        {
            DTO_Employee dtoEmployee = new DTO_Employee();
            DataTable dtb = new DataTable();
            //dtb = dalEmployee.searchByID(id);
            foreach(DataRow dr in dtb.Rows)
            {
                dtoEmployee._Employee_ID = Int32.Parse(dr["EmployeeId"].ToString());
                dtoEmployee._Employee_Name =(dr["EmployeeName"].ToString());
                dtoEmployee._Employee_Phone = Int32.Parse(dr["EmployeePhone"].ToString());
                dtoEmployee._Employee_Gender = dr["EmployeeGender"].ToString();
                dtoEmployee._Employee_Address = dr["EmployeeAddress"].ToString();
                dtoEmployee._Employee_Email = dr["EmployeeEmail"].ToString();
                dtoEmployee._Employee_DateOfJoin = dr["EmployeeDateOfJoin"].ToString();
                dtoEmployee._Employee_Salary = Int32.Parse(dr["EmployeeSalary"].ToString());
            }
            return dtoEmployee;
        }
        public static bool IsDate(string date)
        {
            string[] elements = date.Split('/');
            if ((Convert.ToInt32(elements[0]) >= 1) && (Convert.ToInt32(elements[0]) <= 31) && (Convert.ToInt32(elements[1]) >= 1) && (Convert.ToInt32(elements[1]) <= 12) && (Convert.ToInt32(elements[2]) >= 1900))
                return true;
            else return false;
        }
        public static string ConvertDateTime(string date)
        {
            string[] elements = date.Split('/');
            string dt = string.Format("{0}/{1}/{2}", elements[0], elements[1], elements[2]);
            return dt;
        }
        public DataTable getAllCus()
        {
            DataTable dtb = new DataTable();
            //dtb = dalEmployee.getAllCus
            return dtb;
        }
        public bool AddEmployee(DTO_Employee emp)
        {
           // return dalEmployee.AddEmployee(emp);
        }
        public bool DeleteEmployee(DTO_Employee emp)
        {
           // return dalEmployee.DeleteEmployee(emp);
        }
        public bool EditEmployee(DTO_Employee emp)
        {
          //  return dalEmployee.EditEmployee(emp);
        }


    }
}
