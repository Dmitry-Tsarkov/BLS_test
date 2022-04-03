using WebApplication2.Models;
using System;
using System.Collections.Generic;

namespace WebApplication2.StarSystemData
{
    public interface IStarSystemData
    {
        List<StarSystem> GetStarSystems();

        StarSystem GetStarSystem(Guid id);

        StarSystem AddStarSystem(StarSystem starSystem);

        void DeleteStarSystem(StarSystem starSystem);

        StarSystem EditStarSystem(StarSystem starSystem);

    }
}
