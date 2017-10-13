using AccountabilityInterfacesLib;
using System;
using System.Collections.Generic;
using System.Text;
using AccountabilityLib;
using System.Linq;

namespace ITDemokraternaDbLib
{
    public class SqlPartyRepository : IPartyRepository
    {

        private ITDemokraternaDbContext _context;
        public SqlPartyRepository(ITDemokraternaDbContext context)
        {
            _context = context;
        }

        public List<Party> All()
        {
            var p = _context.Parties.ToList();
            return p;
        }

        public Party Create(string name, string legalId)
        {
            var p = new Party { Name = name, LegalId = legalId };
            _context.Add(p);
            _context.SaveChanges();
            return p;
        }

        public void Delete(int id, bool hard)
        {
            throw new NotImplementedException();
        }

        public List<Party> SearchParty(string term)
        {
            throw new NotImplementedException();
        }
    }
}
