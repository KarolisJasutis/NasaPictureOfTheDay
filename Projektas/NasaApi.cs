using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Configuration;
using Newtonsoft.Json;
namespace Projektas
{
    internal class NasaApi
    {
        private string apiKey = ConfigurationSettings.AppSettings["ApiKey"];
        private string apiUrl = "https://api.nasa.gov/planetary/apod";

        public async Task<PotdData> GetPOTD(DateTime date)
        {
            string formDate = date.ToString("yyyy-MM-dd");
            string requestUrl = $"{apiUrl}?api_key={apiKey}&date={formDate}";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(requestUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        String ReceivedData = await response.Content.ReadAsStringAsync();
                        PotdData Rdata = JsonConvert.DeserializeObject<PotdData>(ReceivedData);
                        return Rdata;
                    }
                    else
                    {
                        Console.WriteLine($"Error, api no give info");
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Exception: {ex.Message}");
                    return null;
                }
            }
        }
    }
}
