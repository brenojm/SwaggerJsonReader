using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Method
    {
        [JsonProperty("tags")]
        public List<string> Tags;

        [JsonProperty("summary")]
        public string Summary;

        [JsonProperty("description")]
        public string Description;

    }
}