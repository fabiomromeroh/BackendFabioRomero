using Entities.Dto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Data.Base
{
    public class Context : IContext
    {
        public ClientResultDto ClientResult { get; set; }
        public PolicyResultDto PolicyResult { get; set; }
    }
}
