using Entities;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Contracts
{
    public interface IPolicyRepository : IBaseRepository<Policy>
    {
        List<Policy> GetByClientId(string clientId);

        List<Policy> GetByClientName(string name);

        Client GetClientByPolicy(string policyId);
    }
}
