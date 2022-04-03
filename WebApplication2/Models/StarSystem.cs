using WebApplication2.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class StarSystem
    {
        [Key]
        public Guid id { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string name { get; set; }





        /*
        //В репозиторий 
        private Models.StarSystemDBContext _context;
        public StarSystem()
        {
            _context = new StarSystemDBContext();
        }

        private List<StarSystem> starSystems = new List<StarSystem>()
        {
            new StarSystem()
            {
                id = Guid.NewGuid(),
                age = 27,
                name = "test"
            },
            new StarSystem()
            {
                id = Guid.NewGuid(),
                age = 28,
                name = "test2"
            },
        };

        public List<StarSystem> GetStarSystems()
        {
            return starSystems;
        }

        public StarSystem GetStarSystem(Guid id)
        {
            return starSystems.SingleOrDefault(s => s.id == id);
        }

        public StarSystem AddStarSystem(StarSystem starSystem)
        {
            starSystem.id = Guid.NewGuid(); 
            starSystems.Add(starSystem);
            return starSystem;
        }

        public void DeleteStarSystem(StarSystem starSystem)
        {
            starSystems.Remove(starSystem);
        }
        public StarSystem EditStarSystem(StarSystem starSystem)
        {
            var existingStarSystem = GetStarSystem(starSystem.id);

            existingStarSystem.age = starSystem.age;
            existingStarSystem.name = starSystem.name;

            return existingStarSystem;
        }       
        */
    }
}
