using PhoneBook.Domain.Contracts.Phones.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.People.Dtos
{
    public class AddPersonDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public List<PhoneDto> Phones { get; set; }
    }
}
