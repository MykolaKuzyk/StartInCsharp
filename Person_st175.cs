using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
  public class Person_st175
    {
        public string personName;
        public int personAge;
        public Person_st175(string name, int age)
        {
            personName = name;
            personAge = age;
        }

        public Person_st175() { }

        public void Display()
        {
            Console.WriteLine("Name: {0}, Age: {1}", personName ,personAge);
        }


        public void _SendAPersonByValue(Person_st175 p)
        {
            Console.WriteLine();
            Console.WriteLine(" **** START Person_st175 method _SendAPersonByValue ****  ");
            p.personAge = 88;
            p = new Person_st175("Nikki", 99);
            p.Display();
            Console.WriteLine(" **** END Person_st175 method _SendAPersonByValue ****  ");
            Console.WriteLine();
        }

        public void _SendAPersonByValue1(ref Person_st175 p)
        {
            Console.WriteLine();
            Console.WriteLine(" **** START Person_st175 method _SendAPersonByValue1 ****  ");
            p.personAge = 88;
            p = new Person_st175("Nikki", 999);
            p.Display();
            Console.WriteLine(" **** END Person_st175 method _SendAPersonByValue1 ****  ");
            Console.WriteLine();
        }

    }
}
