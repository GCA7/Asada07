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
                    // guardar esta vista en la BD
                    sql = "select pr.ID_PREVISTA as 'Código de Prevista', pr.ID_ABONADO as 'Cédula de Abonado', concat(ab.APELLIDO1,' ', ab.APELLIDO2,' ',ab.NOMBRE) as 'Nombre', pr.ID_TARIFAS as 'Código de Tarifa', pr.UBICACION as 'Ubicación', pr.ESTADO as 'Estado'"+ 
                    "from asada.prevista as pr left join asada.abonados as ab on pr.ID_ABONADO = ab.ID_ABONADO ";
                    cmd = new MySqlCommand(sql, cn);
                    MySqlDataAdapter dt = new MySqlDataAdapter(sql, cn);
                    return dt;
                }
            }
            catch (Exception)
            {
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
            catch (Exception)
            {
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
            catch (Exception)
            {
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
                    sql = "select * from asada.consecutivos";
                    cmd = new MySqlCommand(sql, cn);
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        n = reader.GetInt32(1)+1;
                    }
                    reader.Close();
                }
                return n;
            }
            catch (Exception)
            {
                return 0;
                throw;
            }
        }
    }
}
