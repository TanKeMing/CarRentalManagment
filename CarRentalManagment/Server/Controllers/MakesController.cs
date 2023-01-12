using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagment.Server.Data;
using CarRentalManagment.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManagment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MakesController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        //Refactored


        //public MakesController(ApplicationDbContext context)
        public MakesController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitofWork = unitOfWork;

        }

        // GET: api/Makes
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Make>>> GetMakes()
        public async Task<IActionResult> GetMakes()
        {
            //Refactored
            //return await _context.Makes.ToListAsync();
            var makes = await _unitofWork.Makes.GetAll();
            return Ok(makes);
        }

        // GET: api/Makes/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Make>> GetMake(int id)
        public async Task<IActionResult> GetMake(int id)
        {
            //var make = await _context.Makes.FindAsync(id);
            var make = await _unitofWork.Makes.Get(q => q.Id == id);

            if (make == null)
            {
                return NotFound();
            }

            return Ok(make);
        }

        // PUT: api/Makes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMake(int id, Make make)
        {
            if (id != make.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(make).State = EntityState.Modified;
            _unitofWork.Makes.Update(make);


            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!MakeExists(id))
                if (!await MakeExists(id))
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

        // POST: api/Makes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Make>> PostMake(Make make)
        {
            //_context.Makes.Add(make);
            //await _context.SaveChangesAsync();
              await _unitofWork.Makes.Insert(make);
              await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetMake", new { id = make.Id }, make);
        }

        // DELETE: api/Makes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMake(int id)
        {
            //var make = await _context.Makes.FindAsync(id);
            var make = await _unitofWork.Makes.Get(q => q.Id == id);
            if (make == null)
            {
                return NotFound();
            }

            //_context.Makes.Remove(make);
            //await _context.SaveChangesAsync();
            await _unitofWork.Makes.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool MakeExists(int id)
        private async Task<bool> MakeExists(int id)
        {
            //return _context.Makes.Any(e => e.Id == id);
            var make = _unitofWork.Makes.Get(q => q.Id == id);
            return make != null;
        }
    }
}
