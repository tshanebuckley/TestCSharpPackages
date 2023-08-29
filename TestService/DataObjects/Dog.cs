using System.Text.Json.Serialization;
using TestService.Serialization;

namespace TestService.DataObjects
{
    public class Dog : BaseObject
    {
        [JsonIgnore]
        [SerializableProp]
        public Dog Friend { get; set; }

        [JsonIgnore]
        [SerializableProp]
        public bool GoodDog { get; set; }

    }
}
