using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    class Netherite:Armor
    {
        public Netherite()
        {
            this.Resistance = 20;
        }
        public override String ShowInformation()
        {
            return "This is some armor";
        }
    }
}
