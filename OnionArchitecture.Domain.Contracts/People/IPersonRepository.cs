using PhoneBook.Domain.Contracts.Common;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.People
{
    public interface IPersonRepository
    {
        Person AddPerson(Person person);
        List<Person> GetAll();
        void Delete(int id);
        Person AddPhone(List<Phone> phones);
    }
}
