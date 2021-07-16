using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFCore_WebApi.Models
{
    public class Customer
    {
        [Key]
        public int customer_id { get; set; }
    }
}
