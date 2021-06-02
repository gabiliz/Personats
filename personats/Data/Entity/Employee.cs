using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Employee
    {
        [Key]
        public int Status { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; }
    }
}