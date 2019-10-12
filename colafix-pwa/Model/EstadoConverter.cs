using System;
using Newtonsoft.Json;

namespace colafix_pwa.Model
{
    public class EstadoConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Enums.Estado) || t == typeof(Enums.Estado?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "PR":
                    return Enums.Estado.Pr;
                case "RN":
                    return Enums.Estado.Rn;
                case "RO":
                    return Enums.Estado.Ro;
                case "RS":
                    return Enums.Estado.Rs;
                case "SC":
                    return Enums.Estado.Sc;
                case "SP":
                    return Enums.Estado.Sp;
                case "UY":
                    return Enums.Estado.Uy;
            }

            throw new Exception("Cannot unmarshal type Estado");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Enums.Estado)untypedValue;
            switch (value)
            {
                case Enums.Estado.Pr:
                    serializer.Serialize(writer, "PR");
                    return;
                case Enums.Estado.Rn:
                    serializer.Serialize(writer, "RN");
                    return;
                case Enums.Estado.Ro:
                    serializer.Serialize(writer, "RO");
                    return;
                case Enums.Estado.Rs:
                    serializer.Serialize(writer, "RS");
                    return;
                case Enums.Estado.Sc:
                    serializer.Serialize(writer, "SC");
                    return;
                case Enums.Estado.Sp:
                    serializer.Serialize(writer, "SP");
                    return;
                case Enums.Estado.Uy:
                    serializer.Serialize(writer, "UY");
                    return;
            }
            throw new Exception("Cannot marshal type Estado");
        }

        public static readonly EstadoConverter Singleton = new EstadoConverter();
    }
}
