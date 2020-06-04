using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Chips : InventoryItem
    {
        public Chips(string itemName, string itemSlot, decimal itemCost) : base(itemName, itemSlot, itemCost)
        {

        }
        /* Sound
  Item name
  Price 
  Quantity */
        private string itemSound = "Crunch Crunch";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
