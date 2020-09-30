using System;

namespace compareLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation program!!");


          LineClass line1 = new LineClass(5, 25, 10, 6);
            double lengthOne = line1.find_length();
           
            LineClass line2 = new LineClass(5, 25, 10, 6);
            double lengthTwo = line2.find_length();


            int compareResult = lengthOne.CompareTo(lengthTwo);

                if(compareResult==1)
            {
                Console.WriteLine("First line is greater than the second line");
            }
            else if(compareResult==-1)
            {
                Console.WriteLine("First line is lesser than the second line");
            }
            else
            {
                Console.WriteLine("Both the lines are equal");
            }

        }
    }
}
