using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRIS_R62.Models.Attendance_Required;
using HRIS_R62.Models;

namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NightAllowancesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NightAllowancesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NightAllowances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NightAllowance>>> GetNightAllowances()
        {
            return await _context.NightAllowances.ToListAsync();
        }

        // GET: api/NightAllowances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NightAllowance>> GetNightAllowance(string id)
        {
            var nightAllowance = await _context.NightAllowances.FindAsync(id);

            if (nightAllowance == null)
            {
                return NotFound();
            }

            return nightAllowance;
        }

        // POST: api/NightAllowances
        [HttpPost]
        public async Task<ActionResult<NightAllowance>> PostNightAllowance(NightAllowance nightAllowance)
        {
            _context.NightAllowances.Add(nightAllowance);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NightAllowanceExists(nightAllowance.NightAllowanceID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction(nameof(GetNightAllowance), new { id = nightAllowance.NightAllowanceID }, nightAllowance);
        }

        // PUT: api/NightAllowances/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNightAllowance(string id, NightAllowance nightAllowance)
        {
            if (id != nightAllowance.NightAllowanceID)
            {
                return BadRequest();
            }

            _context.Entry(nightAllowance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NightAllowanceExists(id))
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

        // DELETE: api/NightAllowances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNightAllowance(string id)
        {
            var nightAllowance = await _context.NightAllowances.FindAsync(id);
            if (nightAllowance == null)
            {
                return NotFound();
            }

            _context.NightAllowances.Remove(nightAllowance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NightAllowanceExists(string id)
        {
            return _context.NightAllowances.Any(e => e.NightAllowanceID == id);
        }
    }
}
