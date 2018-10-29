using System;
using Newtonsoft.Json;
// using Subsystems.CustomSQliteORM.External;

namespace TestAzureServices.Models
{
    // public class PostModel : CMPModelBase
    public class PostModel
    {

        [JsonProperty("Post")]
        public string PostString { get; set; }

        [JsonProperty("DateTime")]
        public string DateTimeString { get; set; }

        [JsonProperty("Id")]
        public string IdString { get; set; }

        public bool IsDirty { get; set; }

    }
}
