using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HttpClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://10.203.55.12:8081/SGM_FEB/RouteBillBody");
                var content = new MultipartFormDataContent();
                content.Headers.Add("Content-Type", "application/json");
                content.Add()
                client.PostAsync(;
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
