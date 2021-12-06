using System;
using System.Net.Http;
using System.Threading.Tasks;
using to_do.DTOs.@abstract;
namespace to_do.Services.@abstract
{
    public class AbstractCreateReadUpdateService<RESPONSE, CREATE_REQUEST, UPDATE_REQUEST>
        : AbstractCreateReadService<RESPONSE, CREATE_REQUEST>,
        IAbstractCreateReadUpdateService<RESPONSE, CREATE_REQUEST, UPDATE_REQUEST>
        where RESPONSE : AbstractIdentifiableDTO.AbstractIdentifiableResponse
    {
        public AbstractCreateReadUpdateService(
            HttpClient http,
            string host,
            string resource) : base(http, host, resource) {}

        public async Task<RESPONSE> Update(UPDATE_REQUEST updates, int id)
        {
            HttpResponseMessage responseMessage = await http.PutAsync(
                host + resource + "/" + id.ToString(),
                RequestToJsonStringContent<UPDATE_REQUEST>(updates));
            return await GetResponseFromMessage<RESPONSE>(responseMessage);
        }
    }
}
