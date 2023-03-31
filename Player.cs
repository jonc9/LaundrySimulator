using System;
using System.Collections.Generic;
using System.Linq; //may not need?
using System.Threading.Tasks;

namespace LaundrySimulator
{
    public class Player : Inventory
    {
        string name = Console.ReadLine();

        public Player(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException($"'{nameof(name)}' cannot be null or whitespace.", nameof(name));
            }

            this.name = name;
        }
    }

}

