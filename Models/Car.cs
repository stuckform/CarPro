using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CarPro.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Make { get; set; }

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        [Required]
        [Range(1900, 2030)]
        public int Year { get; set; }

        [Range(0, 9999999)]
        public int Mileage { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public string DriveTrain { get; set; }


        //Navigation
        public int LotId { get; set; }

        public virtual Lot Lot{ get; set;  }
    }
}
