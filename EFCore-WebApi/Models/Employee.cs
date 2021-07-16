using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_WebApi.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="Name can not exceed 50 characters")]
        [MinLength(3, ErrorMessage ="Name can not be less than 3 characters")]
        public string Name { get; set; }

        [Display(Name= "Office Email")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9.]+$", 
            ErrorMessage ="Invalid Email Format")]
        public string Email { get; set;  }
    }
}
