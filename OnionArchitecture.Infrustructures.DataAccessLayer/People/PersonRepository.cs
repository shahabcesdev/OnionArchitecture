using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Contracts.People;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;
using PhoneBook.Infrustructures.DataAccessLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook.Infrustructures.DataAccessLayer.People
{
    public class PersonRepository : IPersonRepository
    {
        private readonly PhoneBookContext _phoneBookContext;

        public PersonRepository(PhoneBookContext phoneBookContext)
        {
            _phoneBookContext = phoneBookContext;
        }

        public Person AddPerson(Person person)
        {

            person = _phoneBookContext.Add(person).Entity;

            _phoneBookContext.SaveChanges();

            return person;
        }

        public Person AddPhone(List<Phone> phones)
        {
            _phoneBookContext.Phones.AddRange(phones);
            
            _phoneBookContext.SaveChanges();

            return _phoneBookContext.People
                .Where(person=>person.Id==phones.FirstOrDefault().PersonId)
                .Include(p=>p.Phones)
                .FirstOrDefault();
        }

        public void Delete(int id)
        {
            var person = _phoneBookContext.People.Find(id);
            var phones = _phoneBookContext.Phones.Where(phone => phone.PersonId == person.Id).ToList();
            foreach (var phone in phones)
            {
                _phoneBookContext.Remove(phone);
            }
            _phoneBookContext.Remove(person);
            _phoneBookContext.SaveChanges();
        }

        public List<Person> GetAll()
        {
            return _phoneBookContext.People.Select(person => new Person
            {
                Address = person.Address,
                Email = person.Email,
                FirstName = person.FirstName,
                Id = person.Id,
                Image = person.Image,
                LastName = person.LastName,
                Phones = person.Phones.Select(Phone => new Phone
                {
                    Id = Phone.Id,
                    PhoneNumber = Phone.PhoneNumber,
                    PhoneType = Phone.PhoneType
                }).ToList()
            }).ToList();
        }
    }
}
