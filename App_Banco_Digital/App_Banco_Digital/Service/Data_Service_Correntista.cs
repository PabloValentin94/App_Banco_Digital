using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;
using Newtonsoft.Json;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Correntista : Data_Service
    {

        public static async Task<Correntista> SaveAsyncCorrentista(Correntista model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/correntista/save");

            Correntista model_retornada = JsonConvert.DeserializeObject<Correntista>(json);

            return model_retornada;

        }

        public static async Task<bool> DisableAsyncCorrentista(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/correntista/disable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<bool> EnableAsyncCorrentista(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/correntista/enable");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Correntista>> GetListAsyncCorrentista()
        {

            string json = await Data_Service.GetDataApi("/correntista/list");

            List<Correntista> lista_correntistas = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return lista_correntistas;

        }

        public static async Task<List<Correntista>> SearchAsyncCorrentista(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/correntista/search");

            List<Correntista> lista_correntistas_encontrados = JsonConvert.DeserializeObject<List<Correntista>>(json);

            return lista_correntistas_encontrados;

        }

        public static async Task<Correntista> LoginAsyncCorrentista(string[] dados_login)
        {

            var post_json = JsonConvert.SerializeObject(dados_login);

            string json = await Data_Service.SendDataApi(post_json, "/correntista/login");

            Correntista correntista_correspondente = JsonConvert.DeserializeObject<Correntista>(json);

            return correntista_correspondente;

        }

    }

}
