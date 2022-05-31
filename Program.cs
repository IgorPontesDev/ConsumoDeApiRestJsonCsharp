using Newtonsoft.Json;
using System;
using System.Net.Http;
// See https://aka.ms/new-console-template for more information
//Sites usados Jsonplaceholder e QuickyType
namespace ConsumoDeAPIExample
{
    class Program {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync("https://jsonplaceholder.typicode.com/users");
            var content = await response.Content.ReadAsStringAsync();

            var users = JsonConvert.DeserializeObject<ApiInfo.Users[]>(content);
            foreach (var item in users)
            {
                Console.WriteLine("Olá meu nome é "+item.Name+" e trabalho na empresa"+ item.Company.Name+"\n");
            }

        }
    }
}