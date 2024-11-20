// Ignore Spelling: Transporte Sigla

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public abstract class AbstrataVeiculos
    {

        public abstract void Transporte();
        //public  void Mover();

        public virtual void Sigla()
        {
            Console.Write("\nOs veiculos tem uma sigla.");
        }
    }
}
