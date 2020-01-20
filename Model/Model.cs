
namespace Appcent
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class ImageModel
    {
        public Photos photos { get; set; }

        public string stat { get; set; }
    }

    public partial class Photos
    {
        public long page { get; set; }

        public long pages { get; set; }

        public long perpage { get; set; }

        public long total { get; set; }

        public List<Photo> photo { get; set; }
    }

    public partial class Photo
    {
        public string id { get; set; }

        public string owner { get; set; }

        public string secret { get; set; }

        public string server { get; set; }

        public long farm { get; set; }

        public string title { get; set; }

        public long ispublic { get; set; }

        public long isfriend { get; set; }

        public long isfamily { get; set; }
    }

    public partial class ImageModel
    {
        public static ImageModel FromJson(string json) => JsonConvert.DeserializeObject<ImageModel>(json, Appcent.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ImageModel self) => JsonConvert.SerializeObject(self, Appcent.Converter.Settings);
    }

    internal static class Converter
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