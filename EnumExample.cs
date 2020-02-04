using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class EnumExample
    {
        enum EmpType 
            {
            Manager = 1 , // = 1
            Grunt, // = 2
            Contractor, // = 3
            VicePresident // = 4
            }
        public void _NewMethodToDealWithEnumTypes()
        {
            Console.WriteLine("");
            Console.WriteLine(" **** START EnumExample method _NewMethodToDealWithEnumTypes **** ");
            EmpType emp = EmpType.Contractor;
            string yourPosition= "";
            Console.WriteLine("Type you position 1 = Manager , 2 = Grunt, 3 = Contractor, 4 = VicePresident");
            yourPosition = Console.ReadLine();
           switch (yourPosition)
            {
                case  "1":
                    emp = EmpType.Manager;
                    AskForBonus(emp);
                        break;
                case "2":
                    emp = EmpType.Grunt;
                    AskForBonus(emp);
                    break;
                case "3":
                    emp = EmpType.Contractor;
                    AskForBonus(emp);
                    break;
                case "4":
                    emp = EmpType.VicePresident;
                    AskForBonus(emp);
                    break;

                default:
                    Console.WriteLine("No options for you");
                    break;
            }

            Console.WriteLine(" **** END EnumExample method _NewMethodToDealWithEnumTypes **** ");
            Console.WriteLine("");
        }

       static void AskForBonus(EmpType e)
        {
            switch(e)
            {
                case EmpType.Manager:
                    Console.WriteLine("How about stock options  instead");
                    Console.WriteLine("The type is : {0}", e.GetType().Name);
                    break;
                case EmpType.Grunt:
                    Console.WriteLine("You have got to be kidding...");
                    Console.WriteLine("The type is : {0}", e.GetType().Name);
                    break;
                case EmpType.Contractor:
                    Console.WriteLine("You already get enough cash...");
                    Console.WriteLine("The type is : {0}", e.GetType().Name);
                    break;
                case EmpType.VicePresident:
                    Console.WriteLine("Very good Sir...");
                    Console.WriteLine("The type is : {0}", e.GetType().Name);
                    break;
            }
        }


    }
}
