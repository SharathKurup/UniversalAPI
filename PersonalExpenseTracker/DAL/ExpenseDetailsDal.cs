using MongoDB.Driver;
using UniversalAPI.PersonalExpenseTracker.Model;

namespace UniversalAPI.PersonalExpenseTracker.DAL
{
    public class ExpenseDetailsDal : IExpenseDetailsDal
    {
        private IMongoCollection<Expenses> _expenses;
        private readonly MongoClient _client;
        private readonly IMongoDatabase _dataBase;
        private readonly string _expenseDetailsCollection;

        public ExpenseDetailsDal(IDatabaseSettings databaseSettings)
        {
            _client = new MongoClient(databaseSettings.ConnectionString);
            _dataBase = _client.GetDatabase(databaseSettings.DatabaseName);
            _expenseDetailsCollection = databaseSettings.ExpenseDetailsCollection;
        }
        public Expenses AddExpenseDetail(Expenses expenses)
        {
            _expenses = _dataBase.GetCollection<Expenses>(_expenseDetailsCollection);
            _expenses.InsertOne(expenses);
            return expenses;
        }
    }
}
