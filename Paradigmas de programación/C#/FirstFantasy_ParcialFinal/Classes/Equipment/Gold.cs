using System;
using System.Collections.Generic;
using System.Text;

namespace FirstFantasy.Classes.Equipment
{
    class Gold:Armor
    {
        public Gold()
        {
            this.Resistance = 11;
        }
        public override String ShowInformation()
        {
            return "This is some armor";
        }
    }
}
