using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_DIO.src.Entities
{
    class WhiteWizard : Hero
    {


        public WhiteWizard(string name, int level, string heroType)
        {
            this.Name = name;
            this.Lv = level;
            this.HeroType = heroType;
        }

        public WhiteWizard()
        {

        }

        public string HealingWind()
        {
            Hp = Hp + 500;
            return this.Name + " invoked Healing Wind +500 hp for all allyes";
        }


        public string CureStatus()
        {
            Status = "Ok";
            return this.Name + " used Cure Status: all negative status removed";
        }





    }
}
