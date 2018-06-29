using Data.Contracts;
using Entities;
using Entities.Dto;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Data.Implementations
{
    public class ClientRepository : BaseRepository<Client>, IClientRepository
    {

        public Client GetById(string clientId)
        {
            return base.Context.ClientResult.clients.Where(x => x.id == clientId).FirstOrDefault();
        }

        public Client GetByName(string name)
        {
            return base.Context.ClientResult.clients.Where(x => x.name == name).FirstOrDefault();
        }

        public override IEnumerable<Client> GetAll()
        {
            return base.Context.ClientResult.clients.ToList();
        }
    }
}
