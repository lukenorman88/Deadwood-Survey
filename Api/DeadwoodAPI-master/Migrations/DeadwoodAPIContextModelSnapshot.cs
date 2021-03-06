﻿// <auto-generated />
using DeadwoodAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DeadwoodAPI.Migrations
{
    [DbContext(typeof(DeadwoodAPIContext))]
    partial class DeadwoodAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DeadwoodAPI.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("deadwoodColour");

                    b.Property<double>("deadwoodDiameter");

                    b.Property<double>("deadwoodLenght");

                    b.Property<string>("deadwoodSoftness");

                    b.Property<string>("deadwoodSpecies");

                    b.Property<string>("deadwoodStandingOrLying");

                    b.Property<bool>("enviroGroup");

                    b.Property<string>("faunaInDeadwood");

                    b.Property<string>("faunaOnDeadwood");

                    b.Property<string>("floraOnDeadwood");

                    b.Property<string>("gridRef");

                    b.Property<string>("holesInDeadwood");

                    b.Property<string>("latitude");

                    b.Property<string>("longitude");

                    b.Property<double>("pencilDepth");

                    b.Property<bool>("performedSurveyBefore");

                    b.Property<int>("stateOfDecay");

                    b.Property<string>("woodlandName");

                    b.Property<double>("woodlandSize");

                    b.HasKey("Id");

                    b.ToTable("Survey");
                });
#pragma warning restore 612, 618
        }
    }
}
