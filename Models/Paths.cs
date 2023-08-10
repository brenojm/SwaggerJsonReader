using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Paths
    {
        [JsonProperty("get")]
        public Method Get;

        [JsonProperty("post")]
        public Method Post;

        [JsonProperty("put")]
        public Method Put;

        [JsonProperty("patch")]
        public Method Patch;

        [JsonProperty("delete")]
        public Method Delete;
    }
}