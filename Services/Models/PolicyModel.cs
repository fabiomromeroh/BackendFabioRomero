using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Services.Models
{
    public class PolicyModel
    {
        public string id { get; set; }
        public double amountInsured { get; set; }
        public string email { get; set; }
        public string inceptionDate { get; set; }
        public bool installmentPayment { get; set; }
        public string clientId { get; set; }
    }
}