using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada.Entidades
{
    public class Prevista
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        private string identification;

        public string Identification
        {
            get { return identification; }
            set { identification = value; }
        }        

        //refiere al codigo de tarifa
        private string codeRate;

        public string CodeRate
        {
            get { return codeRate; }
            set { codeRate = value; }
        }

        private string ubication;

        public string Ubication
        {
            get { return ubication; }
            set { ubication = value; }
        }

        private bool isActive;

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private string sector;

        public string  Sector
        {
            get { return sector; }
            set { sector = value; }
        }

        //refiere el monto a pagar por la prevista
        private float balance;

        public float Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private string nacionality;

        public string Nacionality
        {
            get { return nacionality; }
            set { nacionality = value; }
        }

        private string nameAbonado;

        public string NameAbonado
        {
            get { return nameAbonado; }
            set { nameAbonado = value; }
        }
        
    }
}
