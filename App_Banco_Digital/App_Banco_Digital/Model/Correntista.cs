using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Model
{

    public class Correntista
    {

        public int id_correntista { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string data_nascimento { get; set; }

        public string senha_correntista { get; set; }

        public int ativo { get; set; } = 1;

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public string[] dados_contas { get; set; }

        public async Task<Correntista> Save()
        {

            return await Service.Data_Service_Correntista.SaveAsyncCorrentista(this);

        }

        public static async Task<bool> Disable(int id)
        {

            return await Service.Data_Service_Correntista.DisableAsyncCorrentista(id);

        }

        public static async Task<bool> Enable(int id)
        {

            return await Service.Data_Service_Correntista.EnableAsyncCorrentista(id);

        }

        public static async Task<List<Correntista>> GetList()
        {

            return await Service.Data_Service_Correntista.GetListAsyncCorrentista();

        }

        public static async Task<List<Correntista>> Search(string parametro)
        {

            return await Service.Data_Service_Correntista.SearchAsyncCorrentista(parametro);

        }

        public static async Task<Correntista> Login(string[] dados_login)
        {

            return await Service.Data_Service_Correntista.LoginAsyncCorrentista(dados_login);

        }

    }

}