using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvP_Battle_Console
{
    class Champion
    {
        public double hp;
        public double attack_dmg;
        public double attack_speed;
        public double armor;
        public double dps;
        public double defense;
        public double strenght;
        public double endurance;
        public double agility;
        public double dexterity;



        public Champion(double hp, 
                        double attack_dmg, double attack_speed,
                        double armor)
        {
            this.hp = hp;
            this.attack_dmg = attack_dmg;
            this.attack_speed = attack_speed;
            this.armor = armor;

            this.dps = (attack_dmg * attack_speed) / 60;
            this.defense = (armor * hp) * 0.025;
            
        }

    }
}
