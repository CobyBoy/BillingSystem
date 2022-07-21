using BillingSystem.Interfaces;
using BillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Services
{
    public class CallService : ICallService
    {
        List<Call> callList = new List<Call>();

        public void addCallToCallHistory(Call? call)
        {
            if (call != null)
            {
                callList.Add(call);
            }

        }

        public List<Call> getCallHistory()
        {
            return callList;
        }
    }
}
