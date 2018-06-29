using Data.Base;
using Data.Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Implementations
{
    public class UserRepository : BaseRepository<Client>, IUserRepository
    {

        public Client Login(string email)
        {
            return Context.ClientResult.clients.FirstOrDefault(x => x.email == email);
        }
    }
}
