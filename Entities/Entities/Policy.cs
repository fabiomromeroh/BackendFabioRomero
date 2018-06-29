using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Policy
    {
        public string id { get; set; }
        public double amountInsured { get; set; }
        public string email { get; set; }
        public DateTime inceptionDate { get; set; }
        public bool installmentPayment { get; set; }
        public string clientId { get; set; }
    }
}
