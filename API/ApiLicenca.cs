using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using clmodel;
using Newtonsoft.Json;

namespace API
{
    public class ApiLicenca
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        public ApiLicenca(string apiUrl)
        {
            this.apiUrl = apiUrl;
            httpClient = new HttpClient();
        }

        public async Task<List<LicencaModel>> ObterLicencasAsync()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/licenca");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<LicencaModel> licenca = JsonConvert.DeserializeObject<List<LicencaModel>>(json);
                    //Console.WriteLine(json);
                    return licenca;
                }
                else
                {
                    throw new Exception($"Erro na solicitação: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        public async Task CadastrarLicencaAsync(LicencaModel licenca)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/licenca", licenca);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro na solicitação: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }
        public async Task AtualizarLicencaAsync(LicencaModel licenca) // PUT
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync($"{apiUrl}/licenca/{licenca.Id}", licenca);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro na solicitação: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }

        public async Task ExcluirLicencaAsync(int idLicenca)
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{apiUrl}/licenca/{idLicenca}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Erro na solicitação: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro: {ex.Message}");
            }
        }
    }
}
