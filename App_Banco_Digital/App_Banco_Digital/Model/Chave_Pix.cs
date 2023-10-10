using App_Banco_Digital.Service;
using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Model
{
    public class Chave_Pix
    {

        public int id { get ; set; }

        public string chave { get; set; }

        public string tipo { get; set; }

        public int fk_conta { get; set; } = 0;

        public async Task<bool> Save()
        {

            if(String.IsNullOrEmpty(this.chave) || String.IsNullOrEmpty(this.tipo) || fk_conta == 0)
            {

                throw new Exception("Preencha todos os campos obrigatórios antes de prosseguir.");

            }

            else
            {

                Model.Chave_Pix chave_pix_retornada = await Data_Service_Chave_Pix.SaveAsyncChavePix(this);

                if(chave_pix_retornada.id != null)
                {

                    return true;

                }

                else
                {

                    throw new Exception("Não foi possível salvar esses dados! Revise-os e tente novamente.");

                }

            }

        }

        public static async Task<bool> Remove(int id)
        {

            bool exito = await Data_Service_Chave_Pix.RemoveAsyncChavePix(id);

            if(exito)
            {

                return true;

            }

            else
            {

                return false;

            }

        }

        public static async Task<List<Chave_Pix>> GetList()
        {

            return await Data_Service_Chave_Pix.GetListAsyncChavePix();

        }

        public static async Task<List<Chave_Pix>> Search(string parametro)
        {

            return await Data_Service_Chave_Pix.SearchAsyncChavePix(parametro);

        }

    }

}