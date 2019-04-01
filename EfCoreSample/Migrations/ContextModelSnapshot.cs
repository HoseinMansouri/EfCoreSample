﻿// <auto-generated />
using EfCoreSample;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EfCoreSample.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EfCoreSample.Course", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("PersonId");

                    b.HasKey("id");

                    b.HasIndex("PersonId");

                    b.ToTable("courses");

                    b.HasData(
                        new
                        {
                            id = 1,
                            Name = "فیزیک هسته ای",
                            PersonId = 1
                        },
                        new
                        {
                            id = 2,
                            Name = "اختر فیزیک",
                            PersonId = 1
                        });
                });

            modelBuilder.Entity("EfCoreSample.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("people");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FirstName = "Atiyeh",
                            LastName = "Ahmadi"
                        },
                        new
                        {
                            Id = 2,
                            FirstName = "Hosein",
                            LastName = "Mansouri"
                        });
                });

            modelBuilder.Entity("EfCoreSample.Course", b =>
                {
                    b.HasOne("EfCoreSample.Person", "Person")
                        .WithMany("courses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
