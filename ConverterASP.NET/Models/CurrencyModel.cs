using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ConverterASP.NET.Models
{
    public enum CurrencyEnum
    {
        USD,
        EUR,
        RUB,
        GBP,
        JPY
    }

    public class CurrencyModel
    {
        public float Input { get; set; }
        public float Output { get; set; }
        public string InputCurrency { get; set; }
        public string OutputCurrency { get; set; }
    }

    public class CurrencyJSON
    {
        public Dictionary<string, float> rates;

        public CurrencyJSON(string json)
        {
            var jObject = JObject.Parse(json);
            success = (bool) jObject["success"];
            timestamp = (float) jObject["timestamp"];
            base2 = (string) jObject["base2"];
            date = (string) jObject["base2"];
            rates = JsonConvert.DeserializeObject<Dictionary<string, float>>(jObject["rates"].ToString());
        }

        public bool success { get; set; }
        public float timestamp { get; set; }
        public string base2 { get; set; }
        public string date { get; set; }
    }
}