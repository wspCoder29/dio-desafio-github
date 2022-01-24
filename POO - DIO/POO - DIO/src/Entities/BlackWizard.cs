using POO_DIO.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.src.Entities
{
    class BlackWizard : Hero
    {


        public BlackWizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Lv = level;
            this.HeroType = heroType;
        }


        public BlackWizard()
        {
        
        }

        public string Attack(int Bonus)
        {
            if (Bonus < 7)
            {
                return this.Name + " launched less effective attack, bonus " + Bonus;
            }
            else
            {
                return this.Name + " launched super effective attack, bonus " + Bonus;
            }
        }


        public string BlackStorm(int area)
        {
            return this.Name + " used lighting attack in "+area+" squares of the battlefield";
        }


        public string Catastrofe(int powerUp)
        {
            int atkUpBonus = powerUp;
            AttackPower = atkUpBonus;
            return this.Name + " invoked magic creature, atkUp+ "+ AttackPower + " for all allyes";
        }






    }
}
