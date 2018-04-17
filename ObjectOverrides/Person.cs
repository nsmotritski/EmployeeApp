using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    //  Помните:  Person  расширяет  Object.
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }

        public Person(string fName, string lName, int personAge)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
        }
        public Person() { }
        //  Возвратить  хеш-код  на  основе  значения  ToString()  объекта  Person.
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        public override string ToString()
        {
            string myState;
            myState = string.Format("[First  Name:  {0};  Last  Name:  {1};  Age:  {2}]",
            FirstName, LastName, Age);
            return myState;
        }

        public override bool Equals(object obj)
        {
            //  Больше  нет  необходимости  приводить  obj  к  типу  Person,
            //  поскольку  у  всех  имеется  метод  ToString().
            return obj.ToString() == this.ToString();
        }
    }
}
