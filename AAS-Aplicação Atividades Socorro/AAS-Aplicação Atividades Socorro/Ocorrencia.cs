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
        public string morada;
        public string veiculos;
        public string observacoes;
        public int data;
        public int idade;
        public int nVitimas; 
        public int nCodu;
        public int identificadorTipoEmergencia;
        public int nVeiculos;
        public int coordenadas1,coordenadas2;
        public int nOperacionais;
        public double horaAlerta,Horafecho;
        public double areaArdida;
        Pessoas pessoa = new Pessoas();
        #endregion

        #region Construtores
        //construtor geral
        public Ocorrencia() 
        {
        }

        //Construtor emergencias medicas e agressao
        public Ocorrencia(string morada, string veiculos, string observacoes, 
                          int nVitimas,int idade,int nCodu,int identifacadorTipoEmergencia,int nOperacionais,Pessoas pessoa) 
        {
        this.morada=morada;
        this.veiculos = veiculos;
        this.observacoes = observacoes;
        this.nVitimas=nVitimas;
        this.idade=idade;
        this.nCodu=nCodu;
        this.identificadorTipoEmergencia=identifacadorTipoEmergencia;
        this.pessoa=pessoa;
        }

        //Construtor acidente
        public Ocorrencia(string morada, string veiculos, string observacoes, 
                          int nVitimas,int nCodu, int identifacadorTipoEmergencia,int coordenadas1, int coordenadas2,int nOperacionais,
                          Pessoas pessoa)
        {
        this.morada = morada;
        this.veiculos = veiculos;
        this.observacoes=observacoes;
        this.nVitimas = nVitimas;
        this.nCodu = nCodu;
        this.identificadorTipoEmergencia = identifacadorTipoEmergencia;
        this.coordenadas1 = coordenadas1;
        this.coordenadas2 = coordenadas2;
        this.pessoa=pessoa;
        }

        //Construtor incendio urbano e industrial
        public Ocorrencia(string morada, string veiculos, string observacoes,
                         int nVitimas, int identifacadorTipoEmergencia, int coordenadas1, int coordenadas2,int nOperacionais)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.nVitimas = nVitimas;
            this.identificadorTipoEmergencia = identifacadorTipoEmergencia;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
        }

        //Construtor incendio florestal
        public Ocorrencia(string morada, string veiculos, string observacoes,
                         int identifacadorTipoEmergencia, int coordenadas1, int coordenadas2,int nOperacionais,double areaArdida)
        {
            this.morada = morada;
            this.veiculos = veiculos;
            this.observacoes = observacoes;
            this.identificadorTipoEmergencia = identifacadorTipoEmergencia;
            this.coordenadas1 = coordenadas1;
            this.coordenadas2 = coordenadas2;
            this.areaArdida = areaArdida;
        }

        //Construtor assalto
        public Ocorrencia(string morada, string veiculos,string observacoes, int identifacadorTipoEmergencia,int nOperacionais,
                          int coordenadas1,int coordenadas2) 
        {
        this.morada=morada;
        this.veiculos=veiculos;
        this.observacoes=observacoes;
        this.identificadorTipoEmergencia = identifacadorTipoEmergencia;
        this.nOperacionais=nOperacionais;
        this.coordenadas1=coordenadas1;
        this.coordenadas2=coordenadas2;
        }
        #endregion

        #region Destrutor
        ~Ocorrencia()
        {
        }
        #endregion

    }
}
