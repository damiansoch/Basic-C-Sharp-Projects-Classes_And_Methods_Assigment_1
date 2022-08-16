using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_And_Methods_Assigment_1
{
    public class MathF
    {
        public static int findOposite(int number)
        //the methid will take the user number and will return the opposite number
        {
            int opositeNumber = number * (-1);
            return opositeNumber;
        }

        public static int findOposite(int numberOne, int numberTwo)
        // the method will add two numbers and then return the oposite number
        {
            int opositeNumber = (numberOne + numberTwo) * (-1);
            return opositeNumber;
        }

        public static int findOposite(string numberString)
        //the methid will take the user number and will return the opposite number
        {
            int numberInt = Convert.ToInt32(numberString);
            int opositeNumber = numberInt * (-1);
            return opositeNumber;
        }

    }
}
