﻿using System;

namespace compareLine
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparision Computation program!!");

          LineClass line1 = getLineClassObject();
            double lengthOne = line1.find_length();
            Console.WriteLine("Length of the line1 is : " + lengthOne);
            LineClass line2 = getLineClassObject();
            double lengthTwo = line2.find_length();
            Console.WriteLine("Length of the line2 is : " + lengthTwo);

            int compareResult = compareLines(lengthOne,lengthTwo);

            if (compareResult == 1)
            {
                Console.WriteLine("First line is greater than the second line");
            }
            else if (compareResult == -1)
            {
                Console.WriteLine("First line is lesser than the second line");
            }
            else
            {
                Console.WriteLine("Both the lines are equal");
            }

        }

        /// <summary>
        /// Gets the line class object.
        /// </summary>
        /// <returns></returns>
        public static LineClass getLineClassObject()
        {
            Random random = new Random();
            int x1 = random.Next(-100, 100);
            int y1 = random.Next(-100, 100);
            int x2 = random.Next(-100, 100);
            int y2 = random.Next(-100, 100);
            LineClass obj = new LineClass(x1, y1, x2, y2);
            return obj;

        }

        /// <summary>
        /// Compares the lines.
        /// </summary>
        /// <param name="length1">The length1.</param>
        /// <param name="length2">The length2.</param>
        /// <returns></returns>
        public static int compareLines(double length1,double length2)
        {
            return length1.CompareTo(length2);
        }
    }
}
