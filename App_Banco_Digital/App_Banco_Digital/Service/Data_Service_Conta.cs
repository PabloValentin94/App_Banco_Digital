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

        public static async Task<Conta>? SaveAsyncConta(Conta model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/conta/save");

            Conta model_retornada = JsonConvert.DeserializeObject<Conta>(json);

            return model_retornada;

        }

        public static async Task<bool>? EnableAsyncConta(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/conta/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool>? DisableAsyncConta(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/conta/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Conta>>? GetListAsyncConta()
        {

            string get_json = await Data_Service.GetDataApi("/conta/list");

            List<Conta> lista_contas = JsonConvert.DeserializeObject<List<Conta>>(get_json);

            return lista_contas;

        }

        public static async Tsk<List<Conta>>? SearchAsyncConta(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/conta/search");

            List<Conta> lista_contas_encontradas = JsonConvert.SerializeObject<List<Conta>>(json);

            return lista_contas_encontradas;

        }

    }

}