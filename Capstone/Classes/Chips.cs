using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chips : InventoryItem
    {
        public Chips(string itemSlot, string itemName, decimal itemCost) : base(itemSlot, itemName, itemCost)
        {

        }
        /* Sound
  Item name
  Price 
  Quantity */
        public string itemSound = "Crunch Crunch, Yum!";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
