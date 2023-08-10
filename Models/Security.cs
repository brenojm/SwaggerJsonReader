using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Security
    {
        [JsonProperty("Bearer")]
        public List<string> Bearer;
    }
}