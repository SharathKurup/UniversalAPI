using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UniversalAPI.PersonalExpenseTracker.Model;
using UniversalAPI.PersonalExpenseTracker.DAL;

namespace UniversalAPI.PersonalExpenseTracker.BL
{
    public class ExpenseDetailsHandler : IExpenseDetailsHandler
    {
        public IExpenseDetailsDal _expenseDetailsDal;
        public ExpenseDetailsHandler(IExpenseDetailsDal expenseDetailsDal)
        {
            _expenseDetailsDal = expenseDetailsDal;
        }
        public ExpenseDetails AddExpenseDetail(ExpenseDetails expenseDetail)
        {
            foreach (Expenses expense in expenseDetail.Rows.Expenses)
            {
                expense.IsBackUp = 1;
                _expenseDetailsDal.AddExpenseDetail(expense);
            }

            return expenseDetail;
        }
    }
}
