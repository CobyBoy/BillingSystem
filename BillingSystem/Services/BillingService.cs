using BillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Services
{
    public class BillingService
    {
        public static decimal CalculateBill(List<Call> callHistory)
        {
            decimal cost = 0;

            foreach (var call in callHistory)
            {
                cost += call.GetCallCost();

            }
            return cost;
        }
    }
}
