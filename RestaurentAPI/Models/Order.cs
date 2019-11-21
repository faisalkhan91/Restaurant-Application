using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurentAPI.Models
{
    public class Order
    {
        int _orderId;
        Menu _menu;
        int _quantity;
        DateTime _orderPlaced;
        StatusType _status; // Make order status

        [Key]
        public int OrderId { get => _orderId; set => _orderId = value; }
        [Required]
        public Menu Menu { get => _menu; set => _menu = value; }
        [Required]
        public int Quantity { get => _quantity; set => _quantity = value; }
        [Required]
        public DateTime OrderPlaced { get => _orderPlaced; set => _orderPlaced = value; }
        [Required]
        public StatusType Status { get => _status; set => _status = value; }
    }
}
