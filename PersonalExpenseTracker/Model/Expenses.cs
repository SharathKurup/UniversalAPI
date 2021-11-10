using Newtonsoft.Json;

namespace UniversalAPI.PersonalExpenseTracker.Model
{
    public class Expenses
    {
        [JsonProperty("ExpenseID")]
        public long ExpenseId { get; set; }

        [JsonProperty("ExpenseDate")]
        public string ExpenseDate { get; set; }

        [JsonProperty("ExpenseAmount")]
        public long ExpenseAmount { get; set; }

        [JsonProperty("ExpenseDescription")]
        public string ExpenseDescription { get; set; }

        [JsonProperty("isBackUp")]
        public int IsBackUp { get; set; }
    }
}
