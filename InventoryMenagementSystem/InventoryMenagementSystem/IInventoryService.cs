using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMenagementSystem
{
    public interface IInventoryService
    {
        void AddItem(Item item);
        void RemoveItem(string id);
        List<Item> GetUserItems(string userId);
        List<Item> GetItemsByName(string name);
        (string Name, string Description, string ID, string UserID) GetItem(string id);


    }
    }
}
