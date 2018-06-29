using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Base
{
    public  interface IContext
    {
        ClientResultDto ClientResult { get; set; }
        PolicyResultDto PolicyResult { get; set; }
    }
}
