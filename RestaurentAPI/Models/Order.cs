using RestaurantAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class Order
    {
        int _orderId;
        int _menuId;
        int _quantity;
        DateTime _orderPlaced;
        StatusType _status; // Make order status

        [Key]
        public int OrderId { get => _orderId; set => _orderId = value; }
        [Required]
        public int MenuId { get => _menuId; set => _menuId = value; }
        [Required]
        public int Quantity { get => _quantity; set => _quantity = value; }
        [Required]
        public DateTime OrderPlaced { get => _orderPlaced; set => _orderPlaced = value; }
        [Required]
        public StatusType Status { get => _status; set => _status = value; }
    }
}
