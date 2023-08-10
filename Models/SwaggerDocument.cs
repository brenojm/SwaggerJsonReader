using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerEndpoint.Models
{
    internal class SwaggerDocument
    {
        [JsonProperty("openapi")]
        public string OpenAPI;

        //Criar classe
        [JsonProperty("info")]
        public Info Info;

        //Criar classe
        //Lista de Path
        [JsonProperty("paths")]
        public Dictionary<string, Paths> Paths;

        //Criar classe
        //Lista
        [JsonProperty("components")]
        public Component Components;

        //Criar classe
        //[JsonProperty("security")]
        //public Security Security;

    }
}
