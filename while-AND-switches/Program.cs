#define XFrench
using System;

namespace while_AND_switches
{
    class Program
    {
        static void Main(string[] args)
        {
            // Preprocessor directives & ternary operators start

            var yes = "yes";
            var no = "No";
#if French
            yes = "Oui";
            no = "Non";
#endif
            var boolean = false;

            Console.WriteLine($"Boolean is {boolean}; text is {(boolean ? yes : no)}");

            //end


            //var x = -1; // -1 has the number 1 show up in the console since it's counting up from 2
            //while (x <= 25)
            //{
            //    var cubed = x * x * x;
            //    //Console.Write($"{cubed} ");
            //    //Console.Write($"{x * x * x} ");

            //    x += 2;
            //    Console.Write($"{x} ");
            //}


            //var y = 1;
            //while ( y <= 30) {
            //    y++;
            //    if (y % 3 == 0 && y % 5 == 0) {
            //        Console.WriteLine("FIZZBUZZ");
            //    }
            //    else if (y % 3 == 0) {
            //        Console.WriteLine("FIZZ");
            //    }
            //    else if(y % 5 == 0) {
            //        Console.WriteLine("BUZZ");
            //    }
            //    else if(y % 3 != 0 && y % 5 != 0) {
            //        Console.WriteLine(y);
            //    }
                
            //    //break;
            //};

        }
    }
}
