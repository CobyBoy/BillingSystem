using BillingSystem.Enums;
using BillingSystem.Models;
using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem
{
    public class CallPlanFactory
    {
        public static CallPlan MakeCallPlan(ClientType clientType)
        {
            CallPlan plan = null;
            if (clientType.Equals(ClientType.NEW))
            {
               return new NewClientPlan();
            }
            if (clientType.Equals(ClientType.EXISTING))
            {
               return new ClassicPlan();
            }

            return plan;
        }
    }
}
