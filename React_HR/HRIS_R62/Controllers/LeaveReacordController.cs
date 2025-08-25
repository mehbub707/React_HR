using HRIS_R62.Models;
using HRIS_R62.Models.Attendance_Required;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveReacordController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeaveReacordController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getLeaveRecord = await _context.LeaveRecords.ToListAsync();
            return Ok(getLeaveRecord);
        }

        [HttpGet("Id")]
        public async Task<IActionResult> GetById(string id)
        {
            var result = await _context.LeaveRecords.FindAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LeaveRecord entity) 
        {
            LeaveRecord leaveRecord = new LeaveRecord();
            leaveRecord. LeaveDate = entity.LeaveDate;
            leaveRecord.Remarks = entity.Remarks;
            leaveRecord.LeaveTypeID = entity.LeaveTypeID;
            leaveRecord.TotalLeave = entity.TotalLeave;
            leaveRecord.LeaveEnjoyed = entity.LeaveEnjoyed;
            leaveRecord.ApprovedDate = entity.ApprovedDate;
            leaveRecord.EmployeeID = entity.EmployeeID;
            leaveRecord.EntryUser  = entity.EntryUser;
            leaveRecord.EntryDate = entity.EntryDate;
            
            await _context.LeaveRecords.AddAsync(leaveRecord);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(string id, LeaveRecord entity)
        {
            if(entity == null || id != entity.LeaveRecordID)
            {
                return BadRequest("ID Mismatch!");
            }

            var updateRecord = await _context.LeaveRecords.FindAsync(id);
            if(updateRecord == null)
            {
                return NotFound($"LeaveRecord with ID = {id} Not Found!");
            }
            
            updateRecord.LeaveDate = entity.LeaveDate;
            updateRecord.Remarks = entity.Remarks;
            updateRecord.LeaveTypeID= entity.LeaveTypeID;
            updateRecord.TotalLeave= entity.TotalLeave;
            updateRecord.LeaveEnjoyed= entity.LeaveEnjoyed;
            updateRecord.ApprovedDate= entity.ApprovedDate;
            updateRecord.EmployeeID= entity.EmployeeID;
            updateRecord.EntryUser= entity.EntryUser;
            updateRecord.EntryDate= entity.EntryDate;

            _context.LeaveRecords.Update(updateRecord);
            await _context.SaveChangesAsync();

            return Ok(entity);
        }
    }
}
