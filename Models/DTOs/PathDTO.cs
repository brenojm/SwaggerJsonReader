using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwaggerEndpoint.Models.DTOs
{
    public class PathDTO
    {
        public string Path { get; set; }
        public List<Method> methods { get; set; }

        public PathDTO(string path, List<Method> methods)
        {
            Path = path;
            this.methods = methods;
        }

        public override string ToString()
        {
            List<string> parts = new List<string> { $"Path: {Path}" };
            foreach (var method in methods)
            {
                parts.Add(method.ToString());
            }
            return string.Join(Environment.NewLine, parts);
        }
    }
}
