using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroi.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;  
        }
        
        public override string Attack()
        {
            return this.Name + " Lançou magia";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 6)
            {
                return this.Name + " Lançou a Magia destrutiva ";
            }
            else
            {
                return this.Name + "Lançou uma magia com pouca força com bonus de ";
            }
        }
    
    }
}