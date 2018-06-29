using Data.Contracts;
using Entities;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Data.Implementations
{
    public class PolicyRepository : BaseRepository<Policy>, IPolicyRepository
    {

        public List<Policy> GetByClientId(string clientId)
        {
            return Context.PolicyResult.policies.Where(x => x.clientId == clientId).ToList();
        }

        public List<Policy> GetByClientName(string name)
        {
            var client = Context.ClientResult.clients.FirstOrDefault(x => x.name == name);

            return Context.PolicyResult.policies.Where(x => x.clientId == client.id).ToList();
        }

        public Client GetClientByPolicy(string policyId)
        {
            var client = Context.PolicyResult.policies.FirstOrDefault(x => x.id == policyId);

            var clientId = client != null ? client.clientId : null;
            
            return Context.ClientResult.clients.FirstOrDefault(x => x.id == clientId);
        }

        public override IEnumerable<Policy> GetAll()
        {
            return base.Context.PolicyResult.policies.ToList();
        }
    }
}
