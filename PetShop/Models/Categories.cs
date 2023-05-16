using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Categories
    {
        [Key]
        public int CategoriesId { get; set; }
        public string CategoryName { get; set; }
        public List<Animal> animals { get; set; }
    }

}
