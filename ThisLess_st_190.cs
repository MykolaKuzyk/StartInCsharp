using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStartCsharp
{
   class ThisLess_st_190
    {
        public string name;
        public int driverIntensity;
        public ThisLess_st_190() { }
        public ThisLess_st_190(int intensity): this(intensity,"")
        { 
        
        
        }  // we can use .this declaration in order to referance constructor on another constructor //
        public ThisLess_st_190(int intensity = 0, string lol = "") // the original construktor and using of non requieres urguments

        {
            Console.WriteLine("origimal ctor");

        }
        public void SetDriverName(string name)
        {
            Console.WriteLine("START ThisLess_st_190 method SetDriverName");
            Console.WriteLine("");
            this.name = name;
            Console.WriteLine("Rider name is: {0}", name);

            Console.WriteLine("END ThisLess_st_190 method SetDriverName");
            Console.WriteLine("");
        }

        public void _ThisIsExample()
        {
            Console.WriteLine("START ThisLess_st_190 method _ThisIsExample");
            Console.WriteLine("");

            ThisLess_st_190 c = new ThisLess_st_190 { };
            c.SetDriverName(this.name);
            Console.WriteLine("END ThisLess_st_190 method _ThisIsExample");
            Console.WriteLine("");
        }
    }
}
