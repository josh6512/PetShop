using Microsoft.EntityFrameworkCore;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Data
{
    public class PetContext: DbContext
    {
        public PetContext(DbContextOptions<PetContext> options) :base(options)
        {
        }
        public DbSet<Animal> animals { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Comments> comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Animal>().HasData(
                new { AnimalId = 1, Name = "Dog", Age = 4, Description = "The dog  is a domesticated carnivore of the family Canidae. It is part of the wolf-like canids  " +
                "and is the most widely abundant terrestrial carnivore The dog and the extant gray wolf are sister taxa as modern wolves are not closely related to the wolves that " +
                "were first domesticated implies that the direct ancestor of the dog is extinct", CategoryName = "Mammals",
                    CommentId = 1
                },
                
                
                new { AnimalId = 2, Name = "Cat", Age = 6, Description = "The cat (Felis catus) is a domestic species of small carnivorous mammal.  " +
                "It is the only domesticated species in the family Felidae and is often referred to as the domestic cat to distinguish it from the wild members of the family." +
                " A cat can either be a house cat, a farm cat or a feral cat; the latter ranges freely and avoids human contact.+" +
                " Domestic cats are valued by humans for companionship and their ability to hunt rodents. About 60 cat breeds are recognized by various", CategoryName = "Mammals", CommentId=2 },
                
                new { AnimalId = 3, Name = "eagle", Age = 9, Description = "Eagle is the common name for many large birds of prey of the family Accipitridae." +
                " Eagles belong to several groups of genera, some of which are closely related. Most of the 60 species of eagle are from Eurasia and Africa.+" +
                " Outside this area, just 14 species can be found—2 in North America, 9 in Central and South America, and 3 in Australia. It is nicknamed the king of all birds",  CategoryName = "Birds",
                    CommentId = 3
                },


                new
                {
                    AnimalId = 4,
                    Name = "turtle",
                    Age = 5,
                    Description = "Turtles They are characterized by a special bony or cartilaginous shell developed from their ribs that acts as a shield." +
                    " Colloquially, the word turtle is generally restricted to fresh-water and sea-dwelling Testudines. Testudines includes both extant (living) and extinct species." +
                    " Its earliest known members date from the Middle Jurassic.Turtles are one of the oldest reptile groups, more ancient than snakes or crocdilians. Of the 360 known extant species, some are highly endangered.",
                    CategoryName= "Reptiles",
                    
                },
                new
                {

                 AnimalId = 5,
                    Name = "fruge",
                    Age = 5,
                    Description =" A frog is an amphibian that lives in rivers and eats mostly insects",
                    CategoryName= " Amphibians"
                }

                );

            
            modelBuilder.Entity<Categories>().HasData(
                new { CategoriesId=1, CategoryName = "Mammals" },
                  new { CategoriesId = 2, CategoryName = "Birds" },
                   new { CategoriesId = 3, CategoryName = " Reptiles" },
                    new { CategoriesId = 4, CategoryName = " Amphibians" }
                  

                );


            modelBuilder.Entity<Comments>().HasData(
                 new { CommentId = 1, Comment = "The dog is a mammal and is a domesticated animal ", AnimalId =1},
                 new { CommentId = 2, Comment = "The cat is a mammal and is a domesticated animal ", AnimalId=2 },
                 new { CommentId = 3, Comment = "the eagle is  her wild animal ", AnimalId=3 }
                 
                );
        }

    }
}
