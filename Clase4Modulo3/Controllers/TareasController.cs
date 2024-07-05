using Clase4Modulo3.Domain.Entities;
using Clase4Modulo3.Exceptions;
using Clase4Modulo3.Extensions;
using Clase4Modulo3.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Clase4Modulo3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {

        private readonly ITareasService _tareaService;
        public TareasController(ITareasService tareaService)
        {
            _tareaService = tareaService;
        }
        [HttpGet]
        public async Task<IActionResult> Get() 
        {
            //metodos de extension
            string nombre = "Alejandro";
            nombre.Mayusculas();


             var result = await _tareaService.GetTareaAsync();

            return Ok(result);
            
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] Tarea request) 
        {
            
           var result =  await _tareaService.AddTareaAsync(request);
            return Ok();
        }

       
    }
}
