using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using jlthompson.tomo_netcoreApi.Data;

namespace jlthompson.tomonetcoreApi.Migrations
{
    [DbContext(typeof(PrimaryDbContext))]
    [Migration("20181003063709_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1");

            modelBuilder.Entity("jlthompson.tomo_netcoreApi.Models.UserProfiles", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department");

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Team");

                    b.HasKey("UserId");

                    b.ToTable("UserProfiles");
                });
        }
    }
}
