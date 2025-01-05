// Ignore Spelling: AAS Pessoas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Pessoa
    {
        #region Atributos
        private int nOperacional;
        private string nome;
        private int idade;
        private string moradaPessoa;
        private string sexo;
        private string dataNascimento;
        #endregion

        #region Construtores
        public Pessoa()
        {
        }

        //operacionais
        public Pessoa(int nOperacionalPar, string nomePar, string sexo, int idadePar, string dataNascimento, string moradaPessoaPar)
        {
            this.nOperacional = nOperacionalPar;
            this.nome = nomePar;
            this.idade = idadePar;
            this.moradaPessoa = moradaPessoaPar;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
        }

        //civis
        public Pessoa(string nome, int idade,string dataNascimento, string sexo, string moradaPessoa) 
        {
        this.nome=nome;
        this.idade = idade;
        this.sexo = sexo;
        this.dataNascimento = dataNascimento;
        this.moradaPessoa=moradaPessoa;
        }
        #endregion

        #region destrutor
        ~Pessoa()
        {
        }

        #endregion

        #region Encapsulamento
        public int NOperacional
        {
            get
            {
                return this.nOperacional;
            }
            set
            {
                this.nOperacional = value;
            }
        }
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                this.nome = value;
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
        public string MoradaPessoa
        {
            get
            {
                return this.moradaPessoa;
            }
            set
            {
                this.moradaPessoa = value;
            }
        }
        public string Sexo
        {
            get 
            {
                return this.sexo;
            }
            set
            { 
            this.sexo = value;
            }
        }
        public string DataNascimento
        {
            get 
            {
                return this.dataNascimento;
            }
            set 
            { 
                this.dataNascimento = value;
            }
        }
        #endregion
    }
}