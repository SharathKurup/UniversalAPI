namespace UniversalAPI.PersonalExpenseTracker.Model
{
    public interface IDatabaseSettings
    {
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
        string ExpenseDetailsCollection { get; set; }
    }
}
