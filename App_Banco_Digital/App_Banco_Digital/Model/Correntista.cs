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

        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string email { get; set; }

        public string data_nascimento { get; set; }

        public string senha { get; set; }

        public int ativo { get; set; } = 1;

        public string data_cadastro { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public List<Model.Conta> dados_contas { get; set; }

        public async Task<bool> Save()
        {

            if(String.IsNullOrWhiteSpace(this.nome) || String.IsNullOrWhiteSpace(this.cpf) ||
               String.IsNullOrWhiteSpace(this.data_nascimento) || String.IsNullOrWhiteSpace(this.senha))
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {

                Model.Correntista correntista_retornado = await Service.Data_Service_Correntista.SaveAsyncCorrentista(this);

                if(correntista_retornado.id != null)
                {

                    return true;

                }

                else
                {

                    throw new Exception("Não foi possível salvar esses dados! Revise-os e tente novamente.");

                }

            }

        }

        public static async Task<bool> Enable(int id)
        {

            bool exito = await Service.Data_Service_Correntista.EnableAsyncCorrentista(id);

            if(exito)
            {

                return true;
                
            }

            else
            {

                return false;

            }

        }

        public static async Task<bool> Disable(int id)
        {

            bool exito = await Service.Data_Service_Correntista.DisableAsyncCorrentista(id);

            if(exito)
            {

                return true;

            }

            else
            {

                return false;

            }

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