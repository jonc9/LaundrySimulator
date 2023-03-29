using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;
using MenuGroup;

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

            Menus main = new Menus();
            Console.WriteLine(); // LEFT OFF HERE -- WORKING ON DISPLAYING MENU

            //after choosing option 1:
             Console.WriteLine("Welcome! We all know doing laundry is most peoples favorite pasttime. Even yours. Unfortunately," +
                "you just had a long day and you realize you don't have any clothes for tomorrow. Begrudgedly you dig deep and decide" +
                "to do some laundry."); // I may put this text before the menu selection to give the user an intro.
            
        }
    }
}