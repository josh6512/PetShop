using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetShop.Models
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        public string Comment { get; set; }
        
        
        public int AnimalId { get; set; }
        public Animal animal { get; set; }
    }
}
