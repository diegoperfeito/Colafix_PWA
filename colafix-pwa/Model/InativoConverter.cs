using System;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class InativoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Enums.Inativo) || t == typeof(Enums.Inativo?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "N")
            {
                return Enums.Inativo.N;
            }
            throw new Exception("Cannot unmarshal type Inativo");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Enums.Inativo)untypedValue;
            if (value != Enums.Inativo.N) throw new Exception("Cannot marshal type Inativo");
            serializer.Serialize(writer, "N");
        }

        public static readonly InativoConverter Singleton = new InativoConverter();
    }
}
