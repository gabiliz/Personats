using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Enterprise
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cnpj { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
    }
}