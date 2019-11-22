using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Menu
    {
        int _menuId;
        string _itemName;
        List<Ingredient> _ingredients;
        float _price;
        string _description;

        [Key]
        public int MenuId { get => _menuId; set => _menuId = value; }
        [Required]
        public string ItemName { get => _itemName; set => _itemName = value; }
        [Required]
        public List<Ingredient> Ingredients { get => _ingredients; set => _ingredients = value; }
        [Required]
        public float Price { get => _price; set => _price = value; }
        [Required]
        public string Description { get => _description; set => _description = value; }
    }
}
