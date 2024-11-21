// Ignore Spelling: AAS Veiculos

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS
{
    public class Veiculos : AbstrataVeiculos,IVeiculos
    {
        #region Atributos
        private string sigla; // ligeiro, pesado 
        private string categoria;//florestal,urbano,aereo,maritimos
        private int lugares;
        #endregion

        #region Construtores
        public Veiculos()
        {
        }

        public Veiculos(string siglaPar, string categoriaPar, int lugaresPar)
        {
            this.sigla = siglaPar;
            this.categoria = categoriaPar;
            this.lugares = lugaresPar;
        }

        #endregion

        #region Destrutor
        ~Veiculos()
        {
        }

        #endregion

        #region Encapsulamento

        public string Sigla1
        {
            get
            {
                return this.sigla;
            }
            set
            {
                this.sigla = value;
            }
        }
        public string Categoria
        {
            get
            {
                return this.categoria;
            }
            set
            {
                this.categoria = value;
            }
        }
        public int Lugares
        {
            get
            {
                return this.lugares;
            }
            set
            {
                this.lugares = value;
            }
        }
        #endregion

        public override void Transporte()
        {
            //Implementaçao
        }
        public override void Sigla()
        {
            //Implementaçao
        }
        public void TipoVeiculos()
        {

        }
    }
}
