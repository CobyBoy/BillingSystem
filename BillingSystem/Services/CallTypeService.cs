using BillingSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Services
{
    public class CallTypeService
    {
        public static double CalculateCostBasedOnLocation(double callCost, CallType callType)
        {
            return callType == CallType.NATIONAL ? callCost : callCost * 2;
        }
    }
}
