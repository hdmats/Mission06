using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06.Models
{
    public class MoviesModel
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string rating { get; set; }
        [Required]
        public string director { get; set; }
        public bool edit { get; set; }
        public string lent { get; set; }
        [Range(0,25, ErrorMessage = "Notes have a max of 25 characters")]
        public string notes { get; set; }

    }
}
