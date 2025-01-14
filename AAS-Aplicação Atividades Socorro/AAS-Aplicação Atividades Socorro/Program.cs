using System;
using System.Collections.Generic;
using System.IO;
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
        private string tipoForca;
        private string moradaBase;
        private string sigla;
        private string categoria;
        private int lugares;
        private int data;
        private int idade;
        private int nVitimas;
        private int nOcorrencia = 0;
        private int identificadorTipoEmergencia;
        private int nVeiculos;
        private int coordenadas1, coordenadas2;
        private int nOperacionais;
        private int contacto;
        private int idQuartel;
        private int qtdMedicos;
        private int qtdEnfermeiros;
        private int qtdMeios;
        private double horaAlerta, horaFecho;
        private double areaArdida;
        #endregion

        List<Ocorrencia> ocorrenciaList = new List<Ocorrencia>();

        List<Bombeiros> bombeirosList = new List<Bombeiros>();
        List<ForcasArmadas> forcasList = new List<ForcasArmadas>();
        List<Inem> inemList = new List<Inem>();
        List<ProtecaoCivil> pcList = new List<ProtecaoCivil>();
        public List<Bombeiros> AddBombeiros()
        {
            Bombeiros bombeiros = new Bombeiros(0316, "Avenida Carlos Bacelar 106, V.N.Famalicao", 252330200, "B.V.Famalicenses");
            Bombeiros bombeiros1 = new Bombeiros(0308, "Av. Rebelo Mesquita 136, V.N.Famalicao", 252301112, "B.V.Famalicao");
            Bombeiros bombeiros2 = new Bombeiros(0319, "Avenida Cidade Abreu e Lima, Riba de Ave,", 252900200, "B.V.Riba de Ave");
            bombeirosList.Add(bombeiros);
            bombeirosList.Add(bombeiros1);
            bombeirosList.Add(bombeiros2);
            return bombeirosList;
        }
        public List<ForcasArmadas> AddForcas()
        {
            ForcasArmadas forcasArmadas = new ForcasArmadas("PSP Famalicao", "R.António Sérgio, V.N.Famalicao");
            ForcasArmadas forcasArmadas1 = new ForcasArmadas("PSP Barcelos", "Av. Dr. Sidónio Pais 537, Barcelos");
            ForcasArmadas forcasArmadas2 = new ForcasArmadas("GNR Famalicao", " R. Vieira da Silva 116, V.N.Famalicão");
            forcasList.Add(forcasArmadas);
            forcasList.Add(forcasArmadas1);
            forcasList.Add(forcasArmadas2);
            return forcasList;
        }
        public List<Inem> AddInem()
        {
            Inem inem = new Inem(1, 1, 1, "Famalicao");
            Inem inem1 = new Inem(1, 1, 1, "Barcelos");
            Inem inem2 = new Inem(1, 1, 1, "Braga");
            inemList.Add(inem);
            inemList.Add(inem1);
            inemList.Add(inem2);
            return inemList;
        }
        public List<ProtecaoCivil> AddPC()
        {
            ProtecaoCivil pCivil = new ProtecaoCivil("Protecao Civil Braga", "Braga");
            ProtecaoCivil pCivil1 = new ProtecaoCivil("Protecao Civil Famalicao", "Famalicao");
            ProtecaoCivil pCivil2 = new ProtecaoCivil("Protecao Civil Barcelos", "Barcelos");
            pcList.Add(pCivil);
            pcList.Add(pCivil1);
            pcList.Add(pCivil2);
            return pcList;
        }

        public void EmergenciaMedica()
        {

            char escolhaSexo;
            Console.WriteLine("Emergência Médica");
            nVitimas = 1;
            nOcorrencia++;
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

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
                nVitimas, idade, nOcorrencia, 1, nOperacionais, pessoa);
            ocorrenciaList.Add(medica);
            Console.Clear();
            MENU();
        }
        public void Acidente()
        {

            Console.WriteLine("Acidente");
            nOcorrencia++;
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Pessoa pessoa1 = new Pessoa(nome, idade, dataNascimento, sexo, moradaPessoa);
            Ocorrencia acidente = new Ocorrencia(morada, veiculos, observacoes,
          nVitimas, nOcorrencia, 2, coordenadas1, coordenadas2, nOperacionais,
          pessoa1);
            ocorrenciaList.Add(acidente);
            Console.Clear();
            MENU();
        }
        public void IncendioUrbano()
        {
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();
            nOcorrencia++;
            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Console.WriteLine("Incêndio Urbano");
            Ocorrencia urbano = new Ocorrencia(morada, veiculos, observacoes, nOcorrencia,
            nVitimas, 3, coordenadas1, coordenadas2, nOperacionais);
            ocorrenciaList.Add(urbano);
            Console.Clear();
            MENU();
        }
        public void IncendioFlorestal()
        {
            Console.WriteLine("Incêndio Florestal");
            nOcorrencia++;
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Ocorrencia florestal = new Ocorrencia(morada, veiculos, observacoes, nOcorrencia,
                4, coordenadas1, coordenadas2, nOperacionais, areaArdida);
            ocorrenciaList.Add(florestal);
            Console.Clear();
            MENU();
        }
        public void IncendioIndustrial()
        {
            Console.WriteLine("Incêndio Industrial");
            nOcorrencia++;

            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();

            Console.WriteLine("Quantas vitimas?");
            nVitimas = int.Parse(Console.ReadLine());

            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Ocorrencia industrial = new Ocorrencia(morada, veiculos, observacoes, nOcorrencia,
                 nVitimas, 5, coordenadas1, coordenadas2, nOperacionais);
            ocorrenciaList.Add(industrial);
            Console.Clear();
            MENU();
        }
        public void Assalto()
        {
            Console.WriteLine("Assalto");
            nOcorrencia++;
            Console.WriteLine("Qual o local?");
            morada = Console.ReadLine();
            Console.WriteLine("Observacoes");
            observacoes = Console.ReadLine();

            Ocorrencia assalto = new Ocorrencia(morada, veiculos, observacoes, 6, nOcorrencia,
                nOperacionais, coordenadas1, coordenadas2);
            ocorrenciaList.Add(assalto);
            Console.Clear();
            MENU();
        }
        public void Agressao()
        {

            char escolhaSexoA;
            nOcorrencia++;
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
            Ocorrencia agressao = new Ocorrencia(morada, veiculos, observacoes, nOcorrencia,
               nVitimas, idade, nOcorrencia, 7, nOperacionais, pessoa7);
            ocorrenciaList.Add(agressao);
            Console.Clear();
            MENU();
        }
        public void ExibirOcorrenciasPorTipo(int tipo_ocorrencia)
        {
            var OTalTipoDeOcorrencia = ocorrenciaList.Where(t => t.IdentificadorTipoEmergencia == tipo_ocorrencia).ToList();


            if (OTalTipoDeOcorrencia.Any())
        {
            Console.WriteLine($"Ocorrências para o tipo {tipo_ocorrencia}:");

            foreach (var ocorrencia in OTalTipoDeOcorrencia)
            {
                Console.WriteLine(ocorrencia.ToString());
            }
        }
            else
            {
                Console.WriteLine($"Nenhuma ocorrência encontrada para o tipo {tipo_ocorrencia}.");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            MENU();
        }
         public void MENU()
        {
            string escolha;
            Console.WriteLine("Qual o tipo da ocorrência?");
            Console.WriteLine("Numero de ocorrencias:{0}", ocorrenciaList.Count);
            Console.WriteLine("1-Emergência Médica");
            Console.WriteLine("2-Acidente");
            Console.WriteLine("3-Incêndio Urbano");
            Console.WriteLine("4-Incêndio Florestal");
            Console.WriteLine("5-Incêndio Industrial");
            Console.WriteLine("6-Assalto");
            Console.WriteLine("7-Agressão");
            Console.WriteLine("8-Ocorrencias Ativas");
            Console.WriteLine("9-Saber se existe um certo tipo de ocorrencias:");
            Console.WriteLine();
            escolha = Console.ReadLine();
            Console.Clear();
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
                case "8":
                    MostrarOcorrenciasAtivas();
                    break;
                case "9":

                    Console.WriteLine("Escolha um tipo de ocorrencia:\n" +
                        "1-Emergência Médica\n" +
                        "2-Acidente\n" +
                        "3-Incêndio Urbano\n" +
                        "4-Incêndio Florestal\n" +
                        "5-Incêndio Industrial\n" +
                        "6-Assalto\n" +
                        "7-Agressão\n");

                        int tipo_de_Ocorrencia= Convert.ToInt32(Console.ReadLine());
                        ExibirOcorrenciasPorTipo(tipo_de_Ocorrencia);
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    Console.Clear();
                    MENU();
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
