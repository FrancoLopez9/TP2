using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /// <summary>
    /// Clase que representa un Cliente
    /// </summary>
    class Cliente
    {
        //Atributos
        private string iNroDocumento;
        private string iNombre;
        private TipoDocumento iTipoDocumento;

        //Constructores
        /// <summary>
        /// Crea un Cliente
        /// </summary>
        /// <param name="pTipoDocumento"> Tipo de Documento del Cliente</param>
        /// <param name="pNroDocumento"> Numero de Documento del Cliente</param>
        /// <param name="pNombre"> Nombre del Cliente</param>
        public Cliente(TipoDocumento pTipoDocumento, string pNroDocumento, string pNombre)
        {
            this.iNroDocumento = pNroDocumento;
            this.iTipoDocumento = pTipoDocumento;
            this.iNombre = pNombre;
        }

        //Propiedades
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }
        public string NroDocumento
        {
            get { return this.iNroDocumento; }
        }
        public string Nombre
        {
            get { return this.iNombre; }
        }       
    }
}
