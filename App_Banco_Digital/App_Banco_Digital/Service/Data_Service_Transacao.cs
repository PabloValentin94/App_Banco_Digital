using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

using Newtonsoft.Json;

namespace App_Banco_Digital.Service
{

    public class Data_Service_Transacao : Data_Service
    {

        public static async Task<Transacao> SaveAsyncTransacao(Transacao model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/transacao/save");

            Transacao model_retornada = JsonConvert.DeserializeObject<Transacao>(json);

            return model_retornada;

        }

        public static async Task<List<Transacao>> GetListAsyncTransacao()
        {

            string json = await Data_Service.GetDataApi("/transacao/list");

            List<Transacao> lista_transacoes = JsonConvert.DeserializeObject<List<Transacao>>(json);

            return lista_transacoes;

        }

        public static async Task<List<Transacao>> SearchAsyncTransacao(int parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service_Transacao.SendDataApi(post_json, "/transacao/search");

            List<Transacao> lista_transacoes_encontradas = JsonConvert.DeserializeObject<List<Transacao>>(json);

            return lista_transacoes_encontradas;

        }

    }

}