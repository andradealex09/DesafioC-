using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroi.src.Entities
{
    public class Fiora : Hero
    { 
        public Fiora(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;  
        }
        public override string Attack()
        {
            return this.Name + " Lamina Afiada ";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " Executou o inimigo  ";
            }
            else 
            {
                return this.Name + " Deixou o inimigo sair com vida ";
            }
        }


    }
}