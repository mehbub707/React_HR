using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRIS_R62.Models.Attendance_Required;
using HRIS_R62.Models;

//namespace HRIS_R62.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class NightAllowanceTimesController : ControllerBase
//    {
//        private readonly ApplicationDbContext _context;

//        public NightAllowanceTimesController(ApplicationDbContext context)
//        {
//            _context = context;
//        }

//        // GET: api/NightAllowanceTimes
//        [HttpGet]
//        public async Task<ActionResult<IEnumerable<NightAllowanceTime>>> GetNightAllowanceTimes()
//        {
//            return await _context.NightAllowanceTimes.ToListAsync();
//        }

//        // GET: api/NightAllowanceTimes/5
//        [HttpGet("{id}")]
//        public async Task<ActionResult<NightAllowanceTime>> GetNightAllowanceTime(string id)
//        {
//            var entity = await _context.NightAllowanceTimes.FindAsync(id);
//            if (entity == null)
//                return NotFound();

//            return entity;
//        }

//        // POST: api/NightAllowanceTimes
//        [HttpPost]
//        public async Task<ActionResult<NightAllowanceTime>> PostNightAllowanceTime(NightAllowanceTime entity)
//        {
//            _context.NightAllowanceTimes.Add(entity);
//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateException)
//            {
//                if (NightAllowanceTimeExists(entity.NightAllowanceTimeID))
//                {
//                    return Conflict();
//                }
//                else
//                {
//                    throw;
//                }
//            }

//            return CreatedAtAction(nameof(GetNightAllowanceTime), new { id = entity.NightAllowanceTimeID }, entity);
//        }

//        // PUT: api/NightAllowanceTimes/5
//        [HttpPut("{id}")]
//        public async Task<IActionResult> PutNightAllowanceTime(string id, NightAllowanceTime entity)
//        {
//            if (id != entity.NightAllowanceTimeID)
//            {
//                return BadRequest();
//            }

//            _context.Entry(entity).State = EntityState.Modified;

//            try
//            {
//                await _context.SaveChangesAsync();
//            }
//            catch (DbUpdateConcurrencyException)
//            {
//                if (!NightAllowanceTimeExists(id))
//                    return NotFound();
//                else
//                    throw;
//            }

//            return NoContent();
//        }

//        // DELETE: api/NightAllowanceTimes/5
//        [HttpDelete("{id}")]
//        public async Task<IActionResult> DeleteNightAllowanceTime(string id)
//        {
//            var entity = await _context.NightAllowanceTimes.FindAsync(id);
//            if (entity == null)
//                return NotFound();

//            _context.NightAllowanceTimes.Remove(entity);
//            await _context.SaveChangesAsync();

//            return NoContent();
//        }

//        private bool NightAllowanceTimeExists(string id)
//        {
//            return _context.NightAllowanceTimes.Any(e => e.NightAllowanceTimeID == id);
//        }
//    }
//}
namespace HRIS_R62.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NightAllowanceTimesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public NightAllowanceTimesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/NightAllowanceTimes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NightAllowanceTime>>> GetNightAllowanceTimes()
        {
            // সব NightAllowanceTime রেকর্ড রিটার্ন করবে
            return await _context.NightAllowanceTimes.ToListAsync();
        }

        // GET: api/NightAllowanceTimes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NightAllowanceTime>> GetNightAllowanceTime(string id)
        {
            var entity = await _context.NightAllowanceTimes.FindAsync(id);

            if (entity == null)
                return NotFound();

            return entity;
        }

        // NEW: ID auto generate করার জন্য API
        // GET: api/NightAllowanceTimes/GenerateNextId
        [HttpGet("GenerateNextId")]
        public async Task<ActionResult<string>> GenerateNextId()
        {
            // DB থেকে সর্বশেষ ID পাবে (বড় ক্রম অনুসারে)
            var lastId = await _context.NightAllowanceTimes
                .OrderByDescending(n => n.NightAllowanceTimeID)
                .Select(n => n.NightAllowanceTimeID)
                .FirstOrDefaultAsync();

            if (string.IsNullOrEmpty(lastId))
            {
                // যদি ডাটাবেজ খালি থাকে, প্রথম ID হবে NAT0001
                return Ok("NAT0001");
            }

            // ID ফরম্যাট: NAT + 4 ডিজিট নম্বর (যেমন NAT0001)
            var numericPart = int.Parse(lastId.Substring(3));
            var nextId = "NAT" + (numericPart + 1).ToString("D4");
            return Ok(nextId);
        }

        // POST: api/NightAllowanceTimes
        [HttpPost]
        public async Task<ActionResult<NightAllowanceTime>> PostNightAllowanceTime(NightAllowanceTime entity)
        {
            // যদি ক্লায়েন্ট থেকে ID না দেওয়া হয়, তাহলে auto generate করবে
            if (string.IsNullOrEmpty(entity.NightAllowanceTimeID))
            {
                var idResult = await GenerateNextId();
                entity.NightAllowanceTimeID = idResult.Value!;
            }

            _context.NightAllowanceTimes.Add(entity);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                // যদি ID আগেই থাকে, তাহলে Conflict রিটার্ন করবে
                if (NightAllowanceTimeExists(entity.NightAllowanceTimeID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            // সফলভাবে নতুন রেকর্ড তৈরি হলে, নতুন রেকর্ড রিটার্ন করবে
            return CreatedAtAction(nameof(GetNightAllowanceTime), new { id = entity.NightAllowanceTimeID }, entity);
        }

        // PUT: api/NightAllowanceTimes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNightAllowanceTime(string id, NightAllowanceTime entity)
        {
            // PUT রিকোয়েস্টের ID এবং বডির ID মেলানো লাগবে
            if (id != entity.NightAllowanceTimeID)
            {
                return BadRequest();
            }

            // EF Core-এ এন্টিটি মডিফাইড চিহ্নিত করো
            _context.Entry(entity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                // যদি ID না পাওয়া যায়, 404 রিটার্ন করবে
                if (!NightAllowanceTimeExists(id))
                    return NotFound();
                else
                    throw;
            }

            return NoContent();
        }

        // DELETE: api/NightAllowanceTimes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNightAllowanceTime(string id)
        {
            var entity = await _context.NightAllowanceTimes.FindAsync(id);

            if (entity == null)
                return NotFound();

            _context.NightAllowanceTimes.Remove(entity);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // NightAllowanceTimeID বিদ্যমান আছে কিনা চেক করার জন্য helper মেথড
        private bool NightAllowanceTimeExists(string id)
        {
            return _context.NightAllowanceTimes.Any(e => e.NightAllowanceTimeID == id);
        }
    }
}
