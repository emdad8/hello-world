using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Employee
    {

        public Employee(int empId,string firstName, string lastName, int deptId, string desgn,string dept,string mob,string addr,string natn)
        {
            this.EmployeeId = empId;
            this.DepartmentId = deptId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Designation = desgn;
            this.Department = dept;
            this.Mobile = mob;
            this.Address = addr;
            this.Nationality = natn;
        }

        public int EmployeeId { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public string Nationality { get; set; }

        //employeePhoto
        //employeeDOB
        //bloodgroup
        //employee NID
        //employee TIN
        

        private double GetNumberOfHoursWorked() {
            throw new NotImplementedException();
        }

        private double CommissionRate() {
            throw new NotImplementedException();
        }

        // calculateHolidays


    }
}
