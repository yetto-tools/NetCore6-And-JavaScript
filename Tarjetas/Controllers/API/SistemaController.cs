using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarjetas.Models.SysTesoreria;

namespace Tarjetas.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SistemaController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Sistema>>> Get()
        {
            return await _context.Sistemas.ToListAsync(); // Sistemas.ToListAsync(
        }
    }
}
