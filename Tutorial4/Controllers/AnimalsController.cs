using Microsoft.AspNetCore.Mvc;

namespace Tutorial4.Controllers;

[ApiController]
[Route("/animals-controller")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    
    [HttpGet("{id}")]
    public IActionResult GetAnimals(int id)
    {
        return Ok();
    }

    [HttpPost]
    public IActionResult AddAnimal()
    {
        return Created();
    }
}