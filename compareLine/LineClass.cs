using System;
using System.Collections.Generic;
using System.Text;

namespace compareLine
{
    class LineClass
    {
        //variables
        int xCoOrdinate1, yCoOrdinate1;
        int xCoOrdinate2, yCoOrdinate2;

        /// <summary>
        /// Initializes a new instance of the <see cref="LineClass"/> class.
        /// </summary>
        /// <param name="xCoOrdinate1">The x co ordinate1.</param>
        /// <param name="yCoOrdinate1">The y co ordinate1.</param>
        /// <param name="XCoOrdinate2">The x co ordinate2.</param>
        /// <param name="yCoOrdinate2">The y co ordinate2.</param>
        public LineClass(int xCoOrdinate1, int yCoOrdinate1, int XCoOrdinate2, int yCoOrdinate2)
        {
            this.xCoOrdinate1 = xCoOrdinate1;
            this.xCoOrdinate2 = XCoOrdinate2;
            this.yCoOrdinate1 = yCoOrdinate1;
            this.yCoOrdinate2 = yCoOrdinate2;
            Console.WriteLine("Line : " + "(" + xCoOrdinate1 + "," + yCoOrdinate1 + ") , (" + xCoOrdinate2 + "," + yCoOrdinate2 + ")");
        }

        /// <summary>
        /// Finds the length.
        /// </summary>
        /// <returns></returns>
        public double find_length()
        {
           
            double length = Math.Sqrt(Math.Pow(xCoOrdinate2 - xCoOrdinate1, 2) + Math.Pow(yCoOrdinate2 - yCoOrdinate1, 2) * 1.0);
            return Math.Round(length, 2);
        }
    }
}
