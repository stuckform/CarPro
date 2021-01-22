using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarPro.Models
{
    public class Lot
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [Range(10000, 99999)]
        public int ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int PhoneNum { get; set; }

        public string Manager { get; set; }

        public virtual ICollection<Car> Cars { get; set; }


    }
}
