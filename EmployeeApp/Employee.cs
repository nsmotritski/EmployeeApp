using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    abstract partial class Employee

    {
        //  Поля  данных,
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string empSSN;

        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }

        public float Рау
        {
            get { return currPay; }
            set { currPay =  value; }
        }

        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }

        public string SocialSecurityNumber
        {
            get { return empSSN; }
        }

        public string Name
        {
            get { return empName; }
            set
            {
                if (value.Length > 15)
                    Console.WriteLine("Error!  Name  must  be  less  than  16  characters!");
                else
                    empName = value;
            }
        }

        public Employee() { }

        //public Employee(string name, int id, float pay) : this(name, 0, id, pay) { }

        public Employee(string name, int age, int id, float pay, string SSN)
        {
            //  Уже  лучше!  Используйте  свойства  для  установки  данных  класса.
            //  Это  сократит  количество  дублированных  проверок  ошибок.
            Name = name;
            Age = age;
            ID = id;
            currPay = pay;
            empSSN = SSN;
        }

        //  Можно  было  бы  добавить  дополнительные  биэнес-правила  для  установки
        //  этих  свойств,  но  в  данном  примере  в  этом  нет  необходимости.
        public virtual void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public virtual void DisplayStats()
        {
            Console.WriteLine("Name:  {0}", empName);
            Console.WriteLine("ID:  {0}", empID);
            Console.WriteLine("Age:  {0}", empAge);
            Console.WriteLine("Pay:  {0}", currPay);
        }
    }
}



