using Data.Base;
using Data.Contracts;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Data.Implementations
{
    public class PolicyRepository : BaseRepository<Policy>, IPolicyRepository
    {
        public PolicyRepository(IContext context) : base(context)
        {

        }

        public List<Policy> GetByClientId(string clientId)
        {
            return Context.PolicyResult.policies.Where(x => x.clientId == clientId).ToList();
        }

        public List<Policy> GetByClientName(string name)
        {
            var client = Context.ClientResult.clients.FirstOrDefault(x => x.name == name);
            var clientId = client != null ? client.id : null;

            return Context.PolicyResult.policies.Where(x => x.clientId == clientId).ToList();
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
