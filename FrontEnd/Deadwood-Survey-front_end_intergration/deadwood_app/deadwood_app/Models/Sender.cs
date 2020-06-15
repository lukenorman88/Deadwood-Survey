using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace deadwood_app.Models
{
    public class Sender
    {
        static HttpClient client = new HttpClient();
        public async Task RunAsync(Survey s)
        {
            client.BaseAddress = new Uri("http://soc-web-liv-57.napier.ac.uk/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            try
            {

                var url = await CreateSurveyAsync(s);
                //Console.WriteLine($"Create at {url}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Innter exception" + e.InnerException);
                Console.WriteLine("Innter exception" + e.StackTrace);
                Console.WriteLine("Innter exception" + e.Message);
            }

            //Console.ReadLine();
        }

        public async Task<Uri> CreateSurveyAsync(Survey survey)
        {
            // Convert the provided survey to a JSON string
            var payload = JsonConverter.Convert(survey);

            // Create new instance of the http content and add the Survey JSON string along with other setting info
            var httpContent = new StringContent(payload, Encoding.UTF8, "application/json");

            // Get response from the client with the provived content
            HttpResponseMessage response = await client.PostAsync("api/SurveyItems", httpContent);

            response.EnsureSuccessStatusCode();
            //Console.WriteLine(response.RequestMessage);
            var content = await response.Content.ReadAsStringAsync();
            //Console.WriteLine(httpContent.ToString());
            // return URI of the created resource.
            return response.Headers.Location;
        }
    }
}
