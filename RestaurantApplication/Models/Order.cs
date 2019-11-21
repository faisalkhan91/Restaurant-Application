using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantApplication.Models
{
    public class Order
    {
        int _orderId;
        Menu _menu;
        int _quantity;
        DateTime _orderPlaced;
        StatusType _status; // Make order status

        public int OrderId { get => _orderId; set => _orderId = value; }
        public Menu Menu { get => _menu; set => _menu = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public DateTime OrderPlaced { get => _orderPlaced; set => _orderPlaced = value; }
        public StatusType Status { get => _status; set => _status = value; }
    }
}
