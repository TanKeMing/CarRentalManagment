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
    public class CustomersController : ControllerBase
    {
        //Refactored
        //private readonly ApplicationDbContext _context;
        private readonly IUnitOfWork _unitofWork;
        //Refactored


        //public CustomersController(ApplicationDbContext context)
        public CustomersController(IUnitOfWork unitOfWork)
        {
            //Refactored
            //_context = context;
            _unitofWork = unitOfWork;

        }

        // GET: api/Customers
        [HttpGet]
        //Refactored
        //public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        public async Task<IActionResult> GetCustomers()
        {
            //Refactored
            //return await _context.Customers.ToListAsync();
            var customers = await _unitofWork.Customers.GetAll();
            return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        //Refactored
        //public async Task<ActionResult<Customer>> GetCustomer(int id)
        public async Task<IActionResult> GetCustomer(int id)
        {
            //var customer = await _context.Customers.FindAsync(id);
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }
            //Refactored
            //_context.Entry(customer).State = EntityState.Modified;
            _unitofWork.Customers.Update(customer);


            try
            {
                //await _context.SaveChangesAsync();
                await _unitofWork.Save(HttpContext);

            }
            catch (DbUpdateConcurrencyException)
            {
                //Refactored
                //if (!CustomerExists(id))
                if (!await CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            //_context.Customers.Add(customer);
            //await _context.SaveChangesAsync();
              await _unitofWork.Customers.Insert(customer);
              await _unitofWork.Save(HttpContext);


            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            //var customer = await _context.Customers.FindAsync(id);
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            //_context.Customers.Remove(customer);
            //await _context.SaveChangesAsync();
            await _unitofWork.Customers.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        //private bool CustomerExists(int id)
        private async Task<bool> CustomerExists(int id)
        {
            //return _context.Customers.Any(e => e.Id == id);
            var customer = _unitofWork.Customers.Get(q => q.Id == id);
            return customer != null;
        }
    }
}
