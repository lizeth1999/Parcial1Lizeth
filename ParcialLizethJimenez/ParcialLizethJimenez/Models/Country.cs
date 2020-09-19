using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialLizethJimenez.Models
{
    public class Leng
    {
        [Key]
        [Required]
        public string iso369_1 { get; set; }

        [Required]
        public string iso369_2 { get; set; }

        [Required]
        public string name { get; set; }

        [Required]
        public string nativeName { get; set; }
    }

    public class Country
    {
        [Key]
        [Required]
        [StringLength(3, ErrorMessage = "This field must contain 3 characters")]
        public string Alpha3Code { get; set; }

        [Required]
        public string Region { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Name { get; set; }

        [Required]
        public double Area { get; set; }

        [Required]
        public int Calling_Code { get; set; }

        [Required]
        public List<Leng> Lenguages { get; set; }

        [Required]
        [RegularExpression(@"^(http|ftp|https|www)://([\w+?\.\w+])+([a-zA-Z0-9\~\!\@\#\$\%\^\&\*\(\)_\-\=\+\\\/\?\.\:\;\'\,]*)?$")]
        public string Flag { get; set; }




    }
}