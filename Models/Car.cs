using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarPro.Models
{
    public class Car
    {
        [Required]

        public string Make { get; set; }

        [Required]

        public string Model { get; set; }

        [Required]
        [Range(1900, 2030)]
        public int Year { get; set; }

        public int Mileage { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Required]

        public string Color { get; set; }


        //Navigation
        public int LotId { get; set; }

        public virtual Car Car { get; set;  }
    }
}
