using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{

    public class Conta
    {

        public int id { get; set; }

        public double saldo { get; set; }

        public double limite { get; set; }

        public string tipo { get; set; } = "Corrente";

        public int ativa { get; set; } = 1;

        public int fk_correntista { get; set; } = 0;

        public string data_abertura { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        /*public async Task<bool>? Save()
        {

            if()
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {



            }

        }*/

        public static async Task<bool>? Enable(int id)
        {

            bool exito = await Service.Data_Service_Conta.EnableAsyncConta(id);

            if (exito)
            {

                return true;

            }

            else
            {

                return false;

            }

        }

        public static async Task<bool>? Disable(int id)
        {

            bool exito = await Service.Data_Service_Conta.DisableAsyncConta(id);

            if (exito)
            {

                return true;

            }

            else
            {

                return false;

            }

        }

        public static async Task<List<Correntista>>? GetList()
        {

            return await Service.Data_Service_Conta.GetListAsyncConta();

        }

        public static async Task<List<Correntista>>? Search(string parametro)
        {

            return await Service.Data_Service_Conta.SearchAsyncConta(parametro);

        }

    }

}