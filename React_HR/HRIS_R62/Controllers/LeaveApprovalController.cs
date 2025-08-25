using HRIS_R62.Models;
using HRIS_R62.Models.Attendance_Required;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveApprovalController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LeaveApprovalController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var getAll = await _context.LeaveApprovals.ToListAsync();
            return Ok(getAll);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var getById = await _context.LeaveApprovals.FindAsync(id);
            return Ok(getById);
        }

        [HttpPost]
        public async Task<IActionResult> Create(LeaveApproval entity)
        {
            LeaveApproval leaveApproval = new LeaveApproval();
            leaveApproval.LeaveTypeID = entity.LeaveTypeID;
            leaveApproval.LeaveFromDate = entity.LeaveFromDate;
            leaveApproval.LeaveToDate = entity.LeaveToDate;
            leaveApproval.Remarks = entity.Remarks;
            leaveApproval.ApprovedDate = entity.ApprovedDate;
            leaveApproval.LeaveEnjoyed = entity.LeaveEnjoyed;
            leaveApproval.TotalLeave = entity.TotalLeave;
            leaveApproval.ProvidedLeave = entity.ProvidedLeave;
            leaveApproval.EmployeeID = entity.EmployeeID;
            leaveApproval.EntryUser = entity.EntryUser;
            leaveApproval.EntryDate = entity.EntryDate;

            await _context.LeaveApprovals.AddRangeAsync(leaveApproval);
            await _context.SaveChangesAsync();
            return Ok(leaveApproval);
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> Update(string id,LeaveApproval entity)
        {
            if(entity == null || id != entity.LeaveApprovalID)
            {
                return BadRequest("ID Mismatch!!");
            }

            var updateApproval = await _context.LeaveApprovals.FindAsync(id);

            if(updateApproval == null)
            {
                return NotFound($"LeaveApproval with ID = {id} Not Found!!");
            }

            updateApproval.LeaveTypeID = entity.LeaveTypeID;
            updateApproval.LeaveFromDate = entity.LeaveFromDate;
            updateApproval.LeaveFromDate = entity.LeaveFromDate;
            updateApproval.LeaveToDate = entity.LeaveToDate;
            updateApproval.Remarks = entity.Remarks;
            updateApproval.ApprovedDate = entity.ApprovedDate;
            updateApproval.LeaveEnjoyed = entity.LeaveEnjoyed;
            updateApproval.TotalLeave = entity.TotalLeave;
            updateApproval.ProvidedLeave = entity.ProvidedLeave;
            updateApproval.EmployeeID = entity.EmployeeID;
            updateApproval.EntryUser = entity.EntryUser;
            updateApproval.EntryDate = entity.EntryDate;

            _context.LeaveApprovals.Update(updateApproval);
            await _context.SaveChangesAsync();
            return Ok(entity);
        }
    }
}
