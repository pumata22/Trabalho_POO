using AAS_Aplicação_Atividades_Socorro;
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
        private int qtdVeiculosBomb=10;
        private int qtdVeiculosInem=10;
        private int qtdVeiculosFA=10;
        private int qtdVeiculosPC=10;
        #endregion

         public Program() {
             this.arquivoNome = "Lista_Ocorrencias.txt";
             this.msgErro = true;
         }
        
         public bool Gravar(Ocorrencia ocorrencia)
         {
             try
             {
                 StreamWriter sw = new StreamWriter(this.arquivoNome, true);
                 sw.WriteLine(string.Format("Dados:"));
                 sw.Close();
                 return true;
        
             }
             catch (Exception ex)
             {
        
                 if (msgErro)
                 {
        
                     Console.WriteLine(ex.Message);
                 }
        
                 return false;
        
             }
         }
        
         public List<string> RetornarValores()
         {
             try
             {
                 StreamReader sr = new StreamReader(this.arquivoNome);
                 List<string> ocorrencias = new List<string>();
                 while (!sr.EndOfStream)
                 {
                     ocorrencias.Add(sr.ReadLine());
        
                 }
        
                 sr.Close();
                 return ocorrencias;
             }
             catch(Exception ex) 
             {
                 if (msgErro)
                 {
                     Console.WriteLine(ex.Message);
                 }
                 return null;
             }
         }
        
        
        
         #region exceptions
         private static void ValidarBombeiros(int id_quartel, int contato)
         {
             if (id_quartel<0&&contato<0)throw new ExcBombeiros(id_quartel,contato);
         }
        
         private static void ValidarInem(int qtdMedicos, int qtdEnfermeiros, int qtdMeios)
         {
             if (qtdMedicos < 0 && qtdEnfermeiros < 0 && qtdMeios <0 ) throw new ExcInem( qtdMedicos,qtdEnfermeiros,qtdMeios);
         }
        
         private static void ValidarOcorrenciaMedicaAgressao(int nVitimas, int idade)
         {
             if (nVitimas < 0 && idade < 0) throw new ExcOcorrencia(nVitimas, idade);
         }
        
         private static void ValidarOcorrenciaAcidente(int nVitimas)
         {
             if (nVitimas < 0 ) throw new ExcOcorrencia(nVitimas);
         }
         private static void ValidarOcorrenciaIncendios(int nVitimas)
         {
             if (nVitimas < 0) throw new ExcOcorrencia(nVitimas);
         }
        
         #endregion

             
        #region Instanciar Listas
        List<Ocorrencia> ocorrenciaList = new List<Ocorrencia>();
        List<AbstrataVeiculos> veiculosList = new List<AbstrataVeiculos>();

        List<Bombeiros> bombeirosList = new List<Bombeiros>();
        List<ForcasArmadas> forcasList = new List<ForcasArmadas>();
        List<Inem> inemList = new List<Inem>();
        List<ProtecaoCivil> pcList = new List<ProtecaoCivil>();


        List<VeiculoFA> veiculosFAList = new List<VeiculoFA>();
        List<VeiculoPC> veiculosPCList = new List<VeiculoPC>();
        List<VeiculosInem> veiculosInemList = new List<VeiculosInem>();
        List<VeiculosBombeiros> veiculosBombList = new List<VeiculosBombeiros>();
        #endregion

        #region Preenchimento Listas
        public List<Bombeiros> AddBombeiros()
        {
            Bombeiros bombeiros = new Bombeiros(0316, "Avenida Carlos Bacelar 106, V.N.Famalicao", 252330200, "B.V.Famalicenses");
            Bombeiros bombeiros1 = new Bombeiros(0308, "Av. Rebelo Mesquita 136, V.N.Famalicao", 252301112, "B.V.Famalicao");
            Bombeiros bombeiros2 = new Bombeiros(0319, "Avenida Cidade Abreu e Lima, Riba de Ave,", 252900200, "B.V.Riba de Ave");

            try{
                ValidarBombeiros(bombeiros.IdQuartel,bombeiros.Contacto);
                ValidarBombeiros(bombeiros1.IdQuartel, bombeiros2.Contacto);
                ValidarBombeiros(bombeiros2.IdQuartel, bombeiros2.Contacto);
            }
            catch (ExcBombeiros e){
                Console.WriteLine(e.Message);
            }
            
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
            
             try{
                 ValidarInem(inem.QtdMedicos, inem.QtdEnfermeiros, inem.QtdMeios);
                 ValidarInem(inem1.QtdMedicos, inem1.QtdEnfermeiros, inem1.QtdMeios);
                 ValidarInem(inem2.QtdMedicos, inem2.QtdEnfermeiros, inem2.QtdMeios);
             }
             catch(ExcInem e){
                 Console.WriteLine(e.Message);
             }
            
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

        public List<VeiculoFA> AddVeiculoFA() 
        {
            VeiculoFA veiculoFA = new VeiculoFA("patrulha", qtdVeiculosFA);
            veiculosFAList.Add(veiculoFA);
            return veiculosFAList;
        }
        public List<VeiculosBombeiros> AddVeiculoB() 
        {
            VeiculosBombeiros veiculoB0 = new VeiculosBombeiros("VFCI", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB1 = new VeiculosBombeiros("VSAE", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB2 = new VeiculosBombeiros("VUCI", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB3 = new VeiculosBombeiros("ABSC", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB4 = new VeiculosBombeiros("VLCI", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB5 = new VeiculosBombeiros("VTTU", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB6 = new VeiculosBombeiros("VALE", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB7 = new VeiculosBombeiros("VTTP", qtdVeiculosBomb);
            VeiculosBombeiros veiculoB8 = new VeiculosBombeiros("VCOT", qtdVeiculosBomb);
            veiculosBombList.Add(veiculoB0);
            veiculosBombList.Add(veiculoB1);
            veiculosBombList.Add(veiculoB2);
            veiculosBombList.Add(veiculoB3);
            veiculosBombList.Add(veiculoB4);
            veiculosBombList.Add(veiculoB5);
            veiculosBombList.Add(veiculoB6);
            veiculosBombList.Add(veiculoB7);
            veiculosBombList.Add(veiculoB8);
            return veiculosBombList;
        }
        public List<VeiculoPC> AddVeiculoPC() 
        {
            VeiculoPC veiculoPC0 = new VeiculoPC("Florestal", qtdVeiculosPC);
            VeiculoPC veiculoPC1 = new VeiculoPC("Animal", qtdVeiculosPC);
            veiculosPCList.Add(veiculoPC0);
            veiculosPCList.Add(veiculoPC1);
            return veiculosPCList;
        }
        public List<VeiculosInem> AddVeiculoInem()
        {
            VeiculosInem veiculoINEM0 = new VeiculosInem("SIV", qtdVeiculosInem);
            VeiculosInem veiculoINEM1 = new VeiculosInem("VMER", qtdVeiculosInem);
            VeiculosInem veiculoINEM2 = new VeiculosInem("UMIP", qtdVeiculosInem);
            veiculosInemList.Add(veiculoINEM0);
            veiculosInemList.Add(veiculoINEM1);
            veiculosInemList.Add(veiculoINEM2);
            return veiculosInemList;
        }
        #endregion

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
             try
             {
                 ValidarOcorrenciaMedicaAgressao(medica.NVitimas, medica.Idade);
                
             }
             catch (ExcOcorrencia e)
             {
                 Console.WriteLine(e.Message);
             }

            
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

            try
            {
                ValidarOcorrenciaAcidente(acidente.NVitimas);
            }
            catch (ExcOcorrencia e)
            {
                Console.WriteLine(e.Message);
            }
            
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
            try
            {
                ValidarOcorrenciaIncendios(urbano.NVitimas);
            
            }
            catch (ExcOcorrencia e)
            {
                Console.WriteLine(e.Message);
            }
            
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

             try
             {
                 ValidarOcorrenciaIncendios(industrial.NVitimas);
            
             }
             catch (ExcOcorrencia e)
             {
                 Console.WriteLine(e.Message);
             }
            
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

             try
             {
                 ValidarOcorrenciaMedicaAgressao(agressao.NVitimas, agressao.Idade);
            
             }
             catch (ExcOcorrencia e)
             {
                 Console.WriteLine(e.Message);
             }
            
            ocorrenciaList.Add(agressao);
            Console.Clear();
            MENU();
        }
        
        public void MostrarOcorrenciasAtivas()
        {
            Console.WriteLine("\nOcorrências Ativas");
            if (ocorrenciaList.Count == 0)
            {
                Console.WriteLine("Nenhuma ocorrência ativa no momento.");
                MENU();
            }

            foreach (var ocorrencia in ocorrenciaList)
            {
                Console.WriteLine(ocorrencia.ToString());
                Console.WriteLine("------------------------------------");
            }

            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
            Console.Clear();
            MENU();
        }

        public void ExibirOcorrenciasPorTipo(int tipo_ocorrencia)
        {
            var OTalTipoDe_Ocorrencia = ocorrenciaList.Where(t => t.IdentificadorTipoEmergencia == tipo_ocorrencia).ToList();


            if (OTalTipoDe_Ocorrencia.Any())
            {
                Console.WriteLine($"Ocorrências para o tipo {tipo_ocorrencia}:");

                foreach (var ocorrencia in OTalTipoDe_Ocorrencia)
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
