using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_And_Methods_Assigment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 10;
            int numberTwo = -15;
            string numberThree = "26";

            int opositeNumberOne = MathF.findOposite(numberOne);
            Console.WriteLine("The oposite number to the first number is {0}", opositeNumberOne);

            int opositeNumberTwo = MathF.findOposite(numberTwo);
            Console.WriteLine("The oposite number to the second number is {0}", opositeNumberTwo);

            int opositeNumberSum = MathF.findOposite(numberOne, numberTwo);
            Console.WriteLine("The oposite number to the sum of the two numbers is {0}", opositeNumberSum);

            int opositeNumberThree = MathF.findOposite(numberThree);
            Console.WriteLine("The oposite number to the third number (string) is {0}", opositeNumberThree);


            Console.ReadLine();
        }
    }
}
