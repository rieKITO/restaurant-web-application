using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Data;
public class RestaurantDBContext : DbContext
{
    public DbSet<Dish> Dishes { get; set; } = null!;
    public DbSet<Recipe> Recipes { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Image> Images { get; set; } = null!;

    public RestaurantDBContext(DbContextOptions<RestaurantDBContext> options)
        : base(options)
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();

        //Product dough = new Product() { CaloricValue = 200, Name = "Dough", Weight = 300 };
        //Product mincemeat = new Product() { CaloricValue = 100, Name = "Mincemeat", Weight = 500 };
        //Product cheese = new Product() { CaloricValue = 200, Name = "Cheese", Weight = 400 };
        //Product flour = new Product() { CaloricValue = 200, Name = "Flour", Weight = 100 };
        //Product butter = new Product() { CaloricValue = 300, Name = "Butter", Weight = 100 };
        //Product beet = new Product() { CaloricValue = 300, Name = "Beet", Weight = 100 };
        //Product meat = new Product() { CaloricValue = 500, Name = "Meet", Weight = 300 };
        //Product carrot = new Product() { CaloricValue = 100, Name = "Carrot", Weight = 100 };
        //Product oil = new Product() { CaloricValue = 400, Name = "Oil", Weight = 50 };
        //Product potato = new Product() { CaloricValue = 300, Name = "Potato", Weight = 200 };

        //Dish dumplings = new Dish() { Name = "Dumplings", Weight = 300, RecipeId = 1 };
        //Dish lasange = new Dish() { Name = "Lasagne", Weight = 1000, RecipeId = 2 };
        //Dish borsch = new Dish() { Name = "Borsch", Weight = 400, RecipeId = 3 };

        //Recipe recipe1 = new Recipe()
        //{
        //    CookingTechnology = "Dumplings are cooked for no more than 15 minutes in boiling\n" +
        //    " salted water, vegetable, meat or fish broth, to which a bay leaf and onions are\n" +
        //    " usually added. When the dumplings float to the surface, let them simmer for a few\n" +
        //    " minutes and then remove from the heat.",
        //    CookingTime = 15,
        //    DishId = 1
        //};
        //Recipe recipe2 = new Recipe()
        //{
        //    CookingTechnology = "arrange a layer of pasta sheets,\n" +
        //    "smear the sheets with sauce,\n" +
        //    "mince layer,\n" +
        //    "smear the mince layer with sauce,\n" +
        //    "layer of grated cheese",
        //    CookingTime = 45,
        //    DishId = 2
        //};
        //Recipe recipe3 = new Recipe()
        //{
        //    CookingTechnology = "The peculiarity of cooking borscht is\n" +
        //    "the pre-treatment of vegetables, and again, this applies first of all to beetroot.\n" +
        //    "Beetroot before putting it in the soup can be cooked in several ways: stewing in shredded form,\n" +
        //    "baking or boiling in the peel. As a rule, when pre-cooking beetroot, some acid\n" +
        //    "(table vinegar, lemon juice) is added to the cooking medium in order to preserve the colour.\n" +
        //    "Beetroot is always cooked separately from other vegetables. Onions, carrots and parsley are also\n" +
        //    "usually sautéed separately, followed by tomatoes or tomato paste.",
        //    CookingTime = 60,
        //    DishId = 3
        //};

        //Dishes.AddRange(dumplings, lasange, borsch);
        //Products.AddRange(dough, mincemeat, cheese, flour, butter, beet, meat, carrot, oil, potato);
        //Recipes.AddRange(recipe1, recipe2, recipe3);

        //dumplings.Products.AddRange(new List<Product>() { dough, mincemeat });
        //lasange.Products.AddRange(new List<Product>() { mincemeat, cheese, flour, butter, carrot });
        //borsch.Products.AddRange(new List<Product>() { beet, meat, potato });

        //SaveChanges();
    }

