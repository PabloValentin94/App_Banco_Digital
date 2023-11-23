using System;
using System.Collections.Generic;
using System.Text;

using System.Threading.Tasks;

using App_Banco_Digital.Model;
using App_Banco_Digital.Service;

namespace App_Banco_Digital.Model
{

    public class Transacao
    {

        public int id {  get; set; }

        public string data_transacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public double valor { get; set; }

        /*public async Task<bool> Save()
        {

            Model.Transacao transacao_retornada = await Data_Service_Transacao.

        }*/

    }

}