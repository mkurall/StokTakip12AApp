using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip12AApp.Api
{
    public static class HttpUtils
    {
        static string _token;
        static string baseUrl="https://stoktakip.kurall.com/";

        public static void SetToken(string token)
        {
            _token = token;
        }
        public async static Task<HttpResponseMessage> GetAsync(string method)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, sslPloicyErrors) =>
            {
                return true;//sertifika geçerli
            };


            HttpClient client = new HttpClient(handler);

            if(_token != null) 
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);


            HttpResponseMessage resp = await client.GetAsync(baseUrl + method);

            return resp;
        }

        public async static Task<HttpResponseMessage> PostAsync(string method, string jsonParams)
        {
            HttpClientHandler handler = new HttpClientHandler();
            handler.ServerCertificateCustomValidationCallback = (msg, cert, chain, sslPloicyErrors) =>
            {
                return true;//sertifika geçerli
            };


            HttpClient client = new HttpClient(handler);

            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token);

            var values = JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonParams);
            var content = new FormUrlEncodedContent(values);
            string query = await content.ReadAsStringAsync();

            HttpResponseMessage resp = await client.PostAsync(baseUrl + method + "?" + query, null);

            return resp;
        }

    }
}
