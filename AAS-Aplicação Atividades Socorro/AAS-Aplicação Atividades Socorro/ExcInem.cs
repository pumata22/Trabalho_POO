using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Trabalho
{
    public class ExcInem:Exception
    { 
        public ExcInem() { }

        public ExcInem(int qtdMedicos, int qtdEnfermeiros, int qtdMeios) : base($"A quantidade de medicos{qtdMedicos} ou a quantidade de Enfermeiros{qtdEnfermeiros} ou a quantidade de Meios {qtdMeios} e invalida!") { 
            
        }
    
    }
}
