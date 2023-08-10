using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Item
    {
        [JsonProperty("$ref")]
        public string @ref { get; set; }
    }
}