using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.src.Entities
{
   public abstract class Hero
    {
        public string Name { get; set; }
        public int Lv { get; set; }
        public string HeroType { get; set; }
        public double damageTaken { get; set; }
        public int AttackPower { get; set; }
        public int Luck { get; set; }
        public int Hp { get; set; }
        public int MP { get; set; }
        public string Status { get; set; }
        public int Defense { get; set; }



        public Hero(string name, int level, string heroType, int Hp, int MP)
        {
            this.Name = name;
            this.Lv = level;
            this.HeroType = heroType;
        }

        public Hero()
        {
        }

        public virtual string Attack()
        {
            return this.Name + " atacou com a sua espada";
        }

        public string Defend(int damage)
        {
            if (damage%2==0)
            {
                damageTaken = damage - (damage * 0.1);
            }
            else
            {
                damageTaken = damage;
            }
            return this.Name + " recebeu dano de "+damageTaken;
        }


        public override string ToString()
        {
            return "Name: " + Name 
                + "\n" 
                + "Level: " + Lv + 
                "\n" + 
                "Hero Type: " + HeroType+
                "\n"+
                "HP: "+Hp+
                "\n"+
                "MP: "+MP;
        }



    }
}
