﻿using System;
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
            var responseString = await http.GetAsync(host + resource + "/" + id.ToString());
            return await GetResponseFromMessage<RESPONSE>(responseString);
        }

        protected static async Task<RESP_TYPE> GetResponseFromMessage<RESP_TYPE>(HttpResponseMessage message)
        {
            var responseContent = await message.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<RESP_TYPE>(responseContent);
        }
    }
}
