using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Heroi.src.Entities
{
    public class Gwen : Hero
    {
        public Gwen (string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType; 
        }

         public override string Attack()
        {
            return this.Name + " MIL RETALHOS";
        }
       public string Attack(int Bonus)
        {
            if (Bonus >= 6)
            {
                return this.Name + " Lançou o ponto cruz ";
            }
            else
            {
                return this.Name + "atacou com o corte e retalho ";
            }
        }
            

    }
}