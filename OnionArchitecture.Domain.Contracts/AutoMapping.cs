using AutoMapper;
using PhoneBook.Domain.Contracts.People.Dtos;
using PhoneBook.Domain.Contracts.Phones.Dtos;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;

namespace PhoneBook.Domain.Contracts
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<AddPersonDto, Person>().ReverseMap();
            CreateMap<PhoneDto, Phone>().ReverseMap();
        }
    }
}
