using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Trabalho
{
    public class ExcBombeiros:Exception
    {
        public ExcBombeiros() { }

        public ExcBombeiros(int id_quartel, int contato) : base($"O id do quartel {id_quartel} ou o contato{contato} sao invalidos!") { 

        }
        
    }
    
}
