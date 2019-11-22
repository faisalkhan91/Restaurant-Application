using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class Order
    {
        int _orderId;
        int _menuId;
        int _quantity;
        DateTime _orderPlaced;
        StatusType _status; // Make order status

        public int OrderId { get => _orderId; set => _orderId = value; }
        public int MenuId { get => _menuId; set => _menuId = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public DateTime OrderPlaced { get => _orderPlaced; set => _orderPlaced = value; }
        public StatusType Status { get => _status; set => _status = value; }
    }
}
