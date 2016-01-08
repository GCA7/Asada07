using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada.Entidades
{
    public class Sector
    {
        private string code;

        public string  Code
        {
            get { return code; }
            set { code = value; }
        }

        private int consecutive;

        public int Consecutive
        {
            get { return consecutive; }
            set { consecutive = value; }
        }
        

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
    }
}
