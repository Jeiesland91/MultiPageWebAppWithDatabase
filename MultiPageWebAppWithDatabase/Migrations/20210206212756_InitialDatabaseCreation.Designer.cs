﻿// <auto-generated />
using Ch04ContactList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ContactList.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20210206212756_InitialDatabaseCreation")]
    partial class InitialDatabaseCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContactList.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NoteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("ContactId");

                    b.HasIndex("NoteId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            AddressLine1 = "123 Main Street",
                            AddressLine2 = "Apt #2B",
                            City = "Ankeny",
                            Name = "John Denver",
                            NoteId = "F",
                            PhoneNumber = "888-555-1212",
                            State = "Iowa",
                            ZipCode = "50021-0000"
                        },
                        new
                        {
                            ContactId = 2,
                            AddressLine1 = "456 First Street",
                            AddressLine2 = " ",
                            City = "Ankeny",
                            Name = "Jason Priestly",
                            NoteId = "R",
                            PhoneNumber = "888-555-4444",
                            State = "Iowa",
                            ZipCode = "50021-0456"
                        },
                        new
                        {
                            ContactId = 3,
                            AddressLine1 = "789 Elm Road",
                            AddressLine2 = "Unit 5A",
                            City = "Ankeny",
                            Name = "Sally Fields",
                            NoteId = "W",
                            PhoneNumber = "888-555-5555",
                            State = "Iowa",
                            ZipCode = "50023-0000"
                        },
                        new
                        {
                            ContactId = 4,
                            AddressLine1 = "1500 West Lincoln Street",
                            AddressLine2 = "",
                            City = "Ankeny",
                            Name = "Burt Reynolds",
                            NoteId = "M",
                            PhoneNumber = "888-555-6666",
                            State = "Iowa",
                            ZipCode = "50021-0000"
                        });
                });

            modelBuilder.Entity("ContactList.Models.Note", b =>
                {
                    b.Property<string>("NoteId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("NoteId");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            NoteId = "F",
                            Name = "Met through a friend."
                        },
                        new
                        {
                            NoteId = "H",
                            Name = "Met while hiking."
                        },
                        new
                        {
                            NoteId = "M",
                            Name = "Met while making jewelry."
                        },
                        new
                        {
                            NoteId = "R",
                            Name = "Met at a restaurant."
                        },
                        new
                        {
                            NoteId = "W",
                            Name = "Met at work."
                        });
                });

            modelBuilder.Entity("ContactList.Models.Contact", b =>
                {
                    b.HasOne("ContactList.Models.Note", "Note")
                        .WithMany()
                        .HasForeignKey("NoteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
