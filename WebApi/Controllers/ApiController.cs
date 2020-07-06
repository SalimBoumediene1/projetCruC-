using DatabaseToolsNS.MariaDb;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Data;
using WebApi.Crud;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        [Route("test")]
        public string Test([FromQuery] string myValue)
        {
            return myValue;
        }

        [HttpGet]
        [Route("addition")]
        public int Addition([FromQuery] int value1, [FromQuery] int value2)
        {
            return value1 + value2;
        }

        [HttpGet]
        [Route("testBddConnection")]
        public bool testBddConnection()
        {
            return DatabaseConnection.GetInstance().SqlConnection.State.Equals(ConnectionState.Open);
        }

        [HttpGet]
        [Route("formationGetById")]
        public Formation FormationGetById([FromQuery] int id)
        {
            return FormationCrud.GetById(id);
        }

        [HttpGet]
        [Route("formationGetIntListOptimise")]
        public List<Formation> formationGetIntListOptimise([FromQuery] bool actif)
        {
            return FormationCrud.GetListOptimise(actif);
        }

        [HttpGet]
        [Route("formationGetIntList")]
        public List<Formation> formationGetIntList([FromQuery] bool actif)
        {
            return FormationCrud.GetByActif(actif);
        }

        [HttpGet]
        [Route("coursGetIntList")]
        public List<Cours> CoursGetIntList([FromQuery] int id)
        {
            return CoursCrud.GetById(id);
        }

        [HttpPost]
        [Route("coursInsert")]
        public Cours CoursInsert([FromBody] Cours cours)
        {
            return CoursCrud.Insert(cours);
        }

        [HttpGet]
        [Route("deleteCoursById")]
        public int DeleteCoursById([FromQuery] int id)
        {
            return CoursCrud.Delete(id);
        }
    }
}