using ElectricShop.Models;
using ElectricShop.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ElectricShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OperationSystemController : ControllerBase
    {
        private readonly ElectricDbContext _context;

        public OperationSystemController(ElectricDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<ActionResult> AddNewOSystem(AddOsystemDto addOsystemDto)
        {
            try
            {
                var osystem = new OperationSystem()
                {
                    Name = addOsystemDto.Name,
                    Version = addOsystemDto.Version
                };

                if (osystem != null)
                {
                    await _context.operationSystems.AddAsync(osystem);
                    await _context.SaveChangesAsync();

                    return Ok(new { message = "Sikeres hozzáadás", result = osystem });
                }

                return StatusCode(404, new { message = "Sikertelen hozzáadás", result = osystem });

            }
            catch (Exception ex)
            {

                return StatusCode(400, new { message = ex.Message, result = "" });

            }
        }
    }
}
