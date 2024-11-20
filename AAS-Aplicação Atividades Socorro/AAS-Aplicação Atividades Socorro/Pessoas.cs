// Ignore Spelling: AAS Pessoas

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Pessoas
    {
        #region Atributos
        private int nOperacional;
        private string nome;
        private int idade;
        private int moradaPessoa;
        #endregion

        #region construtores
        public Pessoas()
        {
        }

        public Pessoas(int nOperacionalPar, string nomePar, int idadePar, int moradaPessoaPar)
        {
            this.nOperacional = nOperacionalPar;
            this.nome = nomePar;
            this.idade = idadePar;
            this.moradaPessoa = moradaPessoaPar;
        }

        #endregion

        #region destrutor
        ~Pessoas()
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
        public int MoradaPessoa
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

        #endregion
    }
}