using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    

    class Interpolated
    {
        public void _NewInterpolated() // in order to use your names for vsriables in write line you need place $ brfore "" then you can write yout names 
        {
            var inputName = "name";
            var inputAge = "";
            Console.WriteLine(" **** Start Lesson Interpolated mathod: _NewInterpolated  **** ");
            Console.WriteLine($"Step 1 Your name is: {inputName} your age is {inputAge}");
            Console.WriteLine("Now type your real name: ");
            inputName = Console.ReadLine();
            Console.WriteLine("Now type your age: ");
            inputAge = Console.ReadLine();
            Console.WriteLine($"Step 2 Your name is: {inputName} your age is {inputAge}");
            Console.WriteLine(" **** END Lesson Interpolated mathod: _NewInterpolated  **** ");
        }             
    }
}
