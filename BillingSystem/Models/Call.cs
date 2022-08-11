using BillingSystem.Enums;
using BillingSystem.Interfaces;
using BillingSystem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Models
{
    public class Call : ICall
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public RateType RateType { get; set; }
        public CallType CallType { get; set; }
        public Client Client { get; set; }

        public Call(Client client, RateType rateType, CallType callType, DateTime startTime, DateTime endTime)
        {
            Client = client;
            RateType = rateType;
            CallType = callType;
            StartTime = startTime;
            EndTime = endTime;
        }
        public int GetDuration()
        {
            return (int)(EndTime - StartTime).TotalMinutes;
        }

        public Client GetClient()
        {
            return Client;
        }

        public decimal GetCallCost()
        {
            var rateAndRateType = Client.CallPlan.GeneralRates.Where(rate => rate.Key.Equals(RateType));
            var cost = GetDuration() * CallTypeService.CalculateCostBasedOnLocation(rateAndRateType.FirstOrDefault().Value, CallType);
            return (decimal)cost;
        }
    }
}
