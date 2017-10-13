using AccountabilityLib;
using Microsoft.EntityFrameworkCore;
using System;

namespace ITDemokraternaDbLib
{
    public class ITDemokraternaDbContext : DbContext
    {
        public ITDemokraternaDbContext(DbContextOptions<ITDemokraternaDbContext> options) : base(options)
        {

        }
        public DbSet<Party> Parties { get; set; }
    }
}
