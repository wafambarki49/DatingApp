﻿// <auto-generated />
using System;
using DatingApp.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatingApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191028171808_ExtendedUserClass")]
    partial class ExtendedUserClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065");

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAdded");

                    b.Property<string>("Description");

                    b.Property<bool>("IsMain");

                    b.Property<string>("Url");

                    b.Property<int>("userId");

                    b.HasKey("Id");

                    b.HasIndex("userId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("DatingApp.API.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Interest");

                    b.Property<string>("Introduction");

                    b.Property<DateTime>("LastActive");

                    b.Property<string>("LookingFor");

                    b.Property<string>("gender");

                    b.Property<string>("knownAs");

                    b.Property<byte[]>("passwordHash");

                    b.Property<byte[]>("passwordSalt");

                    b.Property<string>("username");

                    b.HasKey("id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DatingApp.API.Models.Value", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Values");
                });

            modelBuilder.Entity("DatingApp.API.Models.Photo", b =>
                {
                    b.HasOne("DatingApp.API.Models.User", "user")
                        .WithMany("Photos")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
