using SGM.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.ApplicationCore
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }

        public string Placa { get; set; }

        public string Renavam { get; set; }

       public Marca Marcas { get; set; }
       
    }
}
