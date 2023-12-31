﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LifeGuides.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20231027085835_Start")]
    partial class Start
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LifeGuides.Models.Article", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("authorId")
                        .HasColumnType("integer");

                    b.Property<string>("description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<int>("dislikesId")
                        .HasColumnType("integer");

                    b.Property<int>("likesId")
                        .HasColumnType("integer");

                    b.Property<string>("text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("id");

                    b.HasIndex("authorId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("LifeGuides.Models.Book", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<int>("authorid")
                        .HasColumnType("integer");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("id");

                    b.HasIndex("authorid");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("LifeGuides.Models.BooksAuthor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("id");

                    b.ToTable("BooksAuthors");
                });

            modelBuilder.Entity("LifeGuides.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("id"));

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("nickname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<DateTime>("registrationDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("subscribersId")
                        .HasColumnType("integer");

                    b.Property<int>("subscribesId")
                        .HasColumnType("integer");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LifeGuides.Models.Article", b =>
                {
                    b.HasOne("LifeGuides.Models.User", "author")
                        .WithMany("Articles")
                        .HasForeignKey("authorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");
                });

            modelBuilder.Entity("LifeGuides.Models.Book", b =>
                {
                    b.HasOne("LifeGuides.Models.BooksAuthor", "author")
                        .WithMany()
                        .HasForeignKey("authorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("author");
                });

            modelBuilder.Entity("LifeGuides.Models.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
