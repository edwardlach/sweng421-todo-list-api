using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public abstract class AbstractReadService<RESPONSE>
        : IAbstractReadService<RESPONSE>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        protected HttpClient http;
        protected string host;
        protected string resource;

        protected AbstractReadService(
            HttpClient http,
            string host,
            string resource)
        {
            this.http = http;
            this.host = host;
            this.resource = resource;
        }

        public async Task<RESPONSE> Read(int id)
        {
            var responseString = await http.GetStringAsync(host + resource + "/" + id);
            return JsonConvert.DeserializeObject<RESPONSE>(responseString);
        }
    }
}
