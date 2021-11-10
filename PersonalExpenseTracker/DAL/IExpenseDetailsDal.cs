using UniversalAPI.PersonalExpenseTracker.Model;

namespace UniversalAPI.PersonalExpenseTracker.DAL
{
    public interface IExpenseDetailsDal
    {
        Expenses AddExpenseDetail(Expenses expenses);
    }
}
