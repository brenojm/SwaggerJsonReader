using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Info
    {
        [JsonProperty("title")]
        public string Title;
        [JsonProperty("description")]
        public string Description;
        [JsonProperty("version")]
        public string Version;
    }
}