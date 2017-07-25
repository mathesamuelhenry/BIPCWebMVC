using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIPCMVC.Models
{
    public class Contributor
    {
        public int ContributorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FamilyName { get; set; }
        public int Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateChanged { get; set; }
    }
}