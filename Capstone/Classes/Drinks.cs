using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drinks : InventoryItem
    {
        public Drinks(string itemSlot, string itemName, decimal itemCost) : base(itemSlot, itemName, itemCost)
        {

        }
        /* Sound
    Item name
    Price 
    Quantity */
        private string itemSound = "Glug Glug, Yum!";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
