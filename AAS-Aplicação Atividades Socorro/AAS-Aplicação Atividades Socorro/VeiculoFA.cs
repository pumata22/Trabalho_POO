using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class VeiculoFA:AbstrataVeiculos
    {
        public VeiculoFA(string sigla, int quantidade) : base(sigla, quantidade) { }

        public override string ToString()
        {
            return $"Veículo Forças Armadas - Tipo: {Sigla}, Quantidade: {Quantidade}";
        }
    }
}
