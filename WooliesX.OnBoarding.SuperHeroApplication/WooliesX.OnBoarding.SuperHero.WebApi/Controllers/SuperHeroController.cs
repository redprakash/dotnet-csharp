using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WooliesX.OnBoarding.SuperHero.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SuperHeroController : ControllerBase
    {
        
        private readonly DataContext _context;
        public SuperHeroController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            
            return Ok(await _context.SuperHeroes.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult>Get(int id)
        {
          var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return NotFound("Sorry nothing found");
            return Ok(hero);
        }
        [HttpPost]
        public async Task<IActionResult> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            //return Ok(await _context.SuperHeroes.ToListAsync());
            return Ok(hero);
        } 

        [HttpPut]
        public async Task<IActionResult> UpdateHero(SuperHero request)
        {
           var hero =  await _context.SuperHeroes.FindAsync(request.Id);

            if(hero == null)
                return NotFound("Hero not found ");
            hero.Name = request.Name;
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            await _context.SaveChangesAsync();
            return Ok(request);
        } 

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return NotFound("Hero Not Found");
            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            //return Ok(await _context.SuperHeroes.ToListAsync());
            return Ok("Delted successfully");
        }


    }
}
