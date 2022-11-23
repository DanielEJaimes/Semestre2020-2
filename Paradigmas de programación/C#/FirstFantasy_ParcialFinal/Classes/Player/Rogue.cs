using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Rogue : Character
    {

        public override String Taunt()
        {
            return "Hit me if you dare";
        }
        public override String ShowInformation()
        {
            return "I'm " + Name + " a Rogue";
        }
        public Rogue(string name)
        {
            this.Name = name;
        }
    }
}
