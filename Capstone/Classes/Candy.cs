using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : InventoryItem
    {
        public Candy (string itemName, string itemSlot, decimal itemCost) : base(string itemName, string itemSlot, decimal itemCost)

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
