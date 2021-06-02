using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Person
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Cpf { get; set; }
        public int BirthDate { get; set; }
        public string Address { get; set; }
        public string Genre { get; set; }
        public string Formation { get; set; }
    }
}