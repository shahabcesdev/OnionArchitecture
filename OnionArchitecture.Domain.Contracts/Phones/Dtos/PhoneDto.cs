using PhoneBook.Domain.Core.Phones;
using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Domain.Contracts.Phones.Dtos
{
    public class PhoneDto
    {
        public string PhoneNumber { get; set; }
        public PhoneType PhoneType { get; set; }
    }
}
