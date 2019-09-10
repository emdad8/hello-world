using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessModel
{
    abstract class Payroll
    {

       public abstract double CalculateMonthlySalary();

        public abstract int NoOfNonWorkingDays();



    }
}
