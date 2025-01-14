using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Trabalho
{
    public  class ExcOcorrencia:Exception
    {
        public ExcOcorrencia() { }


        //emergencias medicas e agressao
        public ExcOcorrencia(int nVitimas, int idade) :base($"O nº de Vitimas{nVitimas} ou a idade{idade} nao é valida!")
        {
        }

        //Incendios e Acidente
        public ExcOcorrencia(int nVitimas) : base($"O nº de Vitimas{nVitimas} e invalida!")
        { 
        }



    }
}
