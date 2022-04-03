using WebApplication2.Models;
using System;
using System.Collections.Generic;

namespace WebApplication2.StarSystemData
{
    public class MockStarSystemData : IStarSystemData
    {
          private List<StarSystem> starSystems = new List<StarSystem>()
        {
            new StarSystem()
            {
                id = Guid.NewGuid(),
                age = 27,
                name = "First Star System"
            },
            new StarSystem()
            {
                id = Guid.NewGuid(),
                age = 28,
                name = "Second star system"
            },
        };
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

        public StarSystem GetStarSystem(Guid id)
        {
            return starSystems.SingleOrDefault(s => s.id == id);
        }

        public List<StarSystem> GetStarSystems()
        {
            return starSystems;
        }
    }
}
