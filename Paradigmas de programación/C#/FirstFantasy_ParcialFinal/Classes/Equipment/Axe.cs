using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Axe : Weapon
    {
        public Axe()
        {
            this.Damage = 7;
        }

        public override String ShowInformation()
        {
            return "This is a weapon";
        }
        public override string Attack()
        {
            Random rnd = new Random();
            int dade = rnd.Next(1, 8);
            string totaldamage = (dade + Damage).ToString();
            return totaldamage + " points of damage";
        }
    }
}
