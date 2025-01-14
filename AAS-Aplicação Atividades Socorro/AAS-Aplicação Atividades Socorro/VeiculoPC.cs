// Ignore Spelling: AAS 
using AAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class VeiculoPC: AbstrataVeiculos
    {
        public VeiculoPC(string sigla, int quantidade) : base(sigla, quantidade) { }
        public override string ToString()
        {
            return $"Veículo Proteção Civil - Tipo: {Sigla}, Quantidade: {Quantidade}";
        }
    }
}
