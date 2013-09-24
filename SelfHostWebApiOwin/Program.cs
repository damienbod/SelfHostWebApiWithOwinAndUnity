using Microsoft.Owin.Hosting;
using System;
using System.Net.Http;

namespace SelfHostWebApiOwin.Console
{
    public class Program
    {
        static void Main()
        {
            string baseAddress = "http://localhost:8081/";

            WebApp.Start<Web.Startup>(url: baseAddress);
            // Start OWIN host 
            //using (WebApp.Start<Startup>(url: baseAddress))
            //{
            //    // Create HttpCient and make a request to api/values 
            //    HttpClient client = new HttpClient();

            //    var response = client.GetAsync(baseAddress + "api/values").Result;

            //    Console.WriteLine(response);
            //    Console.WriteLine(response.Content.ReadAsStringAsync().Result);
            //    Console.ReadLine();
            //}

            Console.ReadLine();
        }
    } 
}
