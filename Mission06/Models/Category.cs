using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int categoryID { get; set; }
        [Required]
        public string categoryname { get; set; }
    }
}
