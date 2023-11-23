using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

using Newtonsoft.Json;

namespace App_Banco_Digital.Service
{

    internal class Data_Service_Transacao_Contas_Assoc : Data_Service
    {

        public static async Task<Transacao_Contas_Assoc> SaveAsyncTransacaoContasAssoc(Transacao_Contas_Assoc model)
        {

            var post_json = JsonConvert.SerializeObject(model);

            string json = await Data_Service.SendDataApi(post_json, "/transacao_contas_assoc/save");

            Transacao_Contas_Assoc model_retornada = JsonConvert.DeserializeObject<Transacao_Contas_Assoc>(json);

            return model_retornada;

        }

        public static async Task<List<Transacao_Contas_Assoc>> GetListAsyncTransacaoContasAssoc()
        {

            string json = await Data_Service.GetDataApi("/transacao_contas_assoc/list");

            List<Transacao_Contas_Assoc> dados_transacoes = JsonConvert.DeserializeObject<List<Transacao_Contas_Assoc>>(json);

            return dados_transacoes;

        }

        public static async Task<List<Transacao_Contas_Assoc>> SearchAsyncTransacaoContasAssoc(int parametro)
        {

            var post_json = JsonConvert.SerializeObject(parametro);

            string json = await Data_Service.SendDataApi(post_json, "/transacao_contas_assoc/search");

            List<Transacao_Contas_Assoc> dados_transacoes_encontradas = JsonConvert.DeserializeObject<List<Transacao_Contas_Assoc>>(json);

            return dados_transacoes_encontradas;

        }

    }

}