using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.ApplicationCore.Entity
{
    public class Multa
    {
        public int MultaId { get; set; }

        public int Valor { get; set; }

        public int Pontuação { get; set; }
        //Propriedade de Navegação

        public Veiculo Veiculos { get; set; }

    }
}
