using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class SchemaParameter
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("format")]
        public string Properties;

        [JsonProperty("enum")]
        public List<string> EnumParameter;
    }
}