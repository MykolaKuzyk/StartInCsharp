using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;  // for BItIntiger variable 0 BitInteger  can`t be changed 
using System.Collections.Generic;

namespace MyStartCsharp
{
    class _Program
    {
        static int forOutRef = 0;
        static int forOutRef1 = 0;
        static int forOutRef1Ans = 0;
        static double doub1 = 10.23, doub2 = 9.87, doub3 = 7.54232;
        static public BigInteger newBit = BigInteger.Parse("9999999999999999999999999999999999999"); // we use Parse 
        static OutAndRef newOutRefObj = new OutAndRef { };
        static Interpolated newInterpolatedobj = new Interpolated { };
        static NamedParams_st_153 newNamedParams = new NamedParams_st_153 { };
        static MethodOverloading_st_155 newMethodOverloading = new MethodOverloading_st_155 { };
        static Array_st159 newArray_St159 = new Array_st159 { };
        static bool st153Bool = false;
        static EnumExample newEnumExample = new EnumExample { };
        static Struct_st168 newStruckt = new Struct_st168 { };
        static StructRef_st172 structRef_St172 = new StructRef_st172(10, 10);
        static Types_With_Ref_Teypes_st173 newtypes_With_Ref_Teypes_St173 = new Types_With_Ref_Teypes_st173("New info from static");
        static Person_st175 person_St175 = new Person_st175 { };
        static Person_st175 Person_ST175_1 = new Person_st175 ("Robot", 45 );
        static Car_Less_St_181 car_Less_St_181 = new Car_Less_St_181 { };
        static ThisLess_st_190 thisLess_St_190 = new ThisLess_st_190 { };
        static ThisLess_st_190 thisLess_St_190_1 = new ThisLess_st_190 ( lol:"Nome" ); // using of non requries parameters ****:
        static StaticDataAndMembers staticData = new StaticDataAndMembers(50);
        static StaticDataAndMembers staticData3 = new StaticDataAndMembers(10000.85);



        static void Main(string[] args)
        {
            // START StaticDataAndMembers
            Console.WriteLine(" START WITH StaticDataAndMembers ");
            StaticDataAndMembers.GetInterestRate();
            // try to change static value 
           
            StaticDataAndMembers.SetInterestRate(8); 
            
            StaticDataAndMembers.GetInterestRate();
            // chek value one more time 
        


            Console.WriteLine(" END WITH StaticDataAndMembers ");
            // END StaticDataAndMembers

            //START ThisLess_st_190
            thisLess_St_190.name = "Jhon";
            thisLess_St_190.SetDriverName(thisLess_St_190.name);
            thisLess_St_190._ThisIsExample();


            //END ThisLess_st_190

            //START Car_Less_St_181
            car_Less_St_181.petName = "FORD 17H";
            for (int i = 0; i < 10; i++)
            {
                car_Less_St_181.SpeedUp(10);
                car_Less_St_181.PrintSpeed();
            }
            // END Car_Less_St_181

            // START PERSON REF
            person_St175._SendAPersonByValue1(ref person_St175);
            Person_ST175_1._SendAPersonByValue1(ref Person_ST175_1);
      
            // END PERSON REF

            // START Struct 
            newtypes_With_Ref_Teypes_St173._newTypeWithRefTest();
            newStruckt._newMethodStruct();
            structRef_St172.incriment();
            structRef_St172.Display();
            // END Struct

            // START EnumExample
            newEnumExample._NewMethodToDealWithEnumTypes();
            // END EnumExample

            // START Array_st159
            newArray_St159._newArray();
            newArray_St159._newMultiArray();
            newArray_St159._newJaggedMultiDimensionalArrey();
            // END Array_st159
            // START MethodOverloading_st_155
            newMethodOverloading.Add(4343443,44343443);
                // END MethodOverloading_st_155
                // START NamedParams_st_153
            newNamedParams._DisplayMessage(message:"WOW very fancy indeed!", textcolor:ConsoleColor.DarkCyan, backgroundColor:ConsoleColor.DarkBlue);
            newNamedParams._St153_For_Test(i: 6, a: 6,st153Bool );
                // END NamedParams_st_153
                // Start new lesson about Out and Ref
            newOutRefObj._NewRefExample(ref forOutRef, forOutRef1);
            Console.WriteLine(" **** This is value for Out Ref after function use step 3: {0} **** ", forOutRef);
            Console.WriteLine(" **** This is value for Out Ref1 after function use step 3: {0} **** ", forOutRef1);
            newOutRefObj._AddOUR(forOutRef,forOutRef1,out forOutRef1Ans);
            Console.WriteLine(" **** This is value for Out Ref1 after function use step 3 method AddOUR: {0} **** ", forOutRef1Ans);
            newOutRefObj._ParamsMethod(doub1,doub2,doub3);
            Console.WriteLine();
                // END new lesson about Out and Ref
                // START Interpolated 
            newInterpolatedobj._NewInterpolated();
                // END Interpolated 
            Cheked newCheked = new Cheked { };
            newCheked.ProcessBytes();
            TypeConversions newType = new TypeConversions { };
            newType._explicitvalue();
                // new lesson String Builder 
            SBuilder lineToWork = new SBuilder { };
            lineToWork._buildString();
            Console.ReadLine();
                //
                /*  ----- Old Lessons -----
                // new string class 
            string_class_less newSTR = new string_class_less { };
            newSTR._newStrig();
            newSTR._newSecondStrig();
                //
            Console.WriteLine("There is your BitIntiger : {0}",newBit);
            Console.WriteLine("Is newBit is : {0} ", newBit.IsEven); // newBit is equal 
            Console.WriteLine("Is newBit Power Of Two : {0} ", newBit.IsPowerOfTwo);
            Console.ReadLine();
            System.Windows.MessageBox.Show("LOOOOOL it works");
            Console.ReadLine();
            CharFunction();
            ParseFormString();
            Console.ReadLine();
            DataTimeFormat();
            Console.ReadLine();
        }
                static void CharFunction()
        {
            Console.WriteLine("=> char type functionality");
            char myChar = 'a';
            Console.WriteLine("char.IsDigit('a') : {0}", char.IsDigit(myChar));
            Console.WriteLine("char.IsLetter ('a'): {0}", char.IsLetter(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 5): {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine("char.IsWhiteSpace('Hello there', 6): {0}", char.IsWhiteSpace(myChar));
            Console.WriteLine("char.IsPunctuation('?'): {0}", char.IsPunctuation('?'));
            Console.ReadLine();
        }
        static void ParseFormString ()
         {
            Console.WriteLine("=> Data type parsing: ");
            bool b = bool.Parse("True");
            Console.WriteLine("Value of b : {0}", b );
            double d = double.Parse("99,884");

            Console.WriteLine("Value of d is : {0}", d);
        }
            static void DataTimeFormat()
        {
            DateTime dt = new DateTime(2020, 12, 12);
            Console.WriteLine("the day {0} of the week {1}", dt.Date, dt.DayOfWeek);
        */
        }

    }
}
