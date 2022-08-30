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
            using (HttpClient client = new())
            {
                var jsonstring = await client.GetStringAsync(url);
                var value = JsonConvert.DeserializeObject<Cat>(jsonstring);
                return value;
            }
           
        }

    }
}
