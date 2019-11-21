using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class MenuIngredients
    {
        int _menId;
        int _ingrdId;

        public int MenId { get => _menId; set => _menId = value; }
        public int IngrdId { get => _ingrdId; set => _ingrdId = value; }
    }
}
