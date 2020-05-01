

using FoodPlanner.Models.GrainDishes;
using FoodPlanner.Models.MainIngredients;
using FoodPlanner.Models.Soups;
using FoodPlanner.Models.Swallows;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodPlanner.Models.LightFood;
using FoodPlanner.Models.SoupNutrients;
using FoodPlanner.Models.SoupCategory;
using FoodPlanner.Models.UserFoodSelectionCategory;

namespace FoodPlanner.Models
{
    public class FoodPlannerContext: DbContext
    {
        //internal object LightFoods;

        public FoodPlannerContext(DbContextOptions<FoodPlannerContext> options)
           : base(options)
        {
        }

        public DbSet<Soup> Soups { get; set; }
        public DbSet<Swallow> Swallows { get; set; }
        public DbSet<LightFoodNutrient> lightFoodNutrients { get; set; }
        public DbSet<MainIngredient> MainIngredients { get; set; }
        public DbSet<GrainDish> GrainDishes { get; set; }
        
        public DbSet<FoodPlanner.Models.LightFood.LightFood> LightFood { get; set; }
        public DbSet<GrainDishNutrient> GrainDishNutrient { get; set; }
        public DbSet<SwallowNutrient> SwallowNutrient { get; set; }
        public DbSet<GrainDishSoup> GrainDishSoup { get; set; }
        public DbSet<SwallowSoup> SwallowSoup { get; set; }
        public DbSet<FoodPlanner.Models.UserFoodSelectionCategory.UserGrainDishSelection> UserGrainDishSelection { get; set; }
        public DbSet<FoodPlanner.Models.UserFoodSelectionCategory.UserSoupSelection> UserSoupSelection { get; set; }
        public DbSet<FoodPlanner.Models.UserFoodSelectionCategory.UserSwallowSelection> UserSwallowSelection { get; set; }
        public DbSet<FoodPlanner.Models.UserFoodSelectionCategory.UserLightFoodSelection> UserLightFoodSelection { get; set; }
    }

}
