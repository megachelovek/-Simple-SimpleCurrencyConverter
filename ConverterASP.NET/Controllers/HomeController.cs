using System.Web.Mvc;
using ConverterASP.NET.Models;

namespace ConverterASP.NET.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CurrencyModel currencyModel)
        {
            var сurrencyApi = new CurrencyAPI();
            var json = сurrencyApi.GetCurrentCurrency();
            var currencyJson = new CurrencyJSON(json);
            var inputCurrency = currencyJson.rates[currencyModel.InputCurrency];
            currencyModel.Output =
                currencyJson.rates[currencyModel.OutputCurrency] / inputCurrency * currencyModel.Input;
            return View(currencyModel);
        }

        public CurrencyModel ConvertCurrency(CurrencyModel currencyModel)
        {
            return currencyModel;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Конвертер валюты";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Гит.";

            return View();
        }

        public string GetCurrency()
        {
            var сurrencyApi = new CurrencyAPI();
            return сurrencyApi.GetCurrentCurrency();
        }
    }
}