using AccountabilityLib;
using System;
using System.Collections.Generic;

namespace AccountabilityInterfacesLib
{
    public interface IPartyRepository
    {
        Party Create(string name, string legalId);
        List<Party> SearchParty(string term);
        void Delete(int id, bool hard);

        List<Party> All();
    }
}
