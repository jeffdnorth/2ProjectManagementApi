using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _2ProjectManagementApi.Models;

namespace _2ProjectManagementApi.Data
{
    public class _2ProjContextApiContext : DbContext
    {
        public _2ProjContextApiContext (DbContextOptions<_2ProjContextApiContext> options)
            : base(options)
        {
        }

        public DbSet<_2ProjectManagementApi.Models.Assignment> Assignment { get; set; }

        public DbSet<_2ProjectManagementApi.Models.Developer> Developer { get; set; }

        public DbSet<_2ProjectManagementApi.Models.Project> Project { get; set; }
    }
}
