using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.StarSystemData
{
    public class SqlStarSystemData : IStarSystemData
    {
        private StarSystemDBContext _starSystemContext;
        public SqlStarSystemData(StarSystemDBContext context)
        {
            _starSystemContext = context;
        }
        public StarSystem AddStarSystem(StarSystem starSystem)
        {
            throw new NotImplementedException();
        }

        public void DeleteStarSystem(StarSystem starSystem)
        {
            throw new NotImplementedException();
        }

        public StarSystem EditStarSystem(StarSystem starSystem)
        {
            throw new NotImplementedException();
        }

        public StarSystem GetStarSystem(Guid id)
        {
            var starSystem = _starSystemContext.StarSystems.Find(id);
            return starSystem;
        }

        public List<StarSystem> GetStarSystems()
        {
            return _starSystemContext.StarSystems.ToList();
        }
    }
}
