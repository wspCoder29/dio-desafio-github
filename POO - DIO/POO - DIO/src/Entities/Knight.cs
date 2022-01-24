using POO_DIO.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.src.Entities
{
   public class Knight : Hero
    {

        public Knight(string name, int level, string heroType)
        {
            this.Name = name;
            this.Lv = level;
            this.HeroType = heroType;
        }

        public Knight()
        {

        }
        
        public string PowerUp()
        {
            return this.Name + " used special hability PowerUp, AttackPower is now OVER9000!";
        }

        public string OmniChange()
        {
            Defense -= 100;
            AttackPower = 50;
            return this.Name + " usou OmniChange Defense -100 AttackPower=50!";
        }



    }
}
