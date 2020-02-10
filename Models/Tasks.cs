using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRM3.Models
{
    public class Tasks
    {
        [Key]
        [DisplayName("Task Name")]
        public string TaskName { get; set; }
        [DisplayName("Start Time")]        
        public DateTime StartTime { get; set; }
        [DisplayName("Deadline")]
        public DateTime Deadline { get; set; }
        [DisplayName("Important")]
        public bool Important { get; set; }
        [DisplayName("Complex")]
        public bool HighComplexity { get; set; }

    }

}