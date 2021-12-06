using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public class AbstractCreateReadService<RESPONSE, CREATE_REQUEST>
        : AbstractReadService<RESPONSE>, IAbstractCreateReadService<RESPONSE, CREATE_REQUEST>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        protected AbstractCreateReadService(
            HttpClient http,
            string host,
            string resource) : base(http, host, resource) {}

        public async Task<RESPONSE> Create(CREATE_REQUEST request)
        {
            HttpResponseMessage responseMessage = await http.PostAsync(
                host + resource,
                RequestToJsonStringContent<CREATE_REQUEST>(request));
            return await GetResponseFromMessage<RESPONSE>(responseMessage);
        }

        protected StringContent RequestToJsonStringContent<T>(T request)
        {
            var json = JsonConvert.SerializeObject(request);
            return new StringContent(json, UnicodeEncoding.UTF8, "application/json");
        }
    }
}
