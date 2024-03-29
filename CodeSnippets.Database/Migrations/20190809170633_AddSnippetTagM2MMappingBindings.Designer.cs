﻿// <auto-generated />
using System;
using CodeSnippets.Database.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeSnippets.Database.Migrations
{
    [DbContext(typeof(CodeSnippetsDbContext))]
    [Migration("20190809170633_AddSnippetTagM2MMappingBindings")]
    partial class AddSnippetTagM2MMappingBindings
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeSnippets.Entities.Entities.Language", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Language");
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.M2MMappings.SnippetTag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("SnippetId");

                    b.Property<long>("TagId");

                    b.HasKey("Id");

                    b.HasIndex("SnippetId");

                    b.HasIndex("TagId");

                    b.ToTable("SnippetTag");
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.Snippet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300);

                    b.Property<long>("LanguageId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(75);

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.HasIndex("UserId");

                    b.ToTable("Snippet");
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.Tag", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.User", b =>
                {
                    b.Property<long>("Id")
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
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.M2MMappings.SnippetTag", b =>
                {
                    b.HasOne("CodeSnippets.Entities.Entities.Snippet", "Snippet")
                        .WithMany("SnippetTags")
                        .HasForeignKey("SnippetId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeSnippets.Entities.Entities.Tag", "Tag")
                        .WithMany("SnippetTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CodeSnippets.Entities.Entities.Snippet", b =>
                {
                    b.HasOne("CodeSnippets.Entities.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CodeSnippets.Entities.Entities.User", "Author")
                        .WithMany("Snippets")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
