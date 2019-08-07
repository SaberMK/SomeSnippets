﻿// <auto-generated />
using System;
using CodeSnippets.Database.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeSnippets.Database.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20190806160916_AddAccessLevelToUser")]
    partial class AddAccessLevelToUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeSnippets.Entities.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte>("AccessLevel")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue((byte)0);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<DateTime>("RegistrationDate");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            AccessLevel = (byte)2,
                            Password = "TVRJeg==",
                            RegistrationDate = new DateTime(2019, 8, 6, 19, 9, 16, 452, DateTimeKind.Local).AddTicks(6864),
                            Username = "SaberMK"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
