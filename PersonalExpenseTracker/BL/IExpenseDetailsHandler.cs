using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalAPI.PersonalExpenseTracker.Model;

namespace UniversalAPI.PersonalExpenseTracker.BL
{
    public interface IExpenseDetailsHandler
    {
        ExpensesUpdateStatusList AddExpenseDetail(ExpenseDetails expenseDetail);
    }
}
