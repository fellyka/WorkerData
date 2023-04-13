using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorkerData.Models.DBEntities;

namespace WorkerData.DAL
{
    public class WorkerDbContext :DbContext
    {
        public WorkerDbContext(DbContextOptions options) : base(options)
        {  }

        public DbSet<Worker> Workers {get;set;} //Worker class from WorkerData.Models.DBEntities
    }
}