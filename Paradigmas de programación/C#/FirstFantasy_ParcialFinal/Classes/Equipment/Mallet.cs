using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public class Mallet : Weapon
    {
        public Mallet()
        {
            this.Damage = 11;
        }
        public override string Attack()
        {
            Random rnd = new Random();
            int dade = rnd.Next(1, 8);
            string totaldamage = (dade + Damage).ToString();
            return totaldamage + " points of damage";
        }
        public override String ShowInformation()
        {
            return "This is a weapon";
        }
    }
}
