using clmodel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class ApiCargos
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        public ApiCargos(string apiUrl)
        {
            this.apiUrl = apiUrl;
            httpClient = new HttpClient();
        }

        public async Task<List<CargosModel>> ObterCargosAsync() //GET
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/cargos");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<CargosModel> cargos = JsonConvert.DeserializeObject<List<CargosModel>>(json);
                    //Console.WriteLine(json);
                    return cargos;
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

        public async Task CadastrarCargoAsync(CargosModel cargo) // POST
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/cargos", cargo);

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
        public async Task AtualizarCargoAsync(CargosModel cargo) // PUT
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync($"{apiUrl}/cargos/{cargo.Id}", cargo);

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

        public async Task ExcluirCargoAsync(int cargoId) // DELETE
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{apiUrl}/cargos/{cargoId}");

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
