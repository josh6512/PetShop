using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Animal
    {
       
        [Key]
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
       
        public ICollection<Comments> comments { get; set; }

        public string CategoryName { get; set; }
        public Categories categories { get; set; }
    }
}
