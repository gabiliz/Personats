using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Opportunity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Categories { get; set; }
        public DateTime InitialDate { get; set; }
        public float Salary { get; set; }
        public string Formation { get; set; }
    }
}