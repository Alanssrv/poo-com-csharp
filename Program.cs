// See https://aka.ms/new-console-template for more information
using System;
using RPG.src.Entities;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 99, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(7));
            Console.WriteLine(jennica.Attack(1));
        }

    }
}

