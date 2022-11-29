using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace find_adress_by_CEP
{
    internal class AdressQuery
    {
        private static HttpClient _client = new HttpClient();

        /// Make a http request to the api
        /// Desserialize the json return and turn in into an Adress object
        /// And resturn the object desserialized
        /// 
        public static async Task<Adress> GetAdress(String cep)
        {
            String response = await _client.GetStringAsync($"https://viacep.com.br/ws/{cep}/json/");
            Adress adress = Newtonsoft.Json.JsonConvert.DeserializeObject<Adress>(response);
            
            return await Task.FromResult(adress);
        }
    }
}
