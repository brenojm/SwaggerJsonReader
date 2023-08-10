using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Properties
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("format")]
        public string Format;

        [JsonProperty("items")]
        public Item Items;

        [JsonProperty("nullable")]
        public bool Nullable;
    }
}