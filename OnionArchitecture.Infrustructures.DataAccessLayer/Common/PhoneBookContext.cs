using Microsoft.EntityFrameworkCore;
using PhoneBook.Domain.Core.People;
using PhoneBook.Domain.Core.Phones;

namespace PhoneBook.Infrustructures.DataAccessLayer.Common
{
    public class PhoneBookContext:DbContext
    {
        public PhoneBookContext(DbContextOptions<PhoneBookContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Phone> Phones { get; set; }
    }
}
