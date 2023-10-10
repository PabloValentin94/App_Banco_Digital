using App_Banco_Digital.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Chave_Pix : Data_Service
    {

        public static async Task<Chave_Pix> SaveAsyncChavePix(Chave_Pix model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/chave_pix/save");

            Chave_Pix model_retornada = JsonConvert.DeserializeObject<Chave_Pix>(json);

            return model_retornada;

        }

        public static async Task<bool> RemoveAsyncChavePix(int id)
        {

            var post_json = JsonConvert.SerializeObject(id);

            string json = await Data_Service.SendDataApi(post_json, "/chave_pix/remove");

            bool exito = JsonConvert.DeserializeObject<bool>(json);

            return exito;

        }

        public static async Task<List<Chave_Pix>> GetListAsyncChavePix()
        {

            string json = await Data_Service.GetDataApi("/chave_pix/list");

            List<Chave_Pix> lista_chaves_pix = JsonConvert.DeserializeObject<List<Chave_Pix>>(json);

            return lista_chaves_pix;

        }

        public static async Task<List<Chave_Pix>> SearchAsyncChavePix(string parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/chave_pix/search");

            List<Chave_Pix> lista_chaves_pix_encontradas = JsonConvert.DeserializeObject<List<Chave_Pix>>(json);

            return lista_chaves_pix_encontradas;

        }

    }

}