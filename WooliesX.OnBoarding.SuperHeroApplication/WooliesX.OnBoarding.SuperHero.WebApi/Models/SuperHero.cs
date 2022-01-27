using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace WooliesX.OnBoarding.SuperHero.WebApi
{
    public class SuperHero
    {
<<<<<<< Updated upstream
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
=======
<<<<<<< Updated upstream
        [Key]
        public int Id { get; set; }
>>>>>>> Stashed changes
        [StringLength(60,MinimumLength = 3)]
=======
        [BsonId]
        
        public string Id { get; set; }
       
>>>>>>> Stashed changes
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Place { get; set; }
    }
}
