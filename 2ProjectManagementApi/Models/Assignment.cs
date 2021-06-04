using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _2ProjectManagementApi.Models
{
    public class Assignment
    {
        public int Id { get; set; }

     //   FK
        public virtual Developer Developer { get; set; }
        public int DeveloperId { get; set; }

        public virtual Project Project { get; set; }
        public int ProjectId { get; set; }

        public Assignment() { }


       
       
    }
}
