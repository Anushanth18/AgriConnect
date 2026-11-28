
using Microsoft.AspNetCore.Mvc;
using FarmerApi.Data;
using FarmerApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace FarmerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmerController : ControllerBase
    {
        private readonly FarmerDbContext _context;

        public FarmerController(FarmerDbContext context)
        {
            _context = context;
        }

        // GET: api/Farmer
        [HttpGet]
        public async Task<IActionResult> GetFarmers()
        {
            var farmers = await _context.Farmers.ToListAsync();
            return Ok(farmers);
        }

        // POST: api/Farmer
        [HttpPost]
        public async Task<IActionResult> AddFarmer(Farmer farmer)
        {
            _context.Farmers.Add(farmer);
            await _context.SaveChangesAsync();

            return Ok(farmer);
        }
    }
}
