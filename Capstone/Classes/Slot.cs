using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Slot
    {
        private string slotID;
        private InventoryItem slotType;
        public List<InventoryItem> slotItem { get; }

        //Creating Constructor for Slot
        public Slot (string slotID, List<InventoryItem> slotItemNumber)
        {
            this.slotID = slotID;
            slotItem = slotItemNumber;
        }
        
        public string SlotID
        {
            get
            {
                return slotID;
            }
        }

        public InventoryItem SlotType
        {
            get
            {
                return slotType;
            }
        }


        public int NumberOfItemsRemaining
        {
            get
            {
                return slotItem.Count;
            }
        }

        public bool isEmpty
        {
            get 
            {
                return NumberOfItemsRemaining == 0;
            }
        }

        

    }
}
