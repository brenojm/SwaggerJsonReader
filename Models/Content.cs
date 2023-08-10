using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Content
    {
        [JsonProperty("application/json")]
        public ApplicationJson ApplicationJson;
    }
}