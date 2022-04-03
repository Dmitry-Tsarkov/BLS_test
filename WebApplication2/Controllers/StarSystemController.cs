using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;
using System;
using System.Collections.Generic;
using WebApplication2.StarSystemData;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StarSystemController : ControllerBase
    {
        /*
        private Models.StarSystemDBContext _context;
        private Models.StarSystem _starSystem;
        public StarSystemController(StarSystem _starSystem)
        {
            _context = new StarSystemDBContext();
            _starSystem = _starSystem;
        }
        */

        private IStarSystemData _starSystemData;
        public StarSystemController(IStarSystemData starSystemData)
        {
            _starSystemData = starSystemData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetStarSystems()
        {
            return Ok(_starSystemData.GetStarSystems());
            //return _starSystemData.GetStarSystems();
            //return _context.StarSystems.ToList();
        }
        
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetStarSystem(Guid id)
        {
            var starSystem = _starSystemData.GetStarSystem(id);

            if(starSystem != null)
            {
                return Ok(starSystem);
            }

            return NotFound($"Star system with id {id} not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateStarSystem(StarSystem starSystem)
        {
            _starSystemData.AddStarSystem(starSystem);
            return Created(
                HttpContext.Request.Scheme
                + "://"
                + HttpContext.Request.Host
                + HttpContext.Request.Path
                + "/"
                + starSystem.id,
                starSystem
            );
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteStarSystem(Guid id)
        {
            var starSystem = _starSystemData.GetStarSystem(id);

            if (starSystem != null) 
            {
                _starSystemData.DeleteStarSystem(starSystem);
                return Ok();
            }
            return NotFound($"Star system with id {id} not found");
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditStarSystem(Guid id, StarSystem starSystem)
        {
            var existingStarSystem = _starSystemData.GetStarSystem(id);
            if (starSystem != null)
            {
                starSystem.id = existingStarSystem.id;
                _starSystemData.EditStarSystem(starSystem);
                return Ok();
            }

            return NotFound($"Star system with id {id} not found");
        }




        /*
        [HttpGet(Name = "GetStarSystem")]

        public IEnumerable<Models.StarSystem> Get()
        { 
            using (var _context = new Models.StarSystemDBContext())
            { 
                //CREATE
                //Models.StarSystem starSystem = new Models.StarSystem();
                //starSystem.name = "test";

                //_context.StarSystems.Add(starSystem);

                //_context.SaveChanges();
                

                //READ
                //return _context.StarSystems.ToList();


                //UPDATE
                //Models.StarSystem starSystem = _context.StarSystems.FirstOrDefault();
                //starSystem.name = "new test";

                // _context.SaveChanges();

                //return _context.StarSystems.ToList


                //DELETE
                Models.StarSystem starSystem = _context.StarSystems.FirstOrDefault();

                _context.StarSystems.Remove(starSystem);
                _context.SaveChanges();
                return _context.StarSystems.ToList();

            }

            return new List<Models.StarSystem>();
        }
        */
    }
}