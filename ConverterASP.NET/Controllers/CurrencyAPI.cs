using System.IO;
using System.Net;

namespace ConverterASP.NET.Controllers
{
    public class CurrencyAPI
    {
        public string GetCurrentCurrency()
        {
            var url = "http://data.fixer.io/api/latest";

            url += "?access_key=f12ef6c4bbb113e8c2116d60bf9499d5";

            var request = (HttpWebRequest) WebRequest.Create(url);

            var response = (HttpWebResponse) request.GetResponse();

            var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}