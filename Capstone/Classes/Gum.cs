using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Gum : InventoryItem
    {

        public Gum(string itemName, string itemSlot, decimal itemCost) : base(itemName, itemSlot, itemCost)
        {

        }

        private string itemSound = "Chew Chew";
        public override string MakeSound()
        {
            return $"{itemSound},  Yum!";
        }
    }
}
