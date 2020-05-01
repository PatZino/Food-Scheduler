﻿// <auto-generated />
using FoodPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodPlanner.Migrations
{
    [DbContext(typeof(FoodPlannerContext))]
    [Migration("20200426160314_Fp1121")]
    partial class Fp1121
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0-preview1.19506.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FoodPlanner.Models.GrainDishes.GrainDish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GrainDishes");
                });

            modelBuilder.Entity("FoodPlanner.Models.LightFood.LightFood", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LightFood");
                });

            modelBuilder.Entity("FoodPlanner.Models.LightFood.LightFoodNutrient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("LightFoodMainIngredient")
                        .HasColumnType("int");

                    b.Property<int>("LightFoodName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("lightFoodNutrients");
                });

            modelBuilder.Entity("FoodPlanner.Models.MainIngredients.MainIngredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClassOfFood")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MainIngredients");
                });

            modelBuilder.Entity("FoodPlanner.Models.SoupCategory.GrainDishSoup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoupName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GrainDishSoup");
                });

            modelBuilder.Entity("FoodPlanner.Models.SoupCategory.SwallowSoup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SwallowSoupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SwallowSoup");
                });

            modelBuilder.Entity("FoodPlanner.Models.SoupNutrients.GrainDishNutrient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GrainName")
                        .HasColumnType("int");

                    b.Property<int>("KaroMainIngredientsId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GrainDishNutrient");
                });

            modelBuilder.Entity("FoodPlanner.Models.Soups.Soup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Soups");
                });

            modelBuilder.Entity("FoodPlanner.Models.Swallows.Swallow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Swallows");
                });

            modelBuilder.Entity("FoodPlanner.Models.Swallows.SwallowNutrient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MainIngredientsId")
                        .HasColumnType("int");

                    b.Property<int>("SwallowName")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("SwallowNutrient");
                });
#pragma warning restore 612, 618
        }
    }
}
