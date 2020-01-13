using System;
using System.ComponentModel.DataAnnotations;

namespace CRM3.Models
{
    public class CRM3Login
    {
        [Key]
        public string username { get; set; }
        public string password { get; set; }

    }

}