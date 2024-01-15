using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start part 1
            #region Intro
            Console.Write("Hello\t");
            Console.WriteLine("my name is Kevin");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            #endregion Intro
            //End part 1

            #region Name 
            //Start part 2
            Console.WriteLine("What is name?");
            String name = Console.ReadLine();
            Console.WriteLine(name + " " + "welcome to our lesson");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            //End part 2
            #endregion Name

            #region Ascii
            //Start part 3
            Console.WriteLine("What number?");
            int asciicode = Console.Read();
            Console.WriteLine(asciicode);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            //End part 2
            #endregion Ascii

            #region Explicit Casting using cast operator
            //Start part 3
            Console.WriteLine("This is explicit casting using cast operator");
            double x = 24;
            int y;
            y=(int)x;   
            Console.WriteLine("Double number " + x);
            Console.WriteLine("cast operator used on integer number equates to " +y);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Note that double is bigger than integer so we need to explicitly(ourselves) code the change otherwise we run into an error");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            //End part 2
            #endregion Explicit Casting using cast operator

            #region Explicit Casting using convert class
            //Start part 3
            Console.WriteLine("This is explicit casting using the convert class");
            double a = 24;
            int b;
            b = Convert.ToInt32(a);
            Console.WriteLine("Double number " + a);
            Console.WriteLine("cast operator used on integer number equates to " + b);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Note that double is bigger than integer so we need to explicitly(ourselves) code the change otherwise we run into an error");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            //End part 2
            #endregion Explicit Casting using convert class


            #region Explicit Casting using Tostring()
            // \All variable types can be converted into strings
            //Start part 3
            Console.WriteLine("This is explicit casting using the Tostring");
            byte u= 12;
        
            int z = 4;
          
            string s = u.ToString()+" "+z.ToString();
            Console.WriteLine("Random number " + s);
            Console.WriteLine("cast operator used on integer number equates to " + s);
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Note that we can convert any variable to a string using the ToString() convert class.");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("|Conclusion|");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");



            //End part 2
            #endregion Explicit Casting using Tostring()

            Console.ReadKey();

        }
    }
}
