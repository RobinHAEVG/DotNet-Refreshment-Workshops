using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HttpClientsExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 verschiede Klassen
            // 1. WebClient-Klasse
            // 2. HttpClient-Klasse

            //using var wc = new WebClient();
            //var result = wc.DownloadString("http://codework.me:8080/");
            //Console.WriteLine(result);

            using var httpClient = new HttpClient()
            {
                Timeout = new TimeSpan(0, 0, 0, 5),
                BaseAddress = new Uri("http://codework.me:8080/")
            };
           
            //HttpRequestMessage getRequest = new HttpRequestMessage(HttpMethod.Get, "");
            //HttpResponseMessage getResponse = httpClient.SendAsync(getRequest).Result;
            //Console.WriteLine(getResponse.Content.ReadAsStringAsync().Result);


            //var listRequest = new HttpRequestMessage(HttpMethod.Get, "list");
            //var listResponse = httpClient.SendAsync(listRequest).Result;
            //string listContent = listResponse.Content.ReadAsStringAsync().Result;
            //List<WeatherEntry> weatherList = JsonSerializer.Deserialize<List<WeatherEntry>>(listContent);
            //if (weatherList != null)
            //{
            //    foreach (WeatherEntry e in weatherList)
            //    {
            //        Console.WriteLine($"Entry with Id {e.Id} has temperature {e.Temperature}°C.");
            //    }
            //}


            //var neuerEintrag = new WeatherEntry()
            //{
            //    Id = 7,
            //    Temperature = 8.9,
            //    Pressure = 981,
            //    Prediction = "Cloudy",
            //    Datetime = DateTime.Now,
            //};

            //HttpRequestMessage postRequest = new HttpRequestMessage(HttpMethod.Post, "add");
            //postRequest.Content = new StringContent(JsonSerializer.Serialize(neuerEintrag));
            //var postResponse = httpClient.SendAsync(postRequest).Result;
            //Console.WriteLine(postResponse.ReasonPhrase);

            //var changedEntry = new WeatherEntry()
            //{
            //    Id = 1,
            //    Temperature = 38.1,
            //    Pressure = 1022,
            //    Prediction = "Scorching",
            //    Datetime = DateTime.Now,
            //};
            //var putRequest = new HttpRequestMessage(HttpMethod.Put, "edit");
            //putRequest.Content = new StringContent(JsonSerializer.Serialize(changedEntry));
            //var putReponse = httpClient.SendAsync(putRequest).Result;
            //Console.WriteLine(putReponse.ReasonPhrase);

            string apikey = "dsfja030wnfnafnwamf0wamfwang0wqng09nswgqw03ngqne";

            var deleteEntry = new WeatherEntry()
            {
                Id = 7,
            };
            var deleteRequest = new HttpRequestMessage(HttpMethod.Delete, "remove");
            deleteRequest.Headers.Add("X-Api-Token", apikey);
            deleteRequest.Content = new StringContent(JsonSerializer.Serialize(deleteRequest));
            var deleteReponse = httpClient.SendAsync(deleteRequest).Result;
            Console.WriteLine(deleteReponse.ReasonPhrase);

            // Convenience-Methoden:
            //var res2 = httpClient.GetAsync(uri).Result;

            Console.WriteLine("\nPress any key to quit.");
            Console.ReadKey();
        }
    }

    class WeatherEntry
    {
        [JsonPropertyName("id")] public int Id { get; set; }
        [JsonPropertyName("temperature")] public double Temperature { get; set; }
        [JsonPropertyName("pressure")] public int Pressure { get; set; }
        [JsonPropertyName("prediction")] public string Prediction { get; set; }
        [JsonPropertyName("datetime")] public DateTime Datetime { get; set; }
    }
}
