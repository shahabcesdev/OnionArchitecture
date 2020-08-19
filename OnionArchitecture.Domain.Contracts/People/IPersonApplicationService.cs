using PhoneBook.Domain.Contracts.Common;
using PhoneBook.Domain.Contracts.People.Dtos;
using PhoneBook.Domain.Contracts.Phones.Dtos;
using PhoneBook.Domain.Core.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.People
{
    public interface IPersonApplicationService : IApplicationService
    {
        Person AddPerson(AddPersonDto addPersonDto);
        void Delete(int id);
        List<Person> GetAll();
        Person AddPhone(AddPhoneDto addPhoneDto);
    }
}
