using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada2015.Entidades
{
    class Empleado
    {
        private string idcedula;

        public string Idcedula
        {
            get { return idcedula; }
            set { idcedula = value; }
        }
        
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellidouno;

        public string ApellidoUno
        {
            get { return apellidouno; }
            set { apellidouno = value; }
        }

        private string apellidodos;

        public string Apellidodos
        {
            get { return apellidodos; }
            set { apellidodos = value; }
        }

        private string estadocivil;

        public string Estadocivil
        {
            get { return estadocivil; }
            set { estadocivil = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }        

    }
}
