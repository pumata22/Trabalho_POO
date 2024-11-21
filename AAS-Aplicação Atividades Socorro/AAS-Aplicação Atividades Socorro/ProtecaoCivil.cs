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
        private int IdBasePC;//id  base protecao civil
        private string moradaBase;
        private string area;
        Veiculos veiculo = new Veiculos();

        #endregion 

        #region Construtores
        public ProtecaoCivil()
        {

        }

        public ProtecaoCivil(int IdBasePC_par, string moradaBase_par, string area_par, Veiculos veiculo_par)
        {

            this.IdBasePC = IdBasePC_par;
            this.moradaBase = moradaBase_par;
            this.area = area_par;
            this.veiculo = veiculo_par;
        }

        #endregion

        #region Destrutor
        ~ProtecaoCivil()
        {
        }

        #endregion

        #region Encapsulamento
        public int IDBasePC
        {

            get
            {
                return this.IdBasePC;
            }
            set
            {
                this.IdBasePC = value;
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
