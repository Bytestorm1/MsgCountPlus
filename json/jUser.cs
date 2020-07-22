namespace MsgCountPlusNET.json
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Linq;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class jUser
    {
        [JsonProperty("ID", Required = Required.Always)]
        public ulong Id { get; set; }

        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("timestamps", Required = Required.Always)]
        public List<DateTimeOffset> Timestamps { get; set; }

        public List<DateTimeOffset> timesBetween(DateTimeOffset lowEdge, DateTimeOffset highEdge) {
            List<DateTimeOffset> output = new List<DateTimeOffset>();
            output.AddRange(Timestamps.Where(item => item.DateTime >= lowEdge && item.DateTime < highEdge));
            return output;
        }
        public int messageCount() {
            return Timestamps.Count;
        }
    }

    public partial class jUser
    {
        public static jUser FromJson(string json) => JsonConvert.DeserializeObject<jUser>(json, MsgCountPlusNET.json.jUser_Converter.Settings);
    }

    public static class jUser_Serialize
    {
        public static string ToJson(this jUser self) => JsonConvert.SerializeObject(self, MsgCountPlusNET.json.jUser_Converter.Settings);
    }

    internal static class jUser_Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}