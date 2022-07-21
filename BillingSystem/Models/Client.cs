using BillingSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class Client
    {
        public ClientType ClientType { get; set; }
        public CallPlan CallPlan { get; set; }

        public Client(ClientType clientType)
        {
            ClientType = clientType;
            SetCallPlanForClient();
        }

        private void SetCallPlanForClient()
        {
            CallPlan = CallPlanFactory.MakeCallPlan(ClientType);
        }
    }
}
