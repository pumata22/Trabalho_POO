// Ignore Spelling: AAS Proteção

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class ProtecaoCivil
    {
        #region Atributos
        private string nome;
        private string area;
        Veiculos veiculo = new Veiculos();

        #endregion 

        #region Construtores
        public ProtecaoCivil()
        {

        }

        public ProtecaoCivil(string nome_par, string area_par)
        {

            this.nome = nome_par;
            this.area = area_par;
        }

        #endregion

        #region Destrutor
        ~ProtecaoCivil()
        {
        }

        #endregion

        #region Encapsulamento
        public string Nome
        {

            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
            }
        }

        public string Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }


        #endregion

    }
}
