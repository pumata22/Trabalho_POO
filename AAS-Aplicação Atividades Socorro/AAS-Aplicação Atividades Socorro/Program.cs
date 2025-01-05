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
        private string nome;
        private string moradaPessoa;
        private string veiculos;
        private string observacoes;
        private string dataNascimento;
        private string sexo;
        private string moradaQuartel;
        private string areaAtuacao;
        private string tipoForca;
        private string moradaBase;
        private string sigla;
        private string categoria;
        private int lugares;
        private int data;
        private int idade;
        private int nVitimas;
        private int nCodu = 0;
        private int identificadorTipoEmergencia;
        private int nVeiculos;
        private int coordenadas1, coordenadas2;
        private int nOperacionais;
        private int contacto;
        private int idQuartel;
        private int IdBasePC;//id  base protecao civil
        private int qtdMedicos;
        private int qtdEnfermeiros;
        private double horaAlerta, horaFecho;
        private double areaArdida;
        #endregion

        List<Ocorrencia> ocorrenciaList = new List<Ocorrencia>();

        public void EmergenciaMedica() {

            char escolhaSexo;
            Console.WriteLine("Emergência Médica");

            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Idade aproximada?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo(M/F)");
            escolhaSexo = char.Parse(Console.ReadLine());
            if (escolhaSexo == 'M')
            {
                sexo = "Masculino";
            }
            else sexo = "Feminino";

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Pessoa pessoa = new Pessoa(nome, idade, dataNascimento, sexo, moradaPessoa);

            Ocorrencia medica = new Ocorrencia(morada, veiculos, observacoes,
                nVitimas, idade, nCodu, identificadorTipoEmergencia, nOperacionais, pessoa);
            ocorrenciaList.Add(medica);
            MENU();
        }
        public void Acidente()
        {

            Console.WriteLine("Acidente");

            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome, idade, dataNascimento, sexo, moradaPessoa);
            Ocorrencia acidente = new Ocorrencia(morada, veiculos, observacoes,
          nVitimas, nCodu, identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais,
          pessoa1);
            ocorrenciaList.Add(acidente);
            MENU();
        }
        public void IncendioUrbano()
        {
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Console.WriteLine("Incêndio Urbano");
            Ocorrencia urbano = new Ocorrencia(morada, veiculos, observacoes,
                  nVitimas, identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais);
            ocorrenciaList.Add(urbano);
            MENU();
        }
        public void IncendioFlorestal()
        {
            Console.WriteLine("Incêndio Florestal");

            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Ocorrencia florestal = new Ocorrencia(morada, veiculos, observacoes,
                identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais, areaArdida);
            ocorrenciaList.Add(florestal);
            MENU();
        }
        public void IncendioIndustrial()
        {
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Console.WriteLine("Incêndio Industrial");
            Ocorrencia industrial = new Ocorrencia(morada, veiculos, observacoes,
                 nVitimas, identificadorTipoEmergencia, coordenadas1, coordenadas2, nOperacionais);
            ocorrenciaList.Add(industrial);
            MENU();
        }
        public void Assalto()
        {
            Console.WriteLine("Assalto");
            Ocorrencia assalto = new Ocorrencia(morada, veiculos, observacoes, identificadorTipoEmergencia,
                nOperacionais, coordenadas1, coordenadas2);
            ocorrenciaList.Add(assalto);
            MENU();
        }
        public void Agressao()
        {

            char escolhaSexoA;

            Console.WriteLine("Agressão");
            Console.WriteLine("Emergência Médica");

            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Idade aproximada?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sexo(M/F)");
            escolhaSexoA = char.Parse(Console.ReadLine());
            if (escolhaSexoA == 'M')
            {
                sexo = "Masculino";
            }
            else sexo = "Feminino";

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Pessoa pessoa7 = new Pessoa(nome, idade, dataNascimento, sexo, moradaPessoa);
            Ocorrencia agressao = new Ocorrencia(morada, veiculos, observacoes,
               nVitimas, idade, nCodu, identificadorTipoEmergencia, nOperacionais, pessoa7);
            ocorrenciaList.Add(agressao);
            MENU();
        }
        public void MENU()
        {
            string escolha;
            Console.WriteLine("Qual o tipo da ocorrência?");
            Console.WriteLine("Numero de ocorrencias:{0}",ocorrenciaList.Count );
            Console.WriteLine("1-Emergência Médica");
            Console.WriteLine("2-Acidente");
            Console.WriteLine("3-Incêndio Urbano");
            Console.WriteLine("4-Incêndio Florestal");
            Console.WriteLine("5-Incêndio Industrial");
            Console.WriteLine("6-Assalto");
            Console.WriteLine("7-Agressão");
            Console.WriteLine();
            escolha = Console.ReadLine();

            switch (escolha)
            {
                
                case "1":

                    EmergenciaMedica();
                    break;

                case "2":
                    Acidente();
                    break;

                case "3":
                   IncendioUrbano();
                    break;

                case "4":
                    IncendioFlorestal();
                    break;

                case "5":
                    IncendioIndustrial();
                    break;

                case "6":
                    Assalto();
                    break;

                case "7":
                    Agressao();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

        }

        public List<Ocorrencia> AddOcorrencias()
        {
            MENU();
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

        static void Main()
        {
            Program p = new Program();
            p.AddOcorrencias();
        }
    }
}
