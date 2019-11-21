using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentAPI.Models
{
    public class MenuIngredient
    {
        int _MenuIngredientsId;
        Menu _menu_Id;
        Ingredient _ingredient_Id;
        int _menuReferenceId;
        int _IngredientReferenceId;
        int _quantity;

        [Key]
        public int MenuIngredientsId { get => _MenuIngredientsId; set => _MenuIngredientsId = value; }
        public Menu Menu_Id { get => _menu_Id; set => _menu_Id = value; }
        public Ingredient Ingredient_Id { get => _ingredient_Id; set => _ingredient_Id = value; }
        [ForeignKey("Menu_Id"), Required]
        public int MenuReferenceId { get => _menuReferenceId; set => _menuReferenceId = value; }
        [ForeignKey("Ingredient_Id"), Required]
        public int IngredientReferenceId { get => _IngredientReferenceId; set => _IngredientReferenceId = value; }
        [Required]
        public int Quantity { get => _quantity; set => _quantity = value; }
    }
}
