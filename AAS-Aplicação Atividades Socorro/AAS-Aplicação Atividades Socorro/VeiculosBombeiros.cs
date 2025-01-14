// Ignore Spelling: AAS 
using AAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class VeiculosBombeiros : AbstrataVeiculos
    {
            public VeiculosBombeiros(string sigla, int quantidade) : base(sigla, quantidade) { }

            public override string ToString()
            {
                return $"Veículo Bombeiro - Tipo: {Sigla}, Quantidade: {Quantidade}";
            }
    }
}
