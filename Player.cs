using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LaundrySimulator
{
    public class Player : Inventory
    {
        public string name;
        
        public void playerName(string playerName)
        {
            Console.WriteLine("What is your name?");
            Console.ReadLine();
            name = playerName;
            playerName = Console.ReadLine();
        }
    }
}

    /*public Player(string name)
    { 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            this.name = name;
        }
    }*/


