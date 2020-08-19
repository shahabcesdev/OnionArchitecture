using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain.Contracts.People;
using PhoneBook.Domain.Contracts.People.Dtos;

namespace PhoneBook.EndPoints.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly IPersonApplicationService _personApplicationService;

        public PeopleController(IPersonApplicationService personApplicationService)
        {
            _personApplicationService = personApplicationService;
        }
        [HttpPost]
        public IActionResult AddPerson(AddPersonDto addPersonDto)
        {
            var person = _personApplicationService.AddPerson(addPersonDto);
            return Ok(person);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var allPeople = _personApplicationService.GetAll();
            return Ok(allPeople);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _personApplicationService.Delete(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult AddPhone(AddPhoneDto addPhoneDto)
        {
            var person = _personApplicationService.AddPhone(addPhoneDto);
            return Ok(person);
        }
    }
}
