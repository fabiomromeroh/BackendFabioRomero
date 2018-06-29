using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Contracts
{
    public interface IPolicyLogic : IBaseLogic<Policy>
    {
        List<Policy> GetByClientId(string clientId);
        List<Policy> GetByClientName(string name);
        Client GetClientByPolicy(string policyId);

    }
}
