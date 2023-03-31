using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;
using System.Xml.Linq;
//using MenuGroup; //may need to remove

namespace LaundrySimulator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Laundry Simulator";
            //want to have something that says "press any key to start"
            //maybe have some kind of logo? like ascii or something that pulls from a text file or however it'd work

            // might need this -> ? Console.ReadKey();
            Player playerName = new Player();
            
            //Console.WriteLine("What is your name?");
            //Console.WriteLine("\n");
            Console.WriteLine(playerName);
            Console.WriteLine($"Your name is " + playerName + ", " + "corret?");

            Console.WriteLine("Welcome! We all know doing laundry is most peoples favorite pasttime. Even yours. Unfortunately," +
               "you just had a long day and you realize you don't have any clothes for tomorrow. Begrudgedly you dig deep and decide " +
               "to do some laundry." + "\n" + "Or do you?"); // I may put this text before the menu selection to give the user an intro.

            static void MainLoop()
            {

                Console.WriteLine("\n");
                Console.WriteLine("Make your choice by entering a numerical digit. Nothing more.");
                Console.WriteLine("\n");
            TopOfMenu: // for the goto in the case 2 section of the switch code block
                Console.WriteLine("1.) Do Your Laundry"); // will link to the main gameplay loop
                Console.WriteLine("\n");

                Console.WriteLine("2.) About/How to play");
                Console.WriteLine("\n");

                Console.WriteLine("3.) Exit aka Give up on wearing clean clothes tomorrow.");
                Console.WriteLine("\n");
                var userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Okay. It is laundry time!");
                        Console.WriteLine("\n");
                        System.Threading.Thread.Sleep(3000);
                        goto Option1Chosen;

                    case 2:
                        Console.WriteLine("This is a version of a silly idea I had I wanted to do for my final project. However, what I wanted to do " +
                    "was going to take longer than ancitipated... This version you have limited options as to what you can do. The README will " +
                    "have more information.");
                        System.Threading.Thread.Sleep(2000); //implement a 'wait' and a "goback selection" use ClearConsole as well?
                        //Console.ReadKey(); -- this may be used to have the program wait until a key is pressed to go back?
                        goto TopOfMenu; //this takes you to the line right before "1.) Do Your Laundry" 


                    case 3:
                        Console.WriteLine("\n" + "I guess this is goodbye. Have fun being smelly!");
                        System.Threading.Thread.Sleep(3000);
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Try again, please.");
                        break;
                }
            Option1Chosen:;
                Inventory inventory = new Inventory();

                foreach (string item in inventory.clothes1)
                {
                    Console.WriteLine(item);
                }
                // give option to wash clothes

            }

            MainLoop();
           


            
            
        }
        
    }
}