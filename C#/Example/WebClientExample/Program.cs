using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Net.Http;

namespace WebClientExample
{
    public class Program
    {
        static  void Main(string[] args)
        {
            string uri = @"https://www.baidu.com";
            WebClient webClient = new WebClient();
            // webClient.BaseAddress = uri;
            webClient.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = webClient.OpenRead(uri);
            StreamReader sw = new StreamReader(data);
            string s = sw.ReadToEnd();

            GetWebContentAsync();
            Console.WriteLine(s);


            Console.ReadKey();          
        }
        static async Task GetWebContentAsync()
        {
            string uri = @"https://www.baidu.com";
            HttpClient httpClient = new HttpClient();
            try
            {
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(uri);
                httpResponseMessage.EnsureSuccessStatusCode();
                string responseBody = await httpResponseMessage.Content.ReadAsStringAsync();
                httpClient.Dispose();
                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException ex)
            {
                httpClient.Dispose();
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
