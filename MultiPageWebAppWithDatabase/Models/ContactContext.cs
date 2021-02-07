using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection.XmlEncryption;
using Microsoft.EntityFrameworkCore;
using ContactList.Models;

namespace Ch04ContactList.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Note>().HasData(
                new Note { NoteId = "F", Name = "Met through a friend." },
                new Note { NoteId = "H", Name = "Met while hiking." },
                new Note { NoteId = "M", Name = "Met while making jewelry." },
                new Note { NoteId = "R", Name = "Met at a restaurant." },
                new Note { NoteId = "W", Name = "Met at work." }

            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    Name = "John Denver",
                    PhoneNumber = "888-555-1212",
                    AddressLine1 = "123 Main Street",
                    AddressLine2 = "Apt #2B",
                    City = "Ankeny",
                    State = "Iowa",
                    ZipCode = "50021-0000",
                    NoteId = "F"
                },
                new Contact
                {
                    ContactId = 2,
                    Name = "Jason Priestly",
                    PhoneNumber = "888-555-4444",
                    AddressLine1 = "456 First Street",
                    AddressLine2 = " ",
                    City = "Ankeny",
                    State = "Iowa",
                    ZipCode = "50021-0456",
                    NoteId = "R"
                },
                new Contact
                {
                    ContactId = 3,
                    Name = "Sally Fields",
                    PhoneNumber = "888-555-5555",
                    AddressLine1 = "789 Elm Road",
                    AddressLine2 = "Unit 5A",
                    City = "Ankeny",
                    State = "Iowa",
                    ZipCode = "50023-0000",
                    NoteId = "W"
                },
                new Contact
                {
                    ContactId = 4,
                    Name = "Burt Reynolds",
                    PhoneNumber = "888-555-6666",
                    AddressLine1 = "1500 West Lincoln Street",
                    AddressLine2 = "",
                    City = "Ankeny",
                    State = "Iowa",
                    ZipCode = "50021-0000",
                    NoteId = "M"
                }
            );
        }
    }
}
