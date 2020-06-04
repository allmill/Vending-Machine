using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drinks : InventoryItem, ISounds
    {
        /* Sound
    Item name
    Price 
    Quantity */
        public override string MakeSound()
        {
            return null;
        }
    }
}
