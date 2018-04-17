using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine("*****  The  Employee  Class  Hierarchy  *****\n");
            //  Лучшая  система  бонусов!
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            Console.WriteLine();
            SalesPerson fran = new SalesPerson("Fran", 43, 93, 3000, "932-32-3232", 31);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.ReadLine();
            

        }

        static void CastingExamples()
        {
            //  Manager  "является"  System.Object,  поэтому  можно  сохранять
            //  ссьшку  на  Manager  в  переменной  типа  object.
            object frank = new Manager("Frank  Zappa", 9, 3000, 40000, "111-11-1111", 5);
            GivePromotion((Manager)frank);
            //  Manager  также  "является"  Employee.
            Employee moonUnit = new Manager("MoonUnit  Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            //  PTSalesPerson  "является"  SalesPerson.
            SalesPerson jill = new PTSalesPerson("Jill", 834, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
        }

        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0}  was  promoted!", emp.Name);
            if (emp is SalesPerson)
            {
                Console.WriteLine("{0}  made  {1}  sale(s)!", emp.Name,
                ((SalesPerson)emp).SalesNumber);
                Console.WriteLine();
            }
            if (emp is Manager)
            {
                Console.WriteLine("{0}  had  {1}  stockoptions...", emp.Name,
                ((Manager)emp).StockOptions);
                Console.WriteLine();
            }
        }
    }
}
