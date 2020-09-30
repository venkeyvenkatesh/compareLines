using System;

namespace compareLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation program!!");


          LineClass line1 = new LineClass(11, 25, 10, 6);
           Console.WriteLine("The length of the line is : "+line1.find_length());

        }
    }
}
