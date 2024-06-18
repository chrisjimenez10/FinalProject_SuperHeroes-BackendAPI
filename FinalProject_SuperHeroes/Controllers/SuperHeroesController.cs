using FinalProject_SuperHeroes.Data;
using FinalProject_SuperHeroes.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_SuperHeroes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class SuperHeroesController : ControllerBase //Here, we use ControllerBase Class rather than Controller Class inheritance because it is better suited to handle HTTP Requests and returning serialized data --> Controller Class is more robust and includes features and methods for MVC projects (model-view-controller) where we would need to render server-side data (It is similar to how we used EJS Views to render server side data in Node.js/Express.js)
    {
        private DataContext _context;
        
        public SuperHeroesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHeroes>>> GetAllSuperHeroes()
        {
            var superheroes = await _context.SuperHeroes.ToListAsync();
            return Ok(superheroes);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHeroes>> GetSingleSuperHero(int id)
        {
            var superhero = await _context.SuperHeroes.FindAsync(id);
            if(superhero is null)
                return BadRequest("Superhero not found");

            return Ok(superhero);
        }


        [HttpPost]
        public async Task<ActionResult<SuperHeroes>> AddSuperHeroe(SuperHeroes superhero)
        {
            _context.SuperHeroes.Add(superhero);
            await _context.SaveChangesAsync();
            return Ok(superhero);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHeroes>> EditSuperHero(int id, SuperHeroes updatedSuperhero)
        {
            var dbSuperhero = await _context.SuperHeroes.FindAsync(id);
            if (dbSuperhero is null)
                return BadRequest("Superhero not found");

            dbSuperhero.FirstName = updatedSuperhero.FirstName;
            dbSuperhero.LastName = updatedSuperhero.LastName;
            dbSuperhero.SuperName = updatedSuperhero.SuperName;
            dbSuperhero.SuperPower = updatedSuperhero.SuperPower;
            dbSuperhero.Strength = updatedSuperhero.Strength;
            dbSuperhero.IsTeam = updatedSuperhero.IsTeam;
            dbSuperhero.VillainName = updatedSuperhero.VillainName;

            await _context.SaveChangesAsync();

            return Ok(dbSuperhero);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHeroes>> DeleteSuperHero(int id)
        {
            var superhero = await _context.SuperHeroes.FindAsync(id);
            if (superhero is null)
                return BadRequest("Superhero not found");

            _context.SuperHeroes.Remove(superhero);

            await _context.SaveChangesAsync();

            return Ok("Successfully Deleted Superhero");
        }
        
    }
}
