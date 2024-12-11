// Ignore Spelling: AAS

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    class Program
    {
            #region Variáveis
            private string morada;
            private string veiculos;
            private string observacoes;
            private int data;
            private int idade;
            private int nVitimas;
            private int nCodu;
            private int identificadorTipoEmergencia;
            private int nVeiculos;
            private int coordenadas1, coordenadas2;
            private int nOperacionais;
            private double horaAlerta, horaFecho;
            private double areaArdida;
            #endregion

            List<Ocorrencia> ocorrenciaList = new List<Ocorrencia>();
            Pessoa pessoa = new Pessoa();

        public List<Ocorrencia> AddOcorrencias()
        {
            string escolha;
            Console.Write("Qual o tipo da ocorrência?");
            Console.WriteLine("1-Emergência Médica");
            Console.WriteLine("2-Acidente");
            Console.WriteLine("3-Incêndio Urbano");
            Console.WriteLine("4-Incêndio Florestal");
            Console.WriteLine("5-Incêndio Industrial");
            Console.WriteLine("6-Assalto");
            Console.WriteLine("7-Agressão");
            Console.WriteLine();
            escolha = Console.ReadLine(); // Lê como string
         
            switch (escolha)
            {
                case "1":
                    Console.WriteLine("Emergência Médica");
                    Ocorrencia medica = new Ocorrencia(morada, veiculos, observacoes,
                        nVitimas, idade, nCodu, identificadorTipoEmergencia, nOperacionais, pessoa);
                    ocorrenciaList.Add(medica);
                    break;
                case "2":
                    Console.WriteLine("Acidente");
                    Ocorrencia acidente = new Ocorrencia( morada,  veiculos,  observacoes,
                  nVitimas, nCodu,  identificadorTipoEmergencia,  coordenadas1,  coordenadas2,  nOperacionais,
                  pessoa);
                    ocorrenciaList.Add(acidente);
                    break;
                case "3":
                    Console.WriteLine("Incêndio Urbano");
                    Ocorrencia urbano = new Ocorrencia(morada, veiculos, observacoes,
                          nVitimas, identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais);
                    ocorrenciaList.Add(urbano);
                    break;
                case "4":
                    Console.WriteLine("Incêndio Florestal");
                    Ocorrencia florestal = new Ocorrencia(morada, veiculos, observacoes,
                        identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais, areaArdida);
                    ocorrenciaList.Add(florestal);
                        break;
                case "5":
                    Console.WriteLine("Incêndio Industrial");
                    Ocorrencia industrial = new Ocorrencia(morada, veiculos, observacoes,
                         nVitimas, identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais);
                    ocorrenciaList.Add(industrial);
                    break;
                case "6":
                    Console.WriteLine("Assalto");
                    Ocorrencia assalto = new Ocorrencia(morada, veiculos, observacoes, identificadorTipoEmergencia,
                        nOperacionais, coordenadas1, coordenadas2);
                    ocorrenciaList.Add(assalto);
                    break;
                case "7":
                    Console.WriteLine("Agressão");
                    Ocorrencia agressao = new Ocorrencia(morada, veiculos, observacoes,
                       nVitimas, idade, nCodu, identificadorTipoEmergencia, nOperacionais, pessoa);
                    ocorrenciaList.Add(agressao);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            return ocorrenciaList;
        }

        void setOcorrencias()
            {
                List<string> tipoOcorrencia = new List<string>
            {
                "Emergencia Medica",
                "Incendio Urbano",
                "Incendio Florestal",
                "Incendio Industrial",
                "Acidente",
                "Assalto",
                "Agressao"
            };
            }

            static void Main(string[] args)
            {
                Program p = new Program();
                p.AddOcorrencias();
            }
    }
}