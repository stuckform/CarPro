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
        [Display(Name = "Street Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Zip Code")]
        [StringLength(9, MinimumLength = 5)]
        public string ZipCode { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNum { get; set; }

        public string Manager { get; set; }

        //parent of the car model
        public virtual ICollection<Car> Cars { get; set; }


    }
}
