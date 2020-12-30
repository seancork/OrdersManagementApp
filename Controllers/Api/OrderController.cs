using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using seanoneill.Data;
using seanoneill.Models;
using seanoneill.Models.SyncfusionViewModels;
using Microsoft.AspNetCore.Authorization;

namespace seanoneill.Controllers.Api
{
  
    [Produces("application/json")]
    [Route("api/Order")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Order
        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            List<Order> Items = await _context.Order.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Order> payload)
        {
            Order order = payload.value;
            _context.Order.Add(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Order> payload)
        {
            Order order = payload.value;
            _context.Order.Update(order);
            _context.SaveChanges();
            return Ok(order);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Order> payload)
        {
            Order order = _context.Order
                .Where(x => x.Id == (int)payload.key)
                .FirstOrDefault();
            _context.Order.Remove(order);
            _context.SaveChanges();
            return Ok(order);

        }
    }
}