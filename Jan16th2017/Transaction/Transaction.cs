using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jan16th2017.Transaction
{
    public abstract class Transaction
    {
        public decimal BalanceAmount { get; set; }
        public abstract decimal GetBalanceAmount(decimal cashBackAmount, decimal minimumBalance, decimal penalty);
        public abstract decimal GetCashBackAmount(decimal cashBackPercent);
    }
}
