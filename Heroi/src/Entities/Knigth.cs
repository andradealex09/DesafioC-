using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroi.src.Entities
{
    public class Knigth : Hero
    { 
        public Knigth(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;  
        }
        public override string Attack()
        {
            return this.Name + " Atacou forte com a espada ";
        }
    }
}