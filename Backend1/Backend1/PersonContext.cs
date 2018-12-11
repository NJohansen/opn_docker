using System;
using Backend1.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend1
{
    public class PersonContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }

        public PersonContext(DbContextOptions options): base(options) { }

    }
}
