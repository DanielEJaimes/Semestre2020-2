using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    public abstract class Weapon : IDescribable
    {
        int damage;

        public int Damage { get => damage; set => damage = value; }

        public abstract string ShowInformation();

        public abstract string Attack();

    }
}
