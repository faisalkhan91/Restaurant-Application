using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;

namespace RestaurantAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly RestaurantContext _context;

        public OrdersController(RestaurantContext context)
        {
            _context = context;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            return await _context.Orders.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(int id, Order order)
        {
            if (id != order.OrderId)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOrder", new { id = order.OrderId }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteOrder(int id)
        {
            var order = await _context.Orders.FindAsync(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();

            return order;
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Any(e => e.OrderId == id);
        }

        //[HttpPost]
        //public async Task<ActionResult<bool>> PlaceOrder(Order order)
        //{
        //    var menu_Ingredients = await _context.MenuIngredients.Include(b => b.Menu_Id).Include(a => a.Ingredient_Id).ToListAsync();
        //    List<MenuIngredient> m = menu_Ingredients.FindAll(mi => mi.MenuReferenceId == order.MenuId);
        //    List<Ingredient> ingredients = await _context.Ingredients.ToListAsync();

        //    List<Ingredient> l = new List<Ingredient>();
        //    foreach (MenuIngredient ingredients1 in m)
        //    {
        //        Ingredient ingredient = ingredients.Find(i => i.IngredientId == ingredients1.IngredientReferenceId);
        //        if (ingredient.Quantity < ingredients1.Quantity * order.Quantity)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            l.Add(ingredient);
        //        }
        //    }
        //    foreach (Ingredient i in l)
        //    {
        //        MenuIngredient ingredients1 = m.Find(ing => ing.IngredientReferenceId == i.IngredientId);
        //        _context.Ingredients.Find(i.IngredientId).Quantity -= ingredients1.Quantity * order.Quantity;
        //        int pl = _context.Ingredients.Find(i.IngredientId).Quantity;
        //    }

        //    //Order o = new Order() { Menu_id = order.Menu_id, Quantity = order.Quantity, Order_placed = order.Order_placed, status = order.status};
        //    _context.Orders.Add(order);
        //    await _context.SaveChangesAsync();
        //    return true;
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Order>>> GetAllActiveOrder()
        //{
        //    var orders = await _context.Orders.ToListAsync();
        //    return orders.FindAll(ord => ord.Status == StatusType.InProgress || ord.Status == StatusType.Placed);
        //}
    }
}
