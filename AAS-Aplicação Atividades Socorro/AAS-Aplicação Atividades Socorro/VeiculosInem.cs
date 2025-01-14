using AAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS_Aplicação_Atividades_Socorro
{
    public class VeiculosInem: AbstrataVeiculos
    {
            public VeiculosInem(string sigla, int quantidade) : base(sigla, quantidade) {}

            public override string ToString()
            {
                return $"Veículo INEM - Tipo: {Sigla}, Quantidade: {Quantidade}";
            }
    }
}
