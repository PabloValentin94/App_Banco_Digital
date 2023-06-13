using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Conta : Data_Service
    {

        public static async Task<Conta> SaveAsyncConta(Conta model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/conta/save");

            Conta model_retornada = JsonConvert.DeserializeObject<Conta>(json);

            return model_retornada;

        }

        public static async Task<List<Conta>> GetListAsyncConta()
        {

            string get_json = await Data_Service.GetDataApi("/conta/list");

            List<Conta> lista_contas = JsonConvert.DeserializeObject<List<Conta>>(get_json);

            return lista_contas;

        }

    }

}
