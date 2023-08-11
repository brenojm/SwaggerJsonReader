using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Responses
    {
        [JsonProperty("description")]
        public string Description;

        public override string ToString()
        {
            return $"Description: {Description}";
        }

    }
}