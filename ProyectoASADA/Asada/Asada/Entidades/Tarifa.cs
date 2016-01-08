using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada.Entidades
{
    public class Tarifa
    {
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        // Monto, tarifa fija
        private float fixAmount;

        public float FixAmount
        {
            get { return fixAmount; }
            set { fixAmount = value; }
        }

        // Monto por metro cúbico
        private float metAmount;

        public float MetAmount
        {
            get { return metAmount; }
            set { metAmount = value; }
        }

        // Tarifa hidrante
        private float rateHidrant;

        public float RateHidrant
        {
            get { return rateHidrant; }
            set { rateHidrant = value; }
        }

        // Establece si el cobro se hace manual o automático
        private bool typeApplication;

        public bool TypeApplication
        {
            get { return typeApplication; }
            set { typeApplication = value; }
        }

        private string typeAppString;
        
        // Para mostrar en comboBox
        public string TypeAppString
        {
            get { return typeAppString; }
            set { typeAppString = value; }
        }
        
    }
}
