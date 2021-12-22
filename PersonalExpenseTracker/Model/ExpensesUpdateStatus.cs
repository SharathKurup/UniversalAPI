using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversalAPI.PersonalExpenseTracker.Model
{
    public class ExpensesUpdateStatus
    {
        public long ExpenseId { get; set; }
        public int IsBackUp { get; set; }
        public int IsBackupSuccess { get; set; }
        public string StatusMsg { get; set; }
    }
}
