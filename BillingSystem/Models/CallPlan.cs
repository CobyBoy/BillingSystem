using BillingSystem.Enums;
using BillingSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class CallPlan : ICallPlan
    {
        public Dictionary<RateType, double> GeneralRates;

        public CallPlan()
        {
            GeneralRates = new Dictionary<RateType, double>();
        }

        public void AddRates()
        {
            GeneralRates.Add(RateType.WEEKEND, Rate.WEEKEND_RATE );
            GeneralRates.Add(RateType.LATE_NIGHT, Rate.LATE_NIGHT_RATE);
        }
    }
}
