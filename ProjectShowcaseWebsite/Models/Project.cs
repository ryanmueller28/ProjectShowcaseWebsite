using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectShowcaseWebsite.Models
{
    public class Project
    {
        public string Id { get; set; }

        public string ProjectName { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string URL { get; set; }

        public string GitURL { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return JsonSerializer.Serialize<Project>(this);
        }
    }
}
