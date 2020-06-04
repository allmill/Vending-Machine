using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Candy : InventoryItem
    {
        
        public Candy (string itemName, string itemSlot, decimal itemCost) : base(itemName, itemSlot, itemCost)
        {
            
        }
        /* Sound
        Item name
        Price 
        Quantity */
        private string itemSound = "Munch Munch";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
