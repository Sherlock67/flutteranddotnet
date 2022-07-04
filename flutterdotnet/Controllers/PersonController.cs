using flutterdotnet.Data;
using flutterdotnet.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace flutterdotnet.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ApplicationDbContext db;
        public PersonController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [HttpPost("CreateNewPerson")]
        public async Task<Object> CreateNewPerson(Person person)
        {
            try
            {
                await db.Persons.AddAsync(person);
                db.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

    }
}
