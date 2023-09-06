﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VanRijtDataBase.Model;

#nullable disable

namespace VanRijtDataBase.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20230906113404_Table2.1")]
    partial class Table21
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("VanRijtDataBase.Model.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("LoginID");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("VanRijtDataBase.Model.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("BedrijfsNaam")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("LoginID")
                        .HasColumnType("int");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("TelefoonNummer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("UserID");

                    b.HasIndex("LoginID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("VanRijtDataBase.Model.User", b =>
                {
                    b.HasOne("VanRijtDataBase.Model.Login", "Login")
                        .WithMany()
                        .HasForeignKey("LoginID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Login");
                });
#pragma warning restore 612, 618
        }
    }
}
