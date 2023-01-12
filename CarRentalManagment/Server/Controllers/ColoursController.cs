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
    public class ColoursController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        //Refactored


        //public ColoursController(ApplicationDbContext context)
        public ColoursController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitofWork = unitOfWork;

        }

        // GET: api/Colours
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Colour>>> GetColours()
        public async Task<IActionResult> GetColours()
        {
            //Refactored
            //return await _context.Colours.ToListAsync();
            var colours = await _unitofWork.Colours.GetAll();
            return Ok(colours);
        }

        // GET: api/Colours/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Colour>> GetColour(int id)
        public async Task<IActionResult> GetColour(int id)
        {
            //var colour = await _context.Colours.FindAsync(id);
            var colour = await _unitofWork.Colours.Get(q => q.Id == id);

            if (colour == null)
            {
                return NotFound();
            }

            return Ok(colour);
        }

        // PUT: api/Colours/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutColour(int id, Colour colour)
        {
            if (id != colour.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(colour).State = EntityState.Modified;
            _unitofWork.Colours.Update(colour);


            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ColourExists(id))
                if (!await ColourExists(id))
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

        // POST: api/Colours
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Colour>> PostColour(Colour colour)
        {
            //_context.Colours.Add(colour);
            //await _context.SaveChangesAsync();
              await _unitofWork.Colours.Insert(colour);
              await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetColour", new { id = colour.Id }, colour);
        }

        // DELETE: api/Colours/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteColour(int id)
        {
            //var colour = await _context.Colours.FindAsync(id);
            var colour = await _unitofWork.Colours.Get(q => q.Id == id);
            if (colour == null)
            {
                return NotFound();
            }

            //_context.Colours.Remove(colour);
            //await _context.SaveChangesAsync();
            await _unitofWork.Colours.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ColourExists(int id)
        private async Task<bool> ColourExists(int id)
        {
            //return _context.Colours.Any(e => e.Id == id);
            var colour = _unitofWork.Colours.Get(q => q.Id == id);
            return colour != null;
        }
    }
}
