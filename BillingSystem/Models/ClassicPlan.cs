using BillingSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class ClassicPlan : CallPlan
    {
        public ClassicPlan() : base()
        {
            GeneralRates.Add(RateType.REGULAR, Rate.REGULAR_RATE);
            AddRates();
        }
    }
}
