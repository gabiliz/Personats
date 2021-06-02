using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Sexuality
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}