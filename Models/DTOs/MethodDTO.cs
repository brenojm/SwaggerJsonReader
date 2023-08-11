using Newtonsoft.Json;

namespace SwaggerEndpoint.Models
{
    public class MethodDTO
    {
        
        public string MethodName;

        [JsonProperty("tags")]
        public List<string> Tags;

        [JsonProperty("summary")]
        public string Summary;

        [JsonProperty("description")]
        public string Description;

        [JsonProperty("responses")]
        public Dictionary<string, Responses> Responses;

        [JsonProperty("requestBody")]
        public Schemas RequestBody;

        [JsonProperty("parameters")]
        public List<Parameters> Parameters;

        public MethodDTO(string methodName, Method method)
        {
            MethodName = methodName;
            Tags = method.Tags;
            Summary = method.Summary;
            Description = method.Description;
            Responses = method.Responses;
            
            Parameters = method.Parameters;
        }

        public MethodDTO(string methodName, Method method, Schemas schemaJson)
        {
            MethodName = methodName;
            Tags = method.Tags;
            Summary = method.Summary;
            Description = method.Description;
            Responses = method.Responses;
            RequestBody = schemaJson;
            Parameters = method.Parameters;
        }

        public override string ToString()
        {
            List<string> parts = new List<string> { "Method:" };
            if (Tags != null) parts.Add($"  Tags: {string.Join(", ", Tags)}");
            if (Summary != null) parts.Add($"  Summary: {Summary}");
            if (Description != null) parts.Add($"  Description: {Description}");
            if (Responses != null)
            {
                List<string> responseParts = new List<string>();
                foreach (var kvp in Responses)
                {
                    responseParts.Add($"{kvp.Key}: {kvp.Value}");
                }
                parts.Add($"  Responses: {string.Join(", ", responseParts)}");
            }
            if (RequestBody != null) parts.Add($"  RequestBody: {RequestBody}");
            if (Parameters != null) parts.Add($"  Parameters: {string.Join(", ", Parameters)}");
            return string.Join(Environment.NewLine, parts);
        }

    }
}