using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip12AApp.Api
{
    public static class ApiV1
    {
        public async static Task<ApiCevap> Test()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("api/v1/test");

            if(resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string data = await resp.Content.ReadAsStringAsync();
                
                return new ApiCevap()
                {
                    BasariliMi = true,
                    Data = data
                };
            }
            else
            {
                return new ApiCevap()
                {
                    BasariliMi = false,
                    HataMesaji = "Api çağırma başarısız."
                };
            }
        }

        public async static Task<ApiCevap> Login(string kullaniciAdi, string parola)
        {
            string s = String.Format("{{\"kullaniciAdi\":\"{0}\",\"parola\":\"{1}\"}}", kullaniciAdi, parola);

            HttpResponseMessage resp = await HttpUtils.PostAsync("api/v1/login", s);
        
            string content = await resp.Content.ReadAsStringAsync();

            if(resp.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<ApiCevap>(content);
            }

            return new ApiCevap()
            {
                BasariliMi = false,
                HataMesaji = "Api çağırma başarısız."
            };
        }

        public async static Task<ApiCevap> KategorileriGetir()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("api/v1/KategorileriGetir");

            string content = await resp.Content.ReadAsStringAsync();

            if (resp.StatusCode == System.Net.HttpStatusCode.OK ||
                resp.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return JsonConvert.DeserializeObject<ApiCevap>(content);
            }

            return new ApiCevap()
            {
                BasariliMi = false,
                HataMesaji = "Api çağırma başarısız."
            };
        }

        public async static Task<ApiCevap> UrunleriGetir()
        {
            HttpResponseMessage resp = await HttpUtils.GetAsync("api/v1/UrunleriGetir");

            string content = await resp.Content.ReadAsStringAsync();

            if (resp.StatusCode == System.Net.HttpStatusCode.OK ||
                resp.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                return JsonConvert.DeserializeObject<ApiCevap>(content);
            }

            return new ApiCevap()
            {
                BasariliMi = false,
                HataMesaji = "Api çağırma başarısız."
            };
        }
    }
}
