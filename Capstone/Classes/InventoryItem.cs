using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public abstract class InventoryItem
    {
        private string itemName;
        private string itemSlot;
        private decimal itemCost;
        
        public InventoryItem (string itemName, string itemSlot, decimal itemCost)
        {
            this.itemName = itemName;
            this.itemSlot = itemSlot;
            this.itemCost = itemCost;
        }
        
        public string ItemName
        {
            get
            {
                return itemName;
            }
        }
        public string ItemSlot
        {
            get
            {
                return itemSlot;
            }
        }
        public decimal ItemCost
        {
            get
            {
                return itemCost;
            }
        }
        public string ItemSound;

        public abstract string MakeSound();

    }
}
