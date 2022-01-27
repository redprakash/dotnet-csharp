
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace WooliesX.OnBoarding.SuperHero.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SuperHeroController : ControllerBase
    {

       

        [HttpGet]
        public async Task<ActionResult> Get(SuperHeroService superHeroService)
        {
            await superHeroService.Get();
            return Ok();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>Get(string id)
        {
            //var hero = await _superhero.Find(sh => sh.Id == id).FirstOrDefaultAsync();
           // if (hero == null)
                return NotFound("Sorry nothing found");
            //return Ok(hero);
        }
        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHeroService superHeroService,SuperHero hero)
        {
           await superHeroService.AddHero(hero);
           return Ok();
        } 

        [HttpPut]
        public async Task<IActionResult> UpdateHero(string id,SuperHero request)
        {
           //await _superhero.ReplaceOneAsync(sh=>sh.Id == id, request);
            return Ok(request);
            
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(string id)
        {
           // await _superhero.DeleteOneAsync(sh=>sh.Id == id);
            return Ok("Delted successfully");
        }


    }
}
