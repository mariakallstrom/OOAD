using ITDemokraternaDbLib;
using ITDemokraternaLib;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace ITDemokraternaIntegrationTestLib
{
    public class MemberSystemTests
    {
        private ITDemokraternaDbContext _context;
        public MemberSystemTests()
        {
            var optionBuilder = new DbContextOptionsBuilder<ITDemokraternaDbContext>();
            //optionBuilder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            optionBuilder.UseSqlServer("Server=(local);Database=ITDemokraternaDb;Trusted_Connection=True;");
            _context = new ITDemokraternaDbContext(optionBuilder.Options);
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            
        }
        [Fact]
        public void Create_Parties_Test()
        {
            var sys = new MembersSystem(new SqlPartyRepository(_context));
            var result = sys.Create("Maria", "801012-0304");
            Assert.Equal("Maria", result.Name);
        }

        [Fact]
        public void Get_Parties_Test()
        {
            var sys = new MembersSystem(new SqlPartyRepository(_context));
            sys.Create("Maria", "801012-0304");
            Assert.Equal(1, sys.PartyCount());
        }
    }
}
