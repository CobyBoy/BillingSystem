using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSystem.Interfaces
{
    public interface ICall
    {
        public int GetDuration();
        public decimal GetCallCost();
    }
}
