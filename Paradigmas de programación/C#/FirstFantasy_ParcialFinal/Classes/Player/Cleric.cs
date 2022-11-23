using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Cleric : Character
    {
        
        public override String Taunt()
        {
            return "By the Gods";
        }
        public override string ShowInformation()
        {
            return "I'm " + Name + " a Cleric";
        }
        public Cleric(string name)
        {
            this.Name = name;
        }
    }
}
