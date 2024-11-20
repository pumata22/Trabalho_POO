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
        public int qtdMedicos;
        public int qtdEnfermeiros;
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
    }
}
