using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{

    public class Conta
    {

        public int id_conta { get; set; }

        public double saldo { get; set; }

        public double limite { get; set; }

        public string tipo { get; set; }

        public int ativa { get; set; } = 1;

        public int fk_correntista { get; set; }

        public string data_abertura { get; set; } = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

    }

}