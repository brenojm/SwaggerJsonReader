using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class RequestBody
    {
        [JsonProperty("content")]
        public Content Content;
    }
}