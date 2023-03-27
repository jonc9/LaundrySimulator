using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;

namespace LaundrySimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Laundry Simulator";
            //want to have something that says "press any key to start"
            //maybe have some kind of logo? like ascii or something that pulls from a text file or however it'd work

            // might need this -> ? Console.ReadKey();

            Console.WriteLine("Make your selection:"); //maybe make a seperate class for this that displays the main menu
            Console.WriteLine("\n");
            Console.WriteLine("1.) Do Your Laundry");
            Console.WriteLine("2.) About/How to play");
            Console.WriteLine("3.) Exit");
            

        }
    }
}