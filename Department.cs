using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    public class Department
    {

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public List<Employee> Employees { get; set; }

        public Department(int Id, string dName)
        {
            this.DepartmentId = Id;
            this.DepartmentName = dName;
            this.Employees = new List<Employee>();
        }


    }
}
