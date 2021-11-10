using System.Collections.Generic;
using Newtonsoft.Json;

namespace UniversalAPI.PersonalExpenseTracker.Model
{
    public class Rows
    {
        [JsonProperty("expenses")]
        public List<Expenses> Expenses { get; set; }

        [JsonProperty("length")]
        public long Length { get; set; }
    }
}
