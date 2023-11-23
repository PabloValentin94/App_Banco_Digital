using System;
using System.Collections.Generic;
using System.Text;

namespace App_Banco_Digital.Model
{

    public class Transacao_Contas_Assoc
    {

        public int fk_transacao { get; set; }

        public int fk_remetente { get; set; }

        public int fk_destinatario { get; set; }

    }

}