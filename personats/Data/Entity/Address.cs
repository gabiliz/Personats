using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Address
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Reference { get; set; }
        public int Cep { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}