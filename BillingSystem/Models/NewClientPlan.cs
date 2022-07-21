using BillingSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class NewClientPlan : CallPlan
    {
        public NewClientPlan() : base()
        {
            GeneralRates.Add(RateType.REGULAR, Rate.REGULAR_RATE_FOR_NEW_CLIENTS);
            AddRates();
        }
    }
}
