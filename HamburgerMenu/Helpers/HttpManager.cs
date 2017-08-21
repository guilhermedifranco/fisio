using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using HamburgerMenu.Messages;

namespace HamburgerMenu.Helpers
{
    class HttpManager
    {

        public static async Task<T> RequestPostAsync<T, E>(E modelRequest, string url, string contentType)
        {
            using (var client = new HttpClient())
            {
                string body = JsonConvert.SerializeObject(
                    modelRequest,
                    Formatting.Indented,
                    new JsonSerializerSettings()
                    {
                        //ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                        Formatting = Formatting.Indented,
                        NullValueHandling = NullValueHandling.Ignore
                    });
                StringContent content = new StringContent(body, System.Text.Encoding.UTF8, contentType);

                var result = await client.PostAsync(url, content).ConfigureAwait(false);
                var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var erro = JsonConvert.DeserializeObject<ErrorMessageModel>(resultContent);
                    throw new Exception(erro.Message);
                }
                return JsonConvert.DeserializeObject<T>(resultContent);
            }
        }


        public static async Task<T> RequestGetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var result = await client.GetAsync(url).ConfigureAwait(false);
                var resultContent = await result.Content.ReadAsStringAsync().ConfigureAwait(false);

                if (result.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    var erro = JsonConvert.DeserializeObject<ErrorMessageModel>(resultContent);
                    throw new Exception(erro.Message);
                }

                return JsonConvert.DeserializeObject<T>(resultContent);
            }
        }
    }
}
