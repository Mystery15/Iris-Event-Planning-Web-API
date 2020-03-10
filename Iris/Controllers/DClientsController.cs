using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Iris.Models;

namespace Iris.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DClientsController : ControllerBase
    {
        private readonly ClientDBContext _context;

        public DClientsController(ClientDBContext context)
        {
            _context = context;
        }

        // GET: api/DClients
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DClient>>> GetDClients()
        {
            return await _context.DClients.ToListAsync();
        }

        // GET: api/DClients/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DClient>> GetDClient(int id)
        {
            var dClient = await _context.DClients.FindAsync(id);

            if (dClient == null)
            {
                return NotFound();
            }

            return dClient;
        }

        // PUT: api/DClients/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDClient(int id, DClient dClient)
        {
            dClient.ClientID = id;

            _context.Entry(dClient).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DClientExists(id))
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

        // POST: api/DClients
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<DClient>> PostDClient(DClient dClient)
        {
            _context.DClients.Add(dClient);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDClient", new { id = dClient.ClientID }, dClient);
        }

        // DELETE: api/DClients/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DClient>> DeleteDClient(int id)
        {
            var dClient = await _context.DClients.FindAsync(id);
            if (dClient == null)
            {
                return NotFound();
            }

            _context.DClients.Remove(dClient);
            await _context.SaveChangesAsync();

            return dClient;
        }

        private bool DClientExists(int id)
        {
            return _context.DClients.Any(e => e.ClientID == id);
        }
    }
}
