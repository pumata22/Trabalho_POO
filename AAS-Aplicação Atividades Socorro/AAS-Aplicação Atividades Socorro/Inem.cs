// Ignore Spelling: AAS Inem

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Inem
    {
        #region Atributos
        private int qtdMedicos;
        private int qtdEnfermeiros;
        private int qtdMeios;
        private string posicionamento;
        #endregion

        #region Construtores 
        public Inem() 
        {
        }

        public Inem(int qtdMedicos, int qtdEnfermeiros,int qtdMeios, string posicionamento)
        {
            this.posicionamento = posicionamento;
        }
        #endregion

        #region Destrutor
        ~Inem()
        {
        }
        #endregion

        #region Encapsulamento
        public string Posicionamento
        {
            get
            {
                return this.posicionamento;
            }
            set
            {
                this.posicionamento = value;
            }
        }
        public int QtdMeios
        {
            get
            {
                return this.qtdMeios;
            }
            set
            {
                this.qtdMeios = value;
            }
        }
        public int QtdMedicos
        {
            get
            {
                return this.qtdMedicos;
            }
            set
            {
                this.qtdMedicos = value;
            }
        }
        public int QtdEnfermeiros
        {
            get
            {
                return this.qtdEnfermeiros;
            }
            set
            {
                this.qtdEnfermeiros = value;
            }
        }


        #endregion
    }
}
