using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tarjetas.Models.SysTesoreria;

namespace Tarjetas.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UsuariosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<Usuario>> GetAll()
        {
            var result = await _context.Usuarios.OrderBy(x => x.NombreUsuario).ToListAsync();
            if (!result.Any()) { return NoContent(); }
            return Ok(result);
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> GetUser(string id)
        {
            var ExistUsuario = await _context.Usuarios.AnyAsync(x => x.IdUsuario == id);

            if (!ExistUsuario)
            {
                return BadRequest($"Not Exist User: {id}");
            }

            var results =  await _context.Usuarios.Where(x => x.IdUsuario == id).ToListAsync();
            return  Ok(results);
        }

    }


}

public class UserParams
{
    public string usuario { get; set; }

}
