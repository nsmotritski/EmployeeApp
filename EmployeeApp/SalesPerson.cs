using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class SalesPerson : Employee

    {
        public int SalesNumber { get; set; }

        //default constructor
        public SalesPerson() { }

        //  В  качестве  общего  правила,  все  подклассы  должны  явно  вызывать
        //  соответствующий  конструктор  базового  класса.
        public SalesPerson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) 
            : base(fullName, age, empID, currPay, ssn)
        {
            //  Это  касается  нас!
            SalesNumber = numbOfSales;
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("Number  of  sales:  {0}", SalesNumber);
        }

        public sealed override void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
        }
    }
}
