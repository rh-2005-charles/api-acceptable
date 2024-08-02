using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Dtos.Stock;
using Api.Interfaces;
using Api.Mappers;
using Api.Models;
using Newtonsoft.Json;

namespace Api.Service
{
    public class FPMService : IFMPService
    {
        private HttpClient _httpClient;
        private IConfiguration _config;

        public FPMService(HttpClient httpClient, IConfiguration config)
        {
            _httpClient = httpClient;
            _config = config;
        }
        public async Task<Stock> FindStockBySymbolAsync(string symbol)
        {
            try
            {
                var result = await _httpClient.GetAsync($"https://financialmodelingprep.com/api/v3/profile/{symbol}?apikey={_config["FMPKey"]}");
                if (result.IsSuccessStatusCode)
                {
                    var content = await result.Content.ReadAsStringAsync();
                    var tasks = JsonConvert.DeserializeObject<FMPStock[]>(content);
                    var stock = tasks[0];
                    if (stock != null)
                    {
                        return stock.ToStockFromFMP();
                    }
                    return null;
                }
                return null;
            }                                          //https://financialmodelingprep.com/api/v3/search?query=AA
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }
    }
}