using System.ComponentModel.DataAnnotations;

namespace WooliesX.OnBoarding.SuperHero.WebApi
{
    public class SuperHero
    {
        [Key]
        public int Id { get; set; }
        [StringLength(60,MinimumLength = 3)]
        public string? Name { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Place { get; set; }
    }
}
