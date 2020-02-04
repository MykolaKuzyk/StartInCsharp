using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
    class Car_Less_St_181
    {
       
        // class constructor 1
        public Car_Less_St_181()
        {
            petName = "NISSAN";
            currSpeed = 45;
        }
        // class constructor 2
        public Car_Less_St_181(string pn, int crspd)
        {
            petName = pn;
            currSpeed = crspd;
        }
        // class constructor 3
        public Car_Less_St_181(string pn)
        {
            petName = pn;
           
        }

        public string petName;
        public int currSpeed;
        public void PrintSpeed()
        {
           
            Console.WriteLine("{0} is going {1} MPH", petName, currSpeed);

        }
        public void SpeedUp(int delta)
        {
            currSpeed += delta;
        }
    }
}
