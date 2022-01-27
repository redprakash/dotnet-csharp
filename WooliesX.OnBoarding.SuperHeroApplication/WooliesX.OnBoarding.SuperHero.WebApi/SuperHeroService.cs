using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace WooliesX.OnBoarding.SuperHero.WebApi
{
    public class SuperHeroService
    {
        private readonly IMongoCollection<SuperHero> _superhero;
        public SuperHeroService(IOptions<SuperHeroesDatabaseSettings> options)
        {
            var mongoClient = new MongoClient(options.Value.ConnectionString);
            _superhero = mongoClient.GetDatabase(options.Value.DatabaseName)
                .GetCollection<SuperHero>(options.Value.SuperHeroCollectionName);
        }
        public async Task<List<SuperHero>> Get() =>
            await _superhero.Find(_ => true).ToListAsync();
        public async Task<SuperHero> Get(string id) =>
               await _superhero.Find(sh => sh.Id == id).FirstOrDefaultAsync();

        public async Task AddHero(SuperHero hero) =>
            await _superhero.InsertOneAsync(hero);
        public async Task UpdateHero(string id, SuperHero request) =>
        
            await _superhero.ReplaceOneAsync(sh => sh.Id == id, request);
        public async Task DeleteHero(string id) =>
        
            await _superhero.DeleteOneAsync(sh => sh.Id == id);
        
        
    }
}
