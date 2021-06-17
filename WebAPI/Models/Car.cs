using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Car
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string VIN { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Make { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Model { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Color { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(10)")]
        public string Type { get; set; }

        [Required]
        public int Mileage { get; set; }

        [Required]
        public int Price { get; set; }
    }
}
