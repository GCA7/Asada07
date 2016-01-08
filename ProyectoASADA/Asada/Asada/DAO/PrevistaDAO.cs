using Asada.DAO;
using Asada.Entidades;
using Asada2015.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada2015.DAO
{
    public class PrevistaDAO
    {
        private string sql = "";
        private int result;
        private Usuario user;
        private Prevista pre;
        private Connection clsCon;
        private MySqlCommand cmd;
        private MySqlDataReader reader;
        public PrevistaDAO()
        {
        }

        public PrevistaDAO(Usuario usu)
        {
            this.user = usu;
        }

        public MySqlDataAdapter LoadPrevista()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    pre = new Prevista();
                    cn.Open();
                    sql = "select * from asada.view_previstas";
                    cmd = new MySqlCommand(sql, cn);
                    MySqlDataAdapter dt = new MySqlDataAdapter(sql, cn);
                    return dt;
                }
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());
                throw;
            }
        }


        public bool InsertNew(Prevista prv)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();

                    sql = "insert into asada.prevista (ID_PREVISTA, ID_TARIFAS, ID_ABONADO, ID_SECTOR, UBICACION, SALDO, ESTADO, TIPO_CEDULA, UBICACION)" +
                    "values(@Code, @CodeRate, @Identification, @ID_Sector, @Saldo, @IsActive, @Nacionality, @Ubication)";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.Add(new MySqlParameter("@Code", prv.Code));
                    cmd.Parameters.Add(new MySqlParameter("@CodeRate", prv.CodeRate));
                    cmd.Parameters.Add(new MySqlParameter("@Identification", prv.Identification));
                    cmd.Parameters.Add(new MySqlParameter("@ID_Sector", prv.Sector));
                    cmd.Parameters.Add(new MySqlParameter("@Saldo", prv.Balance));
                    cmd.Parameters.Add(new MySqlParameter("IsActive", prv.IsActive));
                    cmd.Parameters.Add(new MySqlParameter("@Nacionality", prv.Nacionality));
                    cmd.Parameters.Add(new MySqlParameter("Ubication", prv.Ubication));
                    result = cmd.ExecuteNonQuery();
                    return result > 0;

                }
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());

                return false;
                throw;
            }
        }

        public bool UpdatePrv(Prevista prv)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "update asada.prevista set ID_TARIFAS=@CodeRate, ID_ABONADO=@Identification, ID_SECTOR=@Sector, UBICACION=@Ubication, ESTADO=@IsActive where ID_PREVISTA=@Code";
                    cmd.Parameters.Add(new MySqlParameter("@CodeRate", prv.CodeRate));
                    cmd.Parameters.Add(new MySqlParameter("@Identification", prv.Identification));
                    cmd.Parameters.Add(new MySqlParameter("@Sector", prv.Sector));
                    cmd.Parameters.Add(new MySqlParameter("@Ubication", prv.Ubication));
                    cmd.Parameters.Add(new MySqlParameter("@IsActive", prv.IsActive));
                    cmd.Parameters.Add(new MySqlParameter("@Code", prv.Code));
                    result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());

                return false;
                throw;
            }
        }

        public int ConsecutivePrv()
        {
            try
            {
                int n = 0;
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "select PREVISTA from asada.consecutivos";
                    cmd = new MySqlCommand(sql, cn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        n = reader.GetInt32(0) + 1;
                    }
                    reader.Close();
                }
                return n;
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());

                return 0;
                throw;
            }
        }

        public bool Delete(string id)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "delete prevista from asada.prevista where ID_PREVISTA=@id";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("id", id);
                    result = cmd.ExecuteNonQuery();
                    return result > 0;
                }
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());

                return false;
                throw;
            }

        }

        public Prevista SerchOnePrevista(string id)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "select * from asada.prevista where ID_PREVISTA=@id";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("id", id);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        pre = new Prevista();
                        pre.Code = reader.GetString(0);
                        pre.CodeRate = reader.GetString(1);
                        pre.Identification = reader.GetString(2);
                        pre.Sector = reader.GetString(3);
                        pre.Balance = float.Parse(reader.GetString(4));
                        pre.IsActive = bool.Parse(reader.GetString(5));
                        pre.Nacionality = reader.GetString(6);
                        pre.Ubication = reader.GetString(7);
                    }
                    reader.Close();
                    return pre;
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
