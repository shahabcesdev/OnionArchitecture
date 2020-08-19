using AutoMapper;
using PhoneBook.Domain.Contracts.People;
using PhoneBook.Domain.Contracts.People.Dtos;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Services.ApplicationServices.People
{
    public class PersonApplicationService : IPersonApplicationService
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;

        public PersonApplicationService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public Person AddPerson(AddPersonDto addPersonDto)
        {
            var person = _mapper.Map<Person>(addPersonDto);
            return _personRepository.AddPerson(person);
        }

        public Person AddPhone(AddPhoneDto addPhoneDto)
        {
            List<Phone> phones = new List<Phone>();
            foreach (var phone in addPhoneDto.Phones)
            {
                phones.Add(new Phone
                {
                    PersonId = addPhoneDto.PersonId,
                    PhoneNumber = phone
                });
            }

            return _personRepository.AddPhone(phones);

        }

        public void Delete(int id)
        {
            _personRepository.Delete(id);
        }

        public List<Person> GetAll()
        {
            return _personRepository.GetAll();
        }
    }
}
