using clmodel;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;

namespace API
{
    public class ApiClient
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        public ApiClient(string apiUrl)
        {
            this.apiUrl = apiUrl;
            httpClient = new HttpClient();
        }

        public async Task<List<FuncionarioModel>> ObterFuncionariosAsync() //GET
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/funcionarios");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<FuncionarioModel> funcionarios = JsonConvert.DeserializeObject<List<FuncionarioModel>>(json);
                    //Console.WriteLine(json);
                    return funcionarios;
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
        public async Task<FuncionarioModel> ObterPorIdAsync(int id) //GET
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/funcionarios/{id}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    FuncionarioModel funcionario = JsonConvert.DeserializeObject<FuncionarioModel>(json);
                    return funcionario;
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

        public async Task CadastrarFuncionarioAsync(FuncionarioModel funcionario) // POST
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/funcionarios", funcionario);

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
        public async Task AtualizarFuncionarioAsync(FuncionarioModel funcionario) // PUT
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync($"{apiUrl}/funcionarios/{funcionario.Id}", funcionario);

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

        public async Task ExcluirFuncionarioAsync(int funcionarioId) // DELETE
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{apiUrl}/funcionarios/{funcionarioId}");

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
        public async Task<double> CalcularHorasExtrasAsync(int funcionarioId)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/funcionarios/{funcionarioId}/calcular-horas-extras");

                if (response.IsSuccessStatusCode)
                {
                    // Processar a resposta e obter o valor das horas extras, por exemplo:
                    string json = await response.Content.ReadAsStringAsync();
                    double horasExtras = JsonConvert.DeserializeObject<double>(json);
                    return horasExtras;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Tratar o caso em que o recurso não foi encontrado (status 404)
                    return 0.0; // Ou outro valor padrão, dependendo do contexto
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

        public async Task<double> CalcularINSSAsync(int funcionarioId, double salario)
        {
            try
            {
                // Se necessário, envie o salário como parte da requisição
                var content = new StringContent(JsonConvert.SerializeObject(new { Salario = salario }), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{apiUrl}/funcionarios/{funcionarioId}/calcularinss", content);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<double>(json);
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

        public async Task<double> CalcularImpostoRendaAsync(int funcionarioId, double salario)
        {
            try
            {
                // Se necessário, envie o salário como parte da requisição
                var content = new StringContent(JsonConvert.SerializeObject(new { Salario = salario }), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await httpClient.PostAsync($"{apiUrl}/funcionarios/{funcionarioId}/calcularimpostorenda", content);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<double>(json);
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
        public async Task<HoleriteModel> ObterHoleriteAsync(int funcionarioId)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/funcionarios/{funcionarioId}");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    HoleriteModel holerite = JsonConvert.DeserializeObject<HoleriteModel>(json);
                    //Console.WriteLine(json);
                    return holerite;
                }
                else if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    // Tratar o caso em que o recurso não foi encontrado (status 404)
                    return null; // Ou outro valor padrão, dependendo do contexto
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


    }

}
