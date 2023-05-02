using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using App_Banco_Digital.Model;

using Newtonsoft.Json;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Correntista : Data_Service
    {

        public static async Task<List<Correntista>> GetListAsync()
        {

            string get_json = await Data_Service.GetDataFromService("/correntista");

            List<Correntista> lista_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(get_json);

            return lista_correntistas;

        }

        public static async Task<Correntista> RegisterAsync(Correntista model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.PostDataToService(post_json, "/correntista/salvar");

            Correntista retorno = JsonConvert.DeserializeObject<Correntista>(json);

            return retorno;

        }

        public static async Task<List<Correntista>> RemoveAsync(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.PostDataToService(post_json, "/correntista/apagar");

            List<Correntista> lista_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return lista_correntistas;

        }

        public static async Task<List<Correntista>> QueryAsync(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.PostDataToService(post_json, "/correntista/pesquisar");

            List<Correntista> lista_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return lista_correntistas;

        }

    }

}
