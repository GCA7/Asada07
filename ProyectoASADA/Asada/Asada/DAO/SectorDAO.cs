using Asada.Entidades;
using Asada2015.DAO;
using Asada2015.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada.DAO
{
    namespace Asada.DAO
    {
        public class SectorDAO
        {
            private string sql = "";
            private Connection clsCon;
            private Usuario user;
            private Sector sec;
            private List<Sector> listSec;
            private MySqlCommand cmd;
            private MySqlDataReader reader;

            public SectorDAO()
            {
            }

            public SectorDAO(Usuario us)
            {
                this.user = us;
            }

            public List<Sector> LoadSector()
            {
                try
                {
                    using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                    {
                        listSec = new List<Sector>();
                        cn.Open();
                        sql = "select * from asada.view_sectores";
                        cmd = new MySqlCommand(sql, cn);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            sec = new Sector();
                            sec.Code = reader.GetString(0);
                            sec.Consecutive = reader.GetInt32(1);
                            sec.Description = reader.GetString(2);
                            listSec.Add(sec);
                        }
                        reader.Close();
                        return listSec;
                    }
                }
                catch (Exception e)
                {
                    Logs lg = new Logs();
                    lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());
                    throw;
                }
            }
        }
    }
}