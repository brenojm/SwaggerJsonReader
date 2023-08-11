using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class Parameters
    {
        [JsonProperty("name")]
        public string Name;

        [JsonProperty("in")]
        public string In;

        [JsonProperty("required")]
        public bool Required;

        [JsonProperty("schema")]
        public SchemaParameter SchemaParameters;

        public override string ToString()
        {
            List<string> parts = new List<string> { $"Name: {Name}, In: {In}, Required: {Required}" };
            if (SchemaParameters != null)
            {
                
            }
            return string.Join(", ", parts);
        }

    }
}