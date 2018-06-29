using Data.Implementations;
using Entities;
using Business.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Contracts;

namespace Business.Implementations
{
    public class PolicyLogic : BaseLogic<Policy, PolicyRepository>, IPolicyLogic
    {
        private readonly IPolicyRepository policyRepository;

        public PolicyLogic(IPolicyRepository policyRepository)
        {
            this.policyRepository = policyRepository;
        }

        public List<Policy> GetByClientId(string clientId)
        {

            return this.policyRepository.GetByClientId(clientId);
        }

        public List<Policy> GetByClientName(string name)
        {
            return this.policyRepository.GetByClientName(name);
        }

        public Client GetClientByPolicy(string policyId)
        {
            return this.policyRepository.GetClientByPolicy(policyId);
        }

        public override IEnumerable<Policy> GetAll()
        {
            return this.policyRepository.GetAll();
        }
    }
}
