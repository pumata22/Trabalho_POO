// Ignore Spelling: AAS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    internal class Program
    {
        static void Main()
        {
            List<Ocorrencia> ocorrenciaList = new List<Ocorrencia>();

            List<Ocorrencia> AddOcorrencias() 
            {
                int escolha=0;
                //Tipo de ocorrencia
                Console.Write("Qual o tipo da ocorrencia?");
                escolha = Console.Read();

                if (escolha == 1) //emergencia médica
                {
                    Console.WriteLine("Emergencia");
                }
                else if (escolha == 2) //acidente
                {
                    Console.WriteLine("acidente");

                }
                else if (escolha == 3) //incendio urbano
                {
                    Console.WriteLine("incendio urbano");

                }
                else if (escolha == 4) //incendio florestal
                {
                    Console.WriteLine("incendio florestal");
                }
                else if (escolha == 5) //incendio industrial
                {
                    Console.WriteLine("incendio industrial");

                }
                else if (escolha == 6) //assalto
                {
                    Console.WriteLine("assalto");
                }
                else if (escolha == 7) // agressao
                {
                    Console.WriteLine("agressao");                   
                }
                return ocorrenciaList;
            }

            AddOcorrencias();

            void setOcorrencias()
            {
                List<string> tipoOcorrencia = new List<string>();
                tipoOcorrencia.Add("Emergencia Medica");
                tipoOcorrencia.Add("Incendio Urbano");
                tipoOcorrencia.Add("Incedio Florestal");
                tipoOcorrencia.Add("Incendio Industrial");
                tipoOcorrencia.Add("Acidente");
                tipoOcorrencia.Add("Assalto");
                tipoOcorrencia.Add("Agressao");
            }
        }
    }
}
