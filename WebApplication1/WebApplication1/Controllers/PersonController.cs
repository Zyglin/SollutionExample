using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        

        public PersonController()
        {
        }

        /// <summary>
        /// Создаёт новых юзеров
        /// </summary>
        /// <remarks>
        /// Пример запроса:
        ///
        ///     POST /createPerson
        ///     {
        ///        "count" : 12, 
        ///     }
        ///
        /// </remarks>
        /// <param name="count">Число которое показывает сколько юзеров нужно создать </param>
        /// <returns></returns>
        /// <response code="200">Успешное выполнение</response>
        /// <response code="500">Ошибка API</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost(Name = "СreatePerson")]
        public IEnumerable<Person> CreatePerson(int count)
        {
            List<Person> users = HelperFunctions.GenerateRandomUsers(count);
            return users;
        }
    }
}
