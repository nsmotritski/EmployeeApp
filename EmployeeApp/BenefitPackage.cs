using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    abstract partial class Employee
    {
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }

            //  Предположим,  что  есть  другие  члены,  представляющие
            //  медицинские/стоматологические  программы  и  т.д.
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
