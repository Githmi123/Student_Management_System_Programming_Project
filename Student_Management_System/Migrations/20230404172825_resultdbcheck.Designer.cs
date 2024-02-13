﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Student_Management_System;

#nullable disable

namespace Student_Management_System.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20230404172825_resultdbcheck")]
    partial class resultdbcheck
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Student_Management_System.Models.Module", b =>
                {
                    b.Property<int>("ModuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Credit")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ModuleName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ModuleID");

                    b.HasIndex("StudentId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("Student_Management_System.Models.Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Grade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ModuleID")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("Student_Management_System.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Student_Management_System.Models.Module", b =>
                {
                    b.HasOne("Student_Management_System.Models.Student", null)
                        .WithMany("Modules")
                        .HasForeignKey("StudentId");
                });

            modelBuilder.Entity("Student_Management_System.Models.Student", b =>
                {
                    b.Navigation("Modules");
                });
#pragma warning restore 612, 618
        }
    }
}
