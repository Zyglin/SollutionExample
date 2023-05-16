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
        /// ������ ����� ������
        /// </summary>
        /// <remarks>
        /// ������ �������:
        ///
        ///     POST /createPerson
        ///     {
        ///        "count" : 12, 
        ///     }
        ///
        /// </remarks>
        /// <param name="count">����� ������� ���������� ������� ������ ����� ������� </param>
        /// <returns></returns>
        /// <response code="200">�������� ����������</response>
        /// <response code="500">������ API</response>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost(Name = "�reatePerson")]
        public IEnumerable<Person> CreatePerson(int count)
        {
            List<Person> users = HelperFunctions.GenerateRandomUsers(count);
            return users;
        }
    }
}
