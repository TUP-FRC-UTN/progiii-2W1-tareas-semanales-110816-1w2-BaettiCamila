using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Club2.Models
{
    public class Socio
    {
        private int id;
        [Required]
        private string nombre;
        [Required]
        private string apellido;
        [Required]
        private int idTipoDocumento;
        [Required]
        private string nroDocumento;
        [Required]
        private int idDeporte;


        public string pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string pApellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public int pIdTipoDocumento
        {
            set { idTipoDocumento = value; }
            get { return idTipoDocumento; }
        }
        public string pNroDocumento
        {
            set { nroDocumento = value; }
            get { return nroDocumento; }
        }
        public int pIdDeporte
        {
            set { idDeporte = value; }
            get { return idDeporte; }
        }
    }
}