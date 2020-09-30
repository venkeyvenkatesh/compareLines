using System;

namespace compareLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation program!!");


          LineClass line1 = new LineClass(11, 25, 10, 6);
            double lengthOne = line1.find_length();
           
            LineClass line2 = new LineClass(21, 25, 10, 6);
            double lengthTwo = line2.find_length();
          
                if(lengthOne.Equals(lengthTwo))
            {
                Console.WriteLine("Both the lines are equal");
            }
            else
            {
                Console.WriteLine("Both the lines are not equal");
            }

        }
    }
}
