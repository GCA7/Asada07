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
    public class TarifaDAO
    {
        private string sql = "";
        private Tarifa trf;
        private Usuario user;
        private List<Tarifa> lisTrf;
        private Connection clsCon;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        public TarifaDAO()
        {
        }

        public TarifaDAO(Usuario usu)
        {
            this.user = usu;
        }

        public List<Tarifa> LoadTarifa()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    lisTrf = new List<Tarifa>();
                    cn.Open();
                    sql = "select * from asada.view_tarifas";
                    cmd = new MySqlCommand(sql, cn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        trf = new Tarifa();
                        trf.Code = reader.GetString(0);
                        trf.FixAmount = float.Parse(reader.GetString(1));
                        trf.MetAmount = float.Parse(reader.GetString(2));
                        trf.RateHidrant = float.Parse(reader.GetString(3));
                        trf.TypeAppString = reader.GetString(4);
                        lisTrf.Add(trf);
                    }
                    reader.Close();
                    return lisTrf;
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
