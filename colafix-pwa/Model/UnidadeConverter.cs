using System;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class UnidadeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Enums.Unidade) || t == typeof(Enums.Unidade?);

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

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CX":
                    return Enums.Unidade.Cx;
                case "FD":
                    return Enums.Unidade.Fd;
                case "KG":
                    return Enums.Unidade.Kg;
                case "SC":
                    return Enums.Unidade.Sc;
                case "UN":
                    return Enums.Unidade.Un;
            }

            throw new Exception("Cannot unmarshal type Unidade");
        }
    }
}
