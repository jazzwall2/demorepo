using Microsoft.EntityFrameworkCore;

namespace demowebapp.Models
{
    public class PersonContext : DbContext
    {
        public PersonContext (DbContextOptions<PersonContext> options) : base(options)
        {

        }
        public DbSet<demowebapp.Models.Person> Persons {get; set;}
    }
}