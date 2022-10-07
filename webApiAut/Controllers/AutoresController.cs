using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webApiAut.Entidades;

namespace webApiAut.Controllers
{
    [ApiController]
    [Route("api/autores")]

    public class AutoresController: ControllerBase
    {
        private readonly AplicationDbContext context;

        public AutoresController(AplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Autor>>> Get()
        {
            return await context.Autores.ToListAsync();
           
            }

        [HttpPost] 
        public async Task<ActionResult> Post(Autor autor)
        {
            context.Add(autor);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
