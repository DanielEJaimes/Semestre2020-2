using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    class Diamond:Armor
    {
        public Diamond()
        {
            this.Resistance = 17;
        }
        public override String ShowInformation()
        {
            return "This is some armor";
        }
    }
}
