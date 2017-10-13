using AccountabilityInterfacesLib;
using AccountabilityLib;
using System;
using System.Collections.Generic;

namespace ITDemokraternaLib
{
    public class MembersSystem
    {
        private IPartyRepository _partyRepository;
        public MembersSystem(IPartyRepository partyRepository)
        {
            _partyRepository = partyRepository;
        }

        public Party Create(string name, string legalId)
        {
            
            return _partyRepository.Create(name, legalId);
        }

        public List<Party> All()
        {
            return _partyRepository.All();
        }

        public int PartyCount()
        {
            var r = All();
            return r.Count;
        }
    }
}
