using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Fun  with  System.Object  *****\n");
            //  ПРИМЕЧАНИЕ:  эти  объекты  идентичны  для  проверки
            //  методов  Equals()  и  GetHashCode().
            Person pl = new Person("Homer", "Simpson", 50);
            Person p2 = new Person("Homer", "Simpson", 50);
            //  Получить  строковые  версии  объектов.
            Console.WriteLine("pl.ToString()  = {0}", pl.ToString());
            Console.WriteLine("p2.ToString()  = {0}", p2.ToString());
            //  Проверить  переопределенный  метод  Equals().
            Console.WriteLine("pl  =p2?:  {0}", pl.Equals(p2));
            //  Проверить  хеш-коды.
            Console.WriteLine("Samehashcodes?:  {0}", pl.GetHashCode() == p2.GetHashCode());
            Console.WriteLine();
            //  Изменить  возраст  p2  и  проверить  снова.
            p2.Age = 45;
            Console.WriteLine("pl.ToString()  = {0}", pl.ToString());
            Console.WriteLine("p2.ToString()  = {0}", p2.ToString());
            Console.WriteLine("pl  =p2?:  {0}", pl.Equals(p2));
            Console.WriteLine("Samehashcodes?:  {0}", pl.GetHashCode() == p2.GetHashCode());
            Console.ReadLine();
        }
    }
}
