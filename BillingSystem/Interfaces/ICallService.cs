using BillingSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Interfaces
{
    public interface ICallService
    {
        public void AddCallToCallHistory(Call call);
        public List<Call> GetCallHistory();
    }
}
