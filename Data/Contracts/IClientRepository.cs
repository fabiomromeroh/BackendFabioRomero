using Entities;
using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Contracts
{
    public interface IClientRepository : IBaseRepository<Client>
    {
        Client GetById(string clientId);
        Client GetByName(string name);
    }
}
