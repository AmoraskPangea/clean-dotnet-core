using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace CleanDotNetCore.Models
{
    public class Person
    {
        [JsonProperty("id")]
        public Guid? Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("pet")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Pet? Pet { get; set; }
    }

    public enum Pet
    {
        Cat,
        Dog
    }
}
