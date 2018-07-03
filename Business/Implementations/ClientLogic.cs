using Data.Implementations;
using Entities;
using Business.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Data.Contracts;

namespace Business.Implementations
{
    public class ClientLogic : BaseLogic<Client, ClientRepository>, IClientLogic
    {
        private readonly IClientRepository clientRepository;

        public ClientLogic(IClientRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public Client GetById(string clientId)
        {
            return this.clientRepository.GetById(clientId);
        }

        public List<Client> GetByName(string name)
        {
            return this.clientRepository.GetByName(name);
        }

        public override IEnumerable<Client> GetAll()
        {
            return this.clientRepository.GetAll();
        }
    }
}
