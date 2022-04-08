using Microsoft.AspNetCore.Mvc;
using RestWithAspNet.Models;
using RestWithAspNet.Services;

namespace RestWithAspNet.Controllers;

[ApiController]
[Route("api/[controller]")]
public class personController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<personController> _logger;
    private readonly IPersonService _PersonService;

    public personController(ILogger<personController> logger, IPersonService personService)
    {
        _logger = logger;
        _PersonService = personService;
    }

    [HttpGet("{id}")]
    public IActionResult Get(long id){
        var person = _PersonService.FindById(id);
        if(person == null) return NotFound();
        return Ok(person);
    }
    [HttpGet]
    public IActionResult Get()
    {   
        return Ok(_PersonService.FindAll());
    }
     [HttpPost]
    public IActionResult post([FromBody]Person person){
       
        if(person == null) return BadRequest();
        return Ok(_PersonService.Create(person));
    }
     [HttpPut]
    public IActionResult put([FromBody]Person person){
       
        if(person == null) return BadRequest();
        return Ok(_PersonService.update(person));
    }

    [HttpDelete("{id}")]
    public IActionResult delete(long id){
         _PersonService.Delete(id);
        return NoContent();
    }
    
}
