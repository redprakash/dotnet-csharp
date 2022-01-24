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
        public async Task<ActionResult<SuperHero>>Get(int id)
        {
          var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return BadRequest("Sorry nothing found");
            return Ok(hero);
        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero hero)
        {
            _context.SuperHeroes.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        } 

        [HttpPut]
        public async Task<ActionResult<List<SuperHero>>> UpdateHero(SuperHero request)
        {
           var hero =  await _context.SuperHeroes.FindAsync(request.Id);

            hero.Name = request.Name;
            if(hero == null)
                return BadRequest("Hero not found ");
            hero.FirstName = request.FirstName;
            hero.LastName = request.LastName;
            hero.Place = request.Place;
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        } 

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHero>>> DeleteHero(int id)
        {
            var hero = await _context.SuperHeroes.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero Not Found");
            _context.SuperHeroes.Remove(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.SuperHeroes.ToListAsync());
        }


    }
}
