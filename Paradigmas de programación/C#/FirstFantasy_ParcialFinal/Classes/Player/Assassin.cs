using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Assassin : Character
    {
        public override String Taunt()
        {
            return "In the shadow";
        }
        public override string ShowInformation()
        {
            return "I'm "+Name +" an Assassin";
        }
        public Assassin(string name)
        {
            this.Name = name;
        }
    }
}
