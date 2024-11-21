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
        #endregion

        #region Construtores 
        public Inem() 
        {
        }

        public Inem(int qtdMedicos, int qtdEnfermeiros)
        { 
        this.qtdMedicos = qtdMedicos;
        this.qtdEnfermeiros = qtdEnfermeiros;
        }
        #endregion

        #region Destrutor
        ~Inem()
        {
        }
        #endregion

        #region Encapsulamento
        public int QtdMedicos 
        {
            get 
            {
            return this.qtdMedicos;
            }
            set 
            {
            this.qtdMedicos= value;
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
            this.qtdEnfermeiros= value;
            }
        }
        #endregion
    }
}
