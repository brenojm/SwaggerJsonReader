using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class RequestBody
    {
        [JsonProperty("content")]
        public Content Content;

        public override string ToString()
        {
            if (Content != null)
                return $"Content: {Content}";

            return "";
        }

    }
}