using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{

    public class Transacao
    {

        public int id {  get; set; }

        public string data_transacao { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        public double valor { get; set; }

    }

}
