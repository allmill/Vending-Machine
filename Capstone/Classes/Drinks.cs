using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Drinks : InventoryItem
    {
        public Drinks(string itemName, string itemSlot, decimal itemCost) : base(itemName, itemSlot, itemCost)
        {

        }
        /* Sound
    Item name
    Price 
    Quantity */
        private string itemSound = "Glug Glug";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
