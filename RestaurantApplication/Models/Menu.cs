using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class Menu
    {
        int _menuId;
        string _itemName;
        List<Ingredient> _ingredients;
        float _price;
        string _description;

        public int MenuId { get => _menuId; set => _menuId = value; }
        public string ItemName { get => _itemName; set => _itemName = value; }
        public List<Ingredient> Ingredients { get => _ingredients; set => _ingredients = value; }
        public float Price { get => _price; set => _price = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
