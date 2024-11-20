// Ignore Spelling: AAS Bombeiros

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Bombeiros : Pessoas
    {
        #region Atributos
        public int idQuartel;
        public string moradaQuartel;
        public int numeroIdBombeiro;
        public string categoriaBombeiro;
        public double horasAlerta, horasDisponivel;
        public int kmsSaida, kmsChegada;
        public string areaAtuacao;

        Veiculos veiculo = new Veiculos();
        #endregion
    }
}
