using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.Classes
{
    public class Slot
    {
        private string slotID;
        private InventoryItem slotType;
        private List<InventoryItem> slotItems = new List<InventoryItem>();

        //Creating Constructor for Slot
        public Slot (string slotID, List<InventoryItem> slotItems)
        {
            

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

        public List<InventoryItem> SlotItems
        {
            get
            {
                return slotItems;
            }
        }

        

    }
}
