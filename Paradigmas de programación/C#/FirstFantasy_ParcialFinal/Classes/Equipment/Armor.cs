using System;
using System.Collections.Generic;
using System.Text;
using FirstFantasy.Interfaces;

namespace FirstFantasy
{
    public abstract class Armor: IDescribable
    {
        int resistance;

        public int Resistance { get => resistance; set => resistance = value; }

        public abstract string ShowInformation();
    }
}
