using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

using App_Banco_Digital.Model;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Conta : Data_Service
    {

        public static async Task<List<Conta>> GetListAsync()
        {

            string get_json = await Data_Service.GetDataFromService("/conta");

            List<Conta> lista_contas = JsonConvert.DeserializeObject<List<Conta>>(get_json);

            return lista_contas;

        }

        public static async Task<Conta> RegisterAsync(Conta model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.PostDataToService(post_json, "/conta/salvar");

            Conta retorno = JsonConvert.DeserializeObject<Conta>(json);

            return retorno;

        }

    }

}
