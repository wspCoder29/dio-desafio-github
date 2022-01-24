using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.src.Entities
{
    class Ninja: Hero
    {

        public Ninja(string name, int level, string heroType)
        {
            this.Name = name;
            this.Lv = level;
            this.HeroType = heroType;
        }

        public Ninja()
        {
        }

        
       override public string Attack()
        {
            return this.Name + " used Ninja attack with shuriken";
        }


        public string Furtive()
        {
            return this.Name + " used furtive attack";
        }


        public string NinjaWay()
        {
            AttackPower += 10;
            MP += 10;
            return this.Name + " AttackPower+10 MP+10";
        }






    }
}
