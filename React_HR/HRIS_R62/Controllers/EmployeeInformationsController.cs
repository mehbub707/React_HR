using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRIS_R62.Models;
using HRIS_R62.Models.Attendance_Required;

namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeInformationsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeInformationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/EmployeeInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeInformation>>> GetEmployeeInformations()
        {
            return await _context.EmployeeInformations.ToListAsync();
        }

        // GET: api/EmployeeInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeInformation>> GetEmployeeInformation(string id)
        {
            var employeeInformation = await _context.EmployeeInformations.FindAsync(id);

            if (employeeInformation == null)
            {
                return NotFound();
            }

            return employeeInformation;
        }

        // PUT: api/EmployeeInformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployeeInformation(string id, EmployeeInformation employeeInformation)
        {
            if (id != employeeInformation.EmployeeID)
            {
                return BadRequest();
            }

            _context.Entry(employeeInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeInformationExists(id))
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

        // POST: api/EmployeeInformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmployeeInformation>> PostEmployeeInformation(EmployeeInformation employeeInformation)
        {
            _context.EmployeeInformations.Add(employeeInformation);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EmployeeInformationExists(employeeInformation.EmployeeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEmployeeInformation", new { id = employeeInformation.EmployeeID }, employeeInformation);
        }

        // DELETE: api/EmployeeInformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeInformation(string id)
        {
            var employeeInformation = await _context.EmployeeInformations.FindAsync(id);
            if (employeeInformation == null)
            {
                return NotFound();
            }

            _context.EmployeeInformations.Remove(employeeInformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmployeeInformationExists(string id)
        {
            return _context.EmployeeInformations.Any(e => e.EmployeeID == id);
        }
    }
}
