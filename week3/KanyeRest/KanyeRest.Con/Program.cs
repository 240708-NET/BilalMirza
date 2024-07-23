using System;
using System.Net.Http;
using System.Text.Json;

using KanyeRest.Models;

namespace KanyeRest.Con
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string uri = "https://api.kanye.rest"; // Define Uri response to receive

            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(uri); // Captures response -> can use Get, Head, Post, Delete etc.

            Quote kanyeQuote = JsonSerializer.Deserialize<Quote>(response);

            Console.WriteLine("\nKanye once said...\n" + kanyeQuote.quote +"\n");
        }
    }
}