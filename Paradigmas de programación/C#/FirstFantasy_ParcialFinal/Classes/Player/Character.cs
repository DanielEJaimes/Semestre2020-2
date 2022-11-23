using FirstFantasy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public abstract class Character : IDescribable
    {
        private String name;

        public string Name { get => name; set => name = value; }


        public abstract String Taunt();


        public abstract String ShowInformation();
    }
}
