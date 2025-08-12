using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMenagementSystem
{
    public class InventoryService : IInventoryService
    {
        public Dictionary<string, Item> _items = new Dictionary<string, Item>();
         public void AddItem(Item item)
        {
            if (item == null) 
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (_items.ContainsKey(item.ID))
            {
                throw new ArgumentException($"Item with ID {item.ID} already exists.");
            }
            _items[item.ID] = item;
        }
        public void RemoveItem(string id)
        {
            if (!_items.ContainsKey(id))
            {
                throw new KeyNotFoundException($"Item with ID {id} does not exist.");
            }
            _items.Remove(id);
        }
        public List<Item> GetUserItems(string userId)
        {
            return _items.Values.Where(item => item.UserID == userId).ToList();
        }
        public List<Item> GetItemsByName(string name)
        {
            return _items.Values.Where(item => item.Name==name).ToList();
        }
        public (string Name, string Description, string ID, string UserID) GetItem(string id)
        {
            if (!_items.TryGetValue(id, out var item))
            {
                throw new ArgumentException("Item does not exist");
            }
            return (item.Name, item.Description, item.ID, item.UserID);
        }
    }
}
