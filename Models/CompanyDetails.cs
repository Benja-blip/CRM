using System;
using System.ComponentModel.DataAnnotations;

namespace CRM3.Models
{
    public class CompanyDetails
    {
        [Key]
        public string CompanyName { get; set; }
        public string PublicEmail { get; set; }

        public string ContactPersonOne { get; set; }
        public string PersonalEmailOne { get; set; }
        public string ContactPersonTwo { get; set; }
        public string PersonalEmailTwo { get; set; }
        [DataType(DataType.Date)]
        public DateTime FirstContactDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime SecondContactDate { get; set; }
        public string Comments { get; set; }
        public string AccountManager { get; set; }
    }

}