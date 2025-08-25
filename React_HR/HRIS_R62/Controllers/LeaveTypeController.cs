using HRIS_R62.Models;
using HRIS_R62.Models.Attendance_Required;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveTypeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeaveTypeController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getAll = await _context.LeaveTypes.ToListAsync();
            return Ok(getAll);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var getById = await _context.LeaveTypes.FindAsync(id);
            return Ok(getById);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LeaveType entity)
        {
            LeaveType leaveType = new LeaveType();
            leaveType.LeaveTypeName = entity.LeaveTypeName;
            leaveType.EntryUser = entity.EntryUser;
            leaveType.EntryDate = entity.EntryDate;

            await _context.LeaveTypes.AddAsync(leaveType);
            await _context.SaveChangesAsync();

            return Ok(entity);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(string id, LeaveType entity)
        {
            if(entity == null || id != entity.LeaveTypeID)
            {
                return BadRequest("ID Mismatch!!");
            }
            var updateType = await _context.LeaveTypes.FindAsync(id);

            if(updateType == null)
            {
                return NotFound($"LeaveType with Id = {id} not found");
            }

            updateType.LeaveTypeName = entity.LeaveTypeName;
            updateType.EntryUser = entity.EntryUser;
            updateType.EntryDate= entity.EntryDate;

            _context.LeaveTypes.Update(updateType);
            await _context.SaveChangesAsync();

            return Ok(entity);
        }
    }
}
