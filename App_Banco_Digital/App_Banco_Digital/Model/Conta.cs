using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{

    public class Conta
    {

        public int id_conta { get; set; }

        public int numero { get; set; }

        public string tipo { get; set; }

        public string senha_conta { get; set; }

        public bool ativa { get; set; } = true;

        public int fk_correntista { get; set; }

    }

}
