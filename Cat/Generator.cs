using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace Cat
{
    public class Generator
    {
        public async Task<Cat> Generate()
        {
            const string url = "https://catfact.ninja/fact";
            HttpClient client = new();
            var httpresponse = await client.GetAsync(url);
            var jsonstring = await httpresponse.Content.ReadAsStringAsync();
            var value = JsonConvert.DeserializeObject<Cat>(jsonstring);
            return value;
          
        }

    }
}
