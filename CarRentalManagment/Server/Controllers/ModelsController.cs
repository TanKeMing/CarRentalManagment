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
    public class ModelsController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        //Refactored


        //public ModelsController(ApplicationDbContext context)
        public ModelsController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitofWork = unitOfWork;

        }

        // GET: api/Models
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Model>>> GetModels()
        public async Task<IActionResult> GetModels()
        {
            //Refactored
            //return await _context.Models.ToListAsync();
            var models = await _unitofWork.Models.GetAll();
            return Ok(models);
        }

        // GET: api/Models/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Model>> GetModel(int id)
        public async Task<IActionResult> GetModel(int id)
        {
            //var model = await _context.Models.FindAsync(id);
            var model = await _unitofWork.Models.Get(q => q.Id == id);

            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        // PUT: api/Models/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModel(int id, Model model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(model).State = EntityState.Modified;
            _unitofWork.Models.Update(model);


            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!ModelExists(id))
                if (!await ModelExists(id))
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

        // POST: api/Models
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Model>> PostModel(Model model)
        {
            //_context.Models.Add(model);
            //await _context.SaveChangesAsync();
              await _unitofWork.Models.Insert(model);
              await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetModel", new { id = model.Id }, model);
        }

        // DELETE: api/Models/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModel(int id)
        {
            //var model = await _context.Models.FindAsync(id);
            var model = await _unitofWork.Models.Get(q => q.Id == id);
            if (model == null)
            {
                return NotFound();
            }

            //_context.Models.Remove(model);
            //await _context.SaveChangesAsync();
            await _unitofWork.Models.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool ModelExists(int id)
        private async Task<bool> ModelExists(int id)
        {
            //return _context.Models.Any(e => e.Id == id);
            var model = _unitofWork.Models.Get(q => q.Id == id);
            return model != null;
        }
    }
}
