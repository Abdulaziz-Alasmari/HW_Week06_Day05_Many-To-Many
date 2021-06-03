﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mvc_ef.Data;

namespace mvc_ef.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210602085101_addSeed_student")]
    partial class addSeed_student
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.Property<int>("studnetsId")
                        .HasColumnType("int");

                    b.Property<int>("teachersId")
                        .HasColumnType("int");

                    b.HasKey("studnetsId", "teachersId");

                    b.HasIndex("teachersId");

                    b.ToTable("StudentTeacher");
                });

            modelBuilder.Entity("mvc_ef.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Empty")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("_RoomType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("mvc_ef.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Fname")
                        .HasColumnType("text");

                    b.Property<string>("Lname")
                        .HasColumnType("text");

                    b.Property<int?>("student_roomId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("student_roomId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "aziz@aziz.aziz",
                            Fname = "Abdulaziz",
                            Lname = "Alasmari"
                        });
                });

            modelBuilder.Entity("mvc_ef.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Teachers");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Email = "0x1337@<(cat domain).wat",
                            FullName = "D7000M Sensei"
                        },
                        new
                        {
                            Id = 3,
                            Email = "0xl33t@<(cat domain).wat",
                            FullName = "Manea Sensei"
                        },
                        new
                        {
                            Id = 4,
                            Email = "0x1337@<(cat domain).wat",
                            FullName = "D7000M Sensei"
                        },
                        new
                        {
                            Id = 5,
                            Email = "0xl33t@<(cat domain).wat",
                            FullName = "Manea Sensei"
                        },
                        new
                        {
                            Id = 6,
                            Email = "0x1337@<(cat domain).wat",
                            FullName = "D7000M Sensei"
                        },
                        new
                        {
                            Id = 7,
                            Email = "0xl33t@<(cat domain).wat",
                            FullName = "Manea Sensei"
                        },
                        new
                        {
                            Id = 8,
                            Email = "0x1337@<(cat domain).wat",
                            FullName = "D7000M Sensei"
                        },
                        new
                        {
                            Id = 9,
                            Email = "0xl33t@<(cat domain).wat",
                            FullName = "Manea Sensei"
                        });
                });

            modelBuilder.Entity("StudentTeacher", b =>
                {
                    b.HasOne("mvc_ef.Models.Student", null)
                        .WithMany()
                        .HasForeignKey("studnetsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mvc_ef.Models.Teacher", null)
                        .WithMany()
                        .HasForeignKey("teachersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("mvc_ef.Models.Student", b =>
                {
                    b.HasOne("mvc_ef.Models.Room", "student_room")
                        .WithMany()
                        .HasForeignKey("student_roomId");

                    b.Navigation("student_room");
                });
#pragma warning restore 612, 618
        }
    }
}