    public RestaurantDBContext()
    {
        //Database.EnsureDeleted();
        //Database.EnsureCreated();

        //Product dough = new Product() { CaloricValue = 200, Name = "Dough", Weight = 300 };
        //Product mincemeat = new Product() { CaloricValue = 100, Name = "Mincemeat", Weight = 500 };
        //Product cheese = new Product() { CaloricValue = 200, Name = "Cheese", Weight = 400 };
        //Product flour = new Product() { CaloricValue = 200, Name = "Flour", Weight = 100 };
        //Product butter = new Product() { CaloricValue = 300, Name = "Butter", Weight = 100 };
        //Product beet = new Product() { CaloricValue = 300, Name = "Beet", Weight = 100 };
        //Product meat = new Product() { CaloricValue = 500, Name = "Meet", Weight = 300 };
        //Product carrot = new Product() { CaloricValue = 100, Name = "Carrot", Weight = 100 };
        //Product oil = new Product() { CaloricValue = 400, Name = "Oil", Weight = 50 };
        //Product potato = new Product() { CaloricValue = 300, Name = "Potato", Weight = 200 };

        //Image image = new Image() { ImageId = 1, ImageTitle = "Title" };

        //Dish dumplings = new Dish() { Name = "Dumplings", Weight = 300, RecipeId = 1, ImageId = 1 };
        //Dish lasange = new Dish() { Name = "Lasagne", Weight = 1000, RecipeId = 2, ImageId = 1 };
        //Dish borsch = new Dish() { Name = "Borsch", Weight = 400, RecipeId = 3, ImageId = 1 };

        //Recipe recipe1 = new Recipe()
        //{
        //    CookingTechnology = "Dumplings are cooked for no more than 15 minutes in boiling\n" +
        //    " salted water, vegetable, meat or fish broth, to which a bay leaf and onions are\n" +
        //    " usually added. When the dumplings float to the surface, let them simmer for a few\n" +
        //    " minutes and then remove from the heat.",
        //    CookingTime = 15,
        //    DishId = 1
        //};
        //Recipe recipe2 = new Recipe()
        //{
        //    CookingTechnology = "arrange a layer of pasta sheets,\n" +
        //    "smear the sheets with sauce,\n" +
        //    "mince layer,\n" +
        //    "smear the mince layer with sauce,\n" +
        //    "layer of grated cheese",
        //    CookingTime = 45,
        //    DishId = 2
        //};
        //Recipe recipe3 = new Recipe()
        //{
        //    CookingTechnology = "The peculiarity of cooking borscht is\n" +
        //    "the pre-treatment of vegetables, and again, this applies first of all to beetroot.\n" +
        //    "Beetroot before putting it in the soup can be cooked in several ways: stewing in shredded form,\n" +
        //    "baking or boiling in the peel. As a rule, when pre-cooking beetroot, some acid\n" +
        //    "(table vinegar, lemon juice) is added to the cooking medium in order to preserve the colour.\n" +
        //    "Beetroot is always cooked separately from other vegetables. Onions, carrots and parsley are also\n" +
        //    "usually sautéed separately, followed by tomatoes or tomato paste.",
        //    CookingTime = 60,
        //    DishId = 3
        //};

        //Dishes.AddRange(dumplings, lasange, borsch);
        //Products.AddRange(dough, mincemeat, cheese, flour, butter, beet, meat, carrot, oil, potato);
        //Recipes.AddRange(recipe1, recipe2, recipe3);

        //dumplings.Products.AddRange(new List<Product>() { dough, mincemeat });
        //lasange.Products.AddRange(new List<Product>() { mincemeat, cheese, flour, butter, carrot });
        //borsch.Products.AddRange(new List<Product>() { beet, meat, potato });

        //SaveChanges();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        ////modelBuilder.Entity<Dish>()
        ////    .HasMany(e => e.Products)
        ////    .WithMany(e => e.Dishes);

        //Product dough = new Product() { Id = 1, CaloricValue = 200, Name = "Dough", Weight = 300 };
        //Product mincemeat = new Product() { Id = 2, CaloricValue = 100, Name = "Mincemeat", Weight = 500 };
        //Product cheese = new Product() { Id = 3, CaloricValue = 200, Name = "Cheese", Weight = 400 };
        //Product flour = new Product() { Id = 4, CaloricValue = 200, Name = "Flour", Weight = 100 };
        //Product butter = new Product() { Id = 5, CaloricValue = 300, Name = "Butter", Weight = 100 };
        //Product beet = new Product() { Id = 6, CaloricValue = 300, Name = "Beet", Weight = 100 };
        //Product meet = new Product() { Id = 7, CaloricValue = 500, Name = "Meet", Weight = 300 };
        //Product carrot = new Product() { Id = 8, CaloricValue = 100, Name = "Carrot", Weight = 100 };
        //Product oil = new Product() { Id = 9, CaloricValue = 400, Name = "Oil", Weight = 50 };
        //Product dought = new Product() { Id = 10, CaloricValue = 200, Name = "Dough", Weight = 300 };
        //Product potato = new Product() { Id = 11, CaloricValue = 300, Name = "Potato", Weight = 200 };

        //Dish dumplings = new Dish() { Id = 1, Name = "Dumplings", Weight = 300, RecipeId = 1 };
        //Dish lasange = new Dish() { Id = 2, Name = "Lasagne", Weight = 1000, RecipeId = 2 };
        //Dish borsch = new Dish() { Id = 3, Name = "Borsch", Weight = 400, RecipeId = 3 };

        ////Dishes.AddRange(dumplings, lasange, borsch);
        ////Products.AddRange(dough, mincemeat, cheese, flour, butter, beet, meet, carrot, oil, dough, potato);

        //dumplings.Products.Add(dough);
        //dumplings.Products.Add(mincemeat);

        //modelBuilder.Entity<Dish>().HasData(
        //    //new Dish() { Id = 1, Name = "Dumplings", Weight = 300, RecipeId = 1, Products = new List<Product> { dough, mincemeat } },
        //    //new Dish() { Id = 2, Name = "Lasagne", Weight = 1000, RecipeId = 2 },
        //    //new Dish() { Id = 3, Name = "Borsch", Weight = 400, RecipeId = 3 }

        //    dumplings, lasange, borsch
        //);

        //modelBuilder.Entity<Recipe>().HasData(
        //    new Recipe() { Id = 1, CookingTechnology = "Something....", CookingTime = 15, DishId = 1 },
        //    new Recipe() { Id = 2, CookingTechnology = "...", CookingTime = 45, DishId = 2 },
        //    new Recipe() { Id = 3, CookingTechnology = "dadad", CookingTime = 60, DishId = 3 }
        //);

        //modelBuilder.Entity<Product>().HasData(
        //    //new Product() { Id = 1, CaloricValue = 200, Name = "Dough", Weight = 300 },
        //    //new Product() { Id = 2, CaloricValue = 100, Name = "Mincemeat", Weight = 500 },
        //    //new Product() { Id = 3, CaloricValue = 200, Name = "Cheese", Weight = 400 },
        //    //new Product() { Id = 4, CaloricValue = 200, Name = "Flour", Weight = 100 },
        //    //new Product() { Id = 5, CaloricValue = 300, Name = "Butter", Weight = 100 },
        //    //new Product() { Id = 6, CaloricValue = 300, Name = "Beet", Weight = 100 },
        //    //new Product() { Id = 7, CaloricValue = 500, Name = "Meet", Weight = 300 },
        //    //new Product() { Id = 8, CaloricValue = 100, Name = "Carrot", Weight = 100 },
        //    //new Product() { Id = 9, CaloricValue = 400, Name = "Oil", Weight = 50 },
        //    //new Product() { Id = 10, CaloricValue = 200, Name = "Dough", Weight = 300 },
        //    //new Product() { Id = 11, CaloricValue = 300, Name = "Potato", Weight = 200 }

        //    dough, mincemeat, cheese, flour, butter, beet, meet, carrot, oil, dough, potato
        //);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; 
                                        Database = RestaurantDB; 
                                        Trusted_Connection = true");
    }
}
