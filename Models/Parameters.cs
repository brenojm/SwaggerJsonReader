using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Parameters
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("in")]
        public string In;

        [JsonProperty("required")]
        public bool Required;

        [JsonProperty("schema")]
        public Dictionary<string, string> SchemaParameters;



    }
}