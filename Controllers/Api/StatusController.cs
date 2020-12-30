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
    [Route("api/status")]
    public class StatusController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StatusController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SalesType
        [HttpGet]
        public async Task<IActionResult> GetSalesType()
        {
            List<Status> Items = await _context.Status.ToListAsync();
            int Count = Items.Count();
            return Ok(new { Items, Count });
        }


        [HttpPost("[action]")]
        public IActionResult Insert([FromBody]CrudViewModel<Status> payload)
        {
            Status salesType = payload.value;
            _context.Status.Add(salesType);
            _context.SaveChanges();
            return Ok(salesType);
        }

        [HttpPost("[action]")]
        public IActionResult Update([FromBody]CrudViewModel<Status> payload)
        {
            Status salesType = payload.value;
            _context.Status.Update(salesType);
            _context.SaveChanges();
            return Ok(salesType);
        }

        [HttpPost("[action]")]
        public IActionResult Remove([FromBody]CrudViewModel<Status> payload)
        {
            Status salesType = _context.Status
                .Where(x => x.StatusId == (int)payload.key)
                .FirstOrDefault();
            _context.Status.Remove(salesType);
            _context.SaveChanges();
            return Ok(salesType);

        }
    }
}