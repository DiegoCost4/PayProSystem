using clmodel;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace API
{
    public class ApiUsers
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl;

        public ApiUsers(string apiUrl)
        {
            this.apiUrl = apiUrl;
            httpClient = new HttpClient();
        }
        public async Task<List<UsuarioModel>> ObterUsuariosAsync() //GET
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync($"{apiUrl}/usuarios");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<UsuarioModel> usuarios = JsonConvert.DeserializeObject<List<UsuarioModel>>(json);
                    //Console.WriteLine(json);
                    return usuarios;
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
        public async Task CadastrarUsuarioAsync(UsuarioModel usuario) // POST
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsJsonAsync($"{apiUrl}/usuarios", usuario);

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
        public async Task AtualizarUsuarioAsync(UsuarioModel usuario) // PUT    
        {
            try
            {
                HttpResponseMessage response = await httpClient.PutAsJsonAsync($"{apiUrl}/usuarios/{usuario.Id}", usuario);

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
        public async Task ExcluirUsuarioAsync(int usuarioId) // DELETE
        {
            try
            {
                HttpResponseMessage response = await httpClient.DeleteAsync($"{apiUrl}/usuarios/{usuarioId}");

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

