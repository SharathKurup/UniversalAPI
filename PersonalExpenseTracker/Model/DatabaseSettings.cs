namespace UniversalAPI.PersonalExpenseTracker.Model
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string ExpenseDetailsCollection { get; set; }
    }
}
