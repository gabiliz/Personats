using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace personats.Data.Entity
{
    public class Recruiter
    {
        [Key]
        public int EnterpriseId { get; set; }
        public int Status { get; set; }
        public int PersonList { get; set; }
        public int OpportunityList { get; set; }
        public int EnterpriseList { get; set; }
    }
}