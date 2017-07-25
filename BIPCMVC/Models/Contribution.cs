using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIPCMVC.Models
{
    public class Contribution
    {
        public int ContributionId { get; set; }
        public Contributor Contributor { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int TransactionType { get; set; }
        public int TransactionMode { get; set; }
        public double Amount { get; set; }
        public string CheckNumber { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Note { get; set; }
        public int Status { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateChanged { get; set; }
        public int ContributorId { get; set; }

    }
}