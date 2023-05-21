using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Diagnostics;

namespace Services.BoredAPI;


public class BoredApi
{
    private HttpClient restClient = new HttpClient();
    private string URI = "https://www.boredapi.com/api/activity";
    
    private readonly Dictionary<string, object> _queryparams = new Dictionary<string, object>()
    {
        ["type"] = "social",
        ["participants"] = "2"
    };
    private readonly Dictionary<string, string> _headers = new Dictionary<string, string>() 
    {
        ["Accept"] = "*/*",
        ["Accept-Encoding"] = "gzip, deflate, br",
        ["Content-Type"] = "application/json",
        ["Connection"] = "keep-alive"

    };
    public async Task<string> Get_200Ok() {
        restClient.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
        restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept","*/*");
        restClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Encoding", "gzip, deflate, br");
        restClient.DefaultRequestHeaders.TryAddWithoutValidation("Connection", "keep-alive");

        var response = await restClient.GetAsync(URI);
        var reasonPhrase = response.ReasonPhrase.ToString();
        return reasonPhrase;

    }

};
