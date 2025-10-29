using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Employee
    {
        [Key]
        [Display(Name = "Employee ID")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "name")]
        public string Name { get; set; }
        [Required]
        public double salary { get; set; }
        [Required]
        [Display(Name ="age")]
        public int age { get; set; }

    }
}
