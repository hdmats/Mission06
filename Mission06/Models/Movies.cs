using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MoviesModel
    {
        //key
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public int categoryID { get; set; }
        public Category category { get; set; }
        [Required]
        public int? year { get; set; }
        [Required]
        public string rating { get; set; }
        [Required]
        public string director { get; set; }
        public bool edit { get; set; }
        public string lent { get; set; }
        //notes can be a max of 25 characters
        [StringLength(25)]
        public string notes { get; set; }

    }
}
