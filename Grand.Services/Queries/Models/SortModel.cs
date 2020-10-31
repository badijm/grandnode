using Newtonsoft.Json;

namespace Grand.Services.Queries.Models
{
    public class SortModel
    {
        [JsonProperty("field")]
        public string Field { get; set; }

        [JsonProperty("dir")]
        public string Dir { get; set; }
    }
}
