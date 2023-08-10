using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class ApplicationJson
    {
        [JsonProperty("schema")]
        public SchemaAppJson ApplicationJsonSchema;
    }
}