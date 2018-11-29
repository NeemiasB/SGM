using System;
using System.Collections.Generic;
using System.Text;

namespace SGM.ApplicationCore.Entity
{
    public class Marca
    {
        public int MarcaId { get; set; }

        public string descrição { get; set; }

        public List<Veiculo> Veiculo { get; set; }
    }
}
