using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class Ingredient
    {
        int _IngredientId;
        string _name;
        int _quantity;

        public int IngredientId { get => _IngredientId; set => _IngredientId = value; }
        public string Name { get => _name; set => _name = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
