using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Games.Api.Models;

namespace Games.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterController : ControllerBase
{

    static List<Character> characters = new List<Character> { 
        new() {Name="Mario", Game="Super Mario Bross", Role="Hero"},
        new() {Name="Link", Game="la leyenda de zelta", Role="Hero"},
        new() {Name="Bowser", Game="Super Mario Bross", Role="villain"},

    };

    [HttpGet]
    public async Task<ActionResult<List<Character>>> getCharacter()=> await Task.FromResult(Ok(characters));

}
