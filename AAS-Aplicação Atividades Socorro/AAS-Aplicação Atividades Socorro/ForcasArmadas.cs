// Ignore Spelling: AAS Forças

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class ForcasArmadas
    {
        #region Atributos

        private string tipoForca;
        private string moradaBase;//base ou esquadra da policia por exemplo
        private string areaAtuacao;

        Veiculos veiculo = new Veiculos();

        #endregion

        #region Construtores
        public ForcasArmadas()
        {
        }

        public ForcasArmadas(string TipoForca, string moradaBase, string areaAtuacao)
        {
        
        }

        #endregion

        #region Destrutor
        ~ForcasArmadas() 
        {
        }
        #endregion

        #region Encapsulamento
        public string TipoForca 
        {
            get 
            {
                return this.tipoForca;
            }
            set 
            {
            this.tipoForca = value;
            }
        }
        public string MoradaBase
        {
            get
            {
                return this.moradaBase;
            }
            set 
            {
                this.moradaBase = value;
            }
        }
        public string AreaAtuacao 
        {
            get 
            {
            return this.areaAtuacao;
            }
            set 
            {
            this.areaAtuacao = value;
            }
        }
        #endregion
    }
}
 