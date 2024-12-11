// Ignore Spelling: AAS Ocorrencias Ocorrencia

using AAS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Ocorrencia
    {
        #region Atributos
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
        Pessoa pessoa = new Pessoa();
        #endregion

        #region Construtores
        //construtor geral
        public Ocorrencia()
        {
        }

        //Construtor emergencias medicas e agressao
        public Ocorrencia(string morada, string veiculos, string observacoes,
                          int nVitimas, int idade, int nCodu, int identificadorTipoEmergencia, int nOperacionais, Pessoa pessoa)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.nVitimas = nVitimas;
            this.idade = idade;
            this.nCodu = nCodu;
            this.identificadorTipoEmergencia = identificadorTipoEmergencia;
            this.pessoa = pessoa;
        }

        //Construtor acidente
        public Ocorrencia(string morada, string veiculos, string observacoes,
                          int nVitimas, int nCodu, int identificadorTipoEmergencia, int coordenadas1, int coordenadas2, int nOperacionais,
                          Pessoa pessoa)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.nVitimas = nVitimas;
            this.nCodu = nCodu;
            this.identificadorTipoEmergencia = identificadorTipoEmergencia;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
            this.pessoa = pessoa;
        }

        //Construtor incendio urbano e industrial
        public Ocorrencia(string morada, string veiculos, string observacoes,
                         int nVitimas, int identificadorTipoEmergencia, int coordenadas1, int coordenadas2, int nOperacionais)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.nVitimas = nVitimas;
            this.identificadorTipoEmergencia = identificadorTipoEmergencia;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
        }

        //Construtor incendio florestal
        public Ocorrencia(string morada, string veiculos, string observacoes,
                         int identificadorTipoEmergencia, int coordenadas1, int coordenadas2, int nOperacionais, double areaArdida)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.identificadorTipoEmergencia = identificadorTipoEmergencia;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
            this.areaArdida = areaArdida;
        }

        //Construtor assalto
        public Ocorrencia(string morada, string veiculos, string observacoes, int identificadorTipoEmergencia, int nOperacionais,
                          int coordenadas1, int coordenadas2)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.identificadorTipoEmergencia = identificadorTipoEmergencia;
            this.nOperacionais = nOperacionais;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
        }
        #endregion

        #region Destrutor
        ~Ocorrencia()
        {
        }
        #endregion

        #region Encapsulamento
        public string Morada
        {
            get
            {
                return this.morada;
            }
            set
            {
                this.morada = value;
            }
        }

        public string Veiculos
        {
            get
            {
                return this.veiculos;
            }
            set
            {
                this.veiculos = value;
            }
        }

        public string Observacoes
        {
            get
            {
                return this.observacoes;
            }
            set
            {
                this.observacoes = value;
            }
        }

        public int Data
        {
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {
                this.idade = value;
            }
        }

        public int NVitimas
        {
            get
            {
                return this.nVitimas;
            }
            set
            {
                this.nVitimas = value;
            }
        }

        public int NCodu
        {
            get
            {
                return this.nCodu;
            }
            set
            {
                this.nCodu = value;
            }
        }

        public int IdentificadorTipoEmergencia
        {
            get
            {
                return this.identificadorTipoEmergencia;
            }
            set
            {
                this.identificadorTipoEmergencia = value;
            }
        }

        public int NVeiculos
        {
            get
            {
                return this.nVeiculos;
            }
            set
            {
                this.nVeiculos = value;
            }
        }

        public int Coordenadas1
        {
            get
            {
                return this.coordenadas1;
            }
            set
            {
                this.coordenadas1 = value;
            }
        }

        public int Coordenadas2
        {
            get
            {
                return this.coordenadas2;
            }
            set
            {
                this.coordenadas2 = value;
            }
        }

        public int NOperacionais
        {
            get
            {
                return this.nOperacionais;
            }
            set
            {
                this.nOperacionais = value;
            }
        }

        public double HoraAlerta
        {
            get 
            {
            return this.horaAlerta;
            }
            set 
            { 
            this.horaAlerta = value;
            }
        
        }

        public double HoraFecho
        {
            get
            {
                return this.horaFecho;
            }
            set
            {
                this.horaFecho = value;
            }
        }

        public double AreaArdida
        {
            get
            {
                return this.AreaArdida;
            }
            set
            {
                this.AreaArdida = value;
            }
        }
        #endregion

    }
}
