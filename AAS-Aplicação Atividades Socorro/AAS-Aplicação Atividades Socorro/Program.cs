// Ignore Spelling: AAS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    internal class Program: Ocorrencia
    {
        static void Main()
        {
             void AddOcorrencias() 
            {
                int escolha=0;
                //Tipo de ocorrencia
                Console.Write("Qual o tipo da ocorrencia?");
                escolha = Console.Read();

                if (escolha == 1) //emergencia médica
                {

                }
                else if (escolha == 2) //acidente
                {
                
                }
                else if (escolha == 3) //incendio urbano
                {

                }
                else if (escolha == 4) //incendio florestal
                {

                }
                else if (escolha == 5) //incendio industrial
                {

                }
                else if (escolha == 6) //assalto
                { 

                }
                else if (escolha == 7) // agressao
                {

                }
            }
        }
    }
}
