// Ignore Spelling: AAS Bombeiros

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Bombeiros : Pessoa
    {
        #region Atributos
        private string nomQuartel;
        private int idQuartel;
        private string moradaQuartel;
        private int contacto;

        Veiculos veiculo = new Veiculos();
        #endregion

        #region Construtores
        public Bombeiros()
        {

        }

        public Bombeiros(int idQuartel, string moradaQuartel, int contacto, string nomQuartel)
        {
            this.idQuartel = idQuartel;
            this.moradaQuartel = moradaQuartel;
            this.contacto = contacto;
        }
        #endregion

        #region Destrutor
        ~Bombeiros()
        {

        }
        #endregion

        #region Encapsulamento
        private int IdQuartel
        {
            get
            {
                return this.idQuartel;
            }
            set
            {
                this.idQuartel = value;
            }
        }
        private string MoradaQuartel
        {
            get
            {
                return this.moradaQuartel;
            }
            set
            {
                this.moradaQuartel = value;
            }
        }
        private int Contacto
        {
            get
            {
                return this.contacto;
            }
            set
            {
                this.contacto = value;
            }
        }

        private string NomQuartel 
        {
            get 
            {
                return this.nomQuartel; 
            }
            set
            { 
                this.nomQuartel = value;
            }
        
        }

        #endregion

    }
}
