using Dominio.Model;
using Newtonsoft.Json;

namespace Dominio.Facade
{
    public class Cerberus
    {
        public async Task<UsuarioModel> autenticarAsync(string ambiente, string provedor, string consumidor, string chaveAcesso, string usuario, string senha)
        {
            try
            {
                using (HttpClient httpClient = new HttpClient())
                {

                var request = new HttpRequestMessage(HttpMethod.Get, "xxxxxxxxxx");
                request.Headers.Add("ambiente", ambiente);
                request.Headers.Add("provedor", provedor);
                request.Headers.Add("consumidor", consumidor);
                request.Headers.Add("chaveAcesso", chaveAcesso);
                request.Headers.Add("usuario", usuario);
                request.Headers.Add("senhaUsuario", senha);

                var response = await httpClient.SendAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    UsuarioModel oUsuario = JsonConvert.DeserializeObject<UsuarioModel>(responseString);
                    return oUsuario;
                    }
                else
                    throw new Exception(string.Format("Status Code: {0}, Status Description: {1}", response.StatusCode, response.ReasonPhrase));

            }

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}