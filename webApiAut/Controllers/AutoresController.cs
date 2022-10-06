using Microsoft.AspNetCore.Mvc;
using webApiAut.Entidades;

namespace webApiAut.Controllers
{
    [ApiController]
    [Route("api/autores")]

    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor() { Id = 1, Nombre = "Adrian" },
                new Autor() { Id = 2, Nombre = "Eduardo" }
            };
            }
    }
}
