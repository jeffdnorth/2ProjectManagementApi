using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2ProjectManagementApi.Models
{
    public class Project
    {
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Description { get; set; }

        public int EstimateInDays { get; set; }

        [Required]
        public DateTime DeadLine { get; set; }

        public Project()
        {}
    }
}
