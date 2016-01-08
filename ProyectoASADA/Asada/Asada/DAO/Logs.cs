using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada.DAO
{
    public class Logs
    {
        public Logs()
        {

        }

        public void Log(string error)
        {
            try
            {
                string path = Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location).Replace("\\bin\\Debug", "\\Notifications\\Exceptions.txt");
                StreamWriter sw = new StreamWriter(path, true);
                sw.WriteLine(error);
                sw.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

}
