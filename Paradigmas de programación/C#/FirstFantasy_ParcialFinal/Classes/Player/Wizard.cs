using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Player
{
    public class Wizard : Character
    {
        public override String Taunt()
        {
            return "By the Magic";
        }
        public Wizard(string name)
        {
            this.Name = name;
        }
        public override string ShowInformation()
        {
            return "I'm " + Name + " a Wizard";
        }
    }
}
