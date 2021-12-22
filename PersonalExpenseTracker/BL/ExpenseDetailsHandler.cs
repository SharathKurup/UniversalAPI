using System;
using System.Collections.Generic;
using UniversalAPI.PersonalExpenseTracker.DAL;
using UniversalAPI.PersonalExpenseTracker.Model;

namespace UniversalAPI.PersonalExpenseTracker.BL
{
    public class ExpenseDetailsHandler : IExpenseDetailsHandler
    {
        public IExpenseDetailsDal _expenseDetailsDal;
        public ExpenseDetailsHandler(IExpenseDetailsDal expenseDetailsDal)
        {
            _expenseDetailsDal = expenseDetailsDal;
        }
        public ExpensesUpdateStatusList AddExpenseDetail(ExpenseDetails expenseDetail)
        {
            ExpensesUpdateStatusList expensesUpdateStatusList = new();
            expensesUpdateStatusList.ListexpensesUpdateStatus = new List<ExpensesUpdateStatus>();
            ExpensesUpdateStatus expensesUpdateStatus = new();
            foreach (Expenses expense in expenseDetail.Rows.Expenses)
            {
                expense.IsBackUp = 1;
                try
                {
                    expensesUpdateStatus.ExpenseId = expense.ExpenseId;
                    expensesUpdateStatus.IsBackUp = expense.IsBackUp;
                    expensesUpdateStatus.IsBackupSuccess = 1;
                    expensesUpdateStatus.StatusMsg = "Success";
                    _expenseDetailsDal.AddExpenseDetail(expense);
                }
                catch (Exception ex)
                {
                    expensesUpdateStatus.IsBackupSuccess = 0;
                    expensesUpdateStatus.IsBackUp = 0;
                    expensesUpdateStatus.StatusMsg = ex.Message;
                }
                expensesUpdateStatusList.ListexpensesUpdateStatus.Add(expensesUpdateStatus);
            }
            return expensesUpdateStatusList;
        }
    }
}
