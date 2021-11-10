using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace UniversalAPI.PersonalExpenseTracker.Model
{
    [BsonIgnoreExtraElements]
    public class ExpenseDetails
    {
        [JsonProperty("rowsAffected")]
        public long RowsAffected { get; set; }

        [JsonProperty("rows")]
        public Rows Rows { get; set; }
    }
}
