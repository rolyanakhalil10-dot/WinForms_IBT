using IBTdataAcessLayer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IBTbusinessLogicLayer
{
    public class clsExchangeRates
    {
        public async Task<Dictionary<string, double>> GetLiveRatesAsync(string baseCurrency = "USD")
        {
            string apiUrl = $"https://api.exchangerate.host/latest?base={baseCurrency}";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (!response.IsSuccessStatusCode)
                    throw new Exception("Failed to get live exchange rates.");

                string json = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<ExchangeRateResponse>(json);

                if (data?.Rates == null)
                    throw new Exception("API response did not contain 'rates'.");

                return data.Rates;
            }
        }
        private class ExchangeRateResponse
        {
            [JsonProperty("rates")]
            public Dictionary<string, double> Rates { get; set; }
        }

        public async Task UpdateAllRatesInDB()
        {
            var liveRates = await GetLiveRatesAsync("USD");

            if (liveRates == null)
                throw new Exception("Live rates response was null.");

            foreach (var rate in liveRates)
            {
                if (rate.Key == null)
                    throw new Exception("Currency code (key) was null.");
                clsExchangeRatesData.UpdateRate(rate.Key, rate.Value);
            }
        }
        //public class ExchangeRateResponse
        //{
        //    public Dictionary<string, double> Rates { get; set; }
        //}
    }
}
