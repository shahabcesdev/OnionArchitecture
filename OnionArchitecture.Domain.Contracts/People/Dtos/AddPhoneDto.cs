using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.People.Dtos
{
    public class AddPhoneDto
    {
        public int PersonId { get; set; }
        public string[] Phones { get; set; }
    }
}
