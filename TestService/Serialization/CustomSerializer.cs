using Newtonsoft.Json;

namespace TestService.Serialization
{
    public class CustomSerializer : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    public static class GlobalSerializer
    {
        public static CustomSerializer Serializer { get; set; } = new CustomSerializer();
    }

}
