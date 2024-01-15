using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TASK 1
            // this program is called calculatron :)

            // This ask user to enter a low and a high number
            int lowNumber;
            Console.Write("Please Enter a Low number : ");
            lowNumber = Convert.ToInt32(Console.ReadLine());
            // This then calculate the difference between the numbers
            int highNumber;
            Console.Write("Please Enter a High number : ");
            highNumber = Convert.ToInt32(Console.ReadLine());
            // this calculates the difference 
            int difference = highNumber - lowNumber;
            Console.Write("Thank you for using calculatron, here is the difference : " + difference);
            Console.ReadLine();


            //TASK 2
            // this program is called loopetron

            double postivelownumber;
            Console.Write("Enter a postive low number : ");
            postivelownumber = Convert.ToDouble(Console.ReadLine());
            while (postivelownumber < 0)
            {
                Console.Write("Enter a postive low number : ");
                postivelownumber = Convert.ToDouble(Console.ReadLine());
            }

            double highnumber;
            Console.Write("Enter a high number greather than low number : ");
            highnumber = Convert.ToDouble(Console.ReadLine());
            while (highnumber < postivelownumber)
            {
                Console.Write("Enter a high number greather than low number : ");
                highnumber = Convert.ToDouble(Console.ReadLine());

            }

            //TASK 3
            //this program is called bumblebee


            int[] numarray = new int[difference + 1];
            for (int i = 0; i < numarray.Length; i++)
            {
                numarray[i] = i;
                Console.WriteLine(numarray[i]);
            }



        }
    }
}