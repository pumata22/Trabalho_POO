// Ignore Spelling: Transporte Sigla

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public abstract class AbstrataVeiculos
    {
        public string Sigla { get; set; }
        public int Quantidade { get; set; }

        public AbstrataVeiculos(string sigla, int quantidade)
        {
            Sigla = sigla;
            Quantidade = quantidade;
        }

        // Método abstrato implementado pelas subclasses
        public abstract string ToString();

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Sigla: {Sigla}, Quantidade: {Quantidade}");
        }
    }
}
