using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitializerProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //  a) On  running  the  program  use  a  loop  to  print  the  numbers  on  one  line separated by a space, ie 15 68 4 19 99 52 53 36 74 1 85
            //intArray variable holds the integer array values
            int[] intArray = { 15, 68, 4, 19, 99, 52, 53, 36, 74, 1, 85 };

            Console.WriteLine("Displaying each value with space on the same line");
            //foreach loops through the array(intArray) and displays each integer values
            foreach (var item in intArray)
            {
                //Write methods displays each integer value on the same line.
                //using string interpolation, $"{item} " puts a space after each value in the array
                Console.Write($"{item} ");
            }

            Console.WriteLine(); //writes an empty line space

            // b)Modify the program so that it first prints to screen the even numbers on one line, followed by the odd numbers on the next line, i.e 
            //68 4 52 36 74
            //15 19 99 53 1 85

            Console.WriteLine("Displaying even numbers");
            foreach (var item in intArray)
            {
                //if statement uses the modulus opreator(%) to check
                //if any value divided by 2 and the remain is zero is add even number
                if (item % 2 == 0)
                {
                    Console.Write($"{item} ");
                } 
            }

            Console.WriteLine();

            Console.WriteLine("Displaying odd numbers");
            foreach (var item in intArray)
            {
                //if statement uses the modulus opreator(%) to check
                //if any value divided by 2 and the remain is not zero is an odd number
                if (item % 2 != 0)
                {
                    Console.Write($"{item} ");
                }
            }

            Console.ReadKey();
        }
    }
}
