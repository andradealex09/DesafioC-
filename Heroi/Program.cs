using System;
using Heroi.src.Entities;

namespace Heroi
{
    class Program
    {
        static void Main(string[] args)
        { 
        
            Knigth arus  = new Knigth("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Fiora fiora = new Fiora("Fiora", 99, "Fighter" );
            Gwen gwen = new Gwen("Gwen", 100, "fighter");
        
           

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(8));
            Console.WriteLine(fiora.Attack(60));
            Console.WriteLine(gwen.Attack(6));

        }
    }
}
