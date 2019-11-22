using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Ingredient
    {
        int _IngredientId;
        string _name;
        int _quantity;

        [Key]
        public int IngredientId { get => _IngredientId; set => _IngredientId = value; }
        [Required]
        public string Name { get => _name; set => _name = value; }
        [Required]
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
