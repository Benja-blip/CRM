using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRM3.Models
{
    public class CompanyDetails
    {
        [Key]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }
        [DisplayName("Public Email")]
        public string PublicEmail { get; set; }
        [DisplayName("Contact Person 1")]
        public string ContactPersonOne { get; set; }
        [DisplayName("Personal Email 1")]
        public string PersonalEmailOne { get; set; }
        [DisplayName("Contact Person 2")]
        public string ContactPersonTwo { get; set; }
        [DisplayName("Personal Email 2")]
        public string PersonalEmailTwo { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date Created")]
        public DateTime DateCreated { get; set; }
        [DisplayName("Group Name")]
        public string GroupName { get; set; }
        [DisplayName("Comments")]
        public string Comments { get; set; }
        [DisplayName("Account Manager")]
        public string AccountManager { get; set; }
    }

}