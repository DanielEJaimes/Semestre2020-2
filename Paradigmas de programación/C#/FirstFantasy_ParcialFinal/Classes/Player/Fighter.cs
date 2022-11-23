using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Fighter : Character
    {

        public override String Taunt()
        {
            return "By my Lord";
        }


        public override String ShowInformation()
        {
            return "I'm " + Name + " a Fighter";
        }
        public Fighter(string name)
        {
            this.Name = name;
        }
    }
}
