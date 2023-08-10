using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerEndpoint.Models
{
    public class Schemas
    {
        [JsonProperty("type")]
        public string Type;

        [JsonProperty("properties")]
        public Dictionary<string, Properties> Properties;

    }
}
