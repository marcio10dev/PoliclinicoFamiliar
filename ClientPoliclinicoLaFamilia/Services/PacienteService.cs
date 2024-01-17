using Newtonsoft.Json;
using ClientPoliclinicoLaFamilia.Models;
namespace ClientPoliclinicoLaFamilia.Services
{
    public class PacienteService
    {
        string url = "https://localhost:7033/";
        string endPoint = "";
        HttpClient client = new HttpClient();
        public async Task<List<Paciente>> ListaIngredientes()
        {
            endPoint = "api/Pacientes";
            client.BaseAddress = new Uri(url);
            HttpResponseMessage response = await client.GetAsync(endPoint);
            List<Paciente> result = new List<Paciente>();
            if (response.IsSuccessStatusCode)
            {
                string respuestaCuerpo = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<List<Paciente>>(respuestaCuerpo);
            }
            return result;
        }
    }
}
