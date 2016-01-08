using Asada2015.Entidades;
using MySql.Data.MySqlClient;
using System.Configuration;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Asada.DAO;

namespace Asada2015.DAO
{

    public class AbonadoDAO
    {
        private string sql = "";
        private int result;
        private Abonado abo;
        private Usuario user;
        private Connection clsCon;
        private MySqlCommand cmd;
        private List<Abonado> listAbo;
        private MySqlDataReader reader;

        public AbonadoDAO()
        {
        }

        public AbonadoDAO(Usuario usu)
        {
            this.user = usu;
        }

        public MySqlDataAdapter LoadAbonado()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    abo = new Abonado();
                    cn.Open();
                    sql = "select * from asada.view_abonados";
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

        public bool InsertNew(Abonado abo)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();

                    if (!Exist(abo))
                    {
                        sql = "insert into asada.abonados (ID_ABONADO, NOMBRE, APELLIDO1, APELLIDO2, MOVIL, TELEFONO, EMAIL, FECHA_REGISTRO, DIRECCION)" +
                        "values (@Identification, @Name, @Firstname, @Lastname, @Movil, @Phonenum, @Email, @Dateregister, @Address)";
                        cmd = new MySqlCommand(sql, cn);
                        cmd.Parameters.Add(new MySqlParameter("@Identification", abo.Identification));
                        cmd.Parameters.Add(new MySqlParameter("@Name", abo.Name));
                        cmd.Parameters.Add(new MySqlParameter("@Firstname", abo.Firstname));
                        cmd.Parameters.Add(new MySqlParameter("@Lastname", abo.Lastname));
                        cmd.Parameters.Add(new MySqlParameter("@Movil", abo.Movil));
                        cmd.Parameters.Add(new MySqlParameter("@Phonenum", abo.Phonenum));
                        cmd.Parameters.Add(new MySqlParameter("@Email", abo.Email));
                        cmd.Parameters.Add(new MySqlParameter("@Dateregister", abo.Dateregister));
                        cmd.Parameters.Add(new MySqlParameter("@Addres", abo.Address));
                        result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                    else
                    {
                        return false;
                    }
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

        public bool Update(Abonado abo)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "update asada.abonados set NOMBRE=@Name, APELLIDO1=@Firstname, APELLIDO2=@Lastname, MOVIL=@Movil, TELEFONO=@Phonenum, EMAIL=@Email, FECHA_REGISTRO=@Dateregister, DIRECCION=@Address where ID_ABONADO=@Identification";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.Add(new MySqlParameter("@Name", abo.Name));
                    cmd.Parameters.Add(new MySqlParameter("@Firstname", abo.Firstname));
                    cmd.Parameters.Add(new MySqlParameter("@Lastname", abo.Lastname));
                    cmd.Parameters.Add(new MySqlParameter("@Movil", abo.Movil));
                    cmd.Parameters.Add(new MySqlParameter("@Phonenum", abo.Phonenum));
                    cmd.Parameters.Add(new MySqlParameter("@Email", abo.Email));
                    cmd.Parameters.Add(new MySqlParameter("@Dateregister", abo.Dateregister));
                    cmd.Parameters.Add(new MySqlParameter("@Address", abo.Address));
                    cmd.Parameters.Add(new MySqlParameter("@Identification", abo.Identification));
                    result = cmd.ExecuteNonQuery();

                    if (result > 0) // ¿ verificar estas líneas?
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
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

        private bool Exist(Abonado abo)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "select count(ID_ABONADO) from asada.abonados where ID_ABONADO=@Identification";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.Add(new MySqlParameter("@Identification", abo.Identification));
                    result = Int32.Parse(cmd.ExecuteScalar().ToString());
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

        public List<Abonado> LoadAbonado1()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    listAbo = new List<Abonado>();
                    cn.Open();
                    sql = "select * from asada.vw_abonados";
                    cmd = new MySqlCommand(sql, cn);
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        abo = new Abonado();
                        abo.Identification = reader.GetString(0);
                        abo.Name = reader.GetString(1);
                        listAbo.Add(abo);
                    }
                    reader.Close();
                    return listAbo;
                }
            }
            catch (Exception e)
            {
                Logs lg = new Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());
                throw;
            }
        }

        public Abonado SerchOneAbonado(string id)
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection((clsCon = new Connection(this.user)).Parameters()))
                {
                    cn.Open();
                    sql = "select * from asada.abonados where ID_ABONADO=@Identification";
                    cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.Add(new MySqlParameter("@Identification", id));
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        abo = new Abonado();
                        abo.Identification = reader.GetString(0);
                        abo.Name = reader.GetString(1);
                        abo.Firstname = reader.GetString(2);
                        abo.Lastname = reader.GetString(3);
                        abo.Movil = reader.GetString(4);
                        abo.Phonenum = reader.GetString(5);
                        abo.Email = reader.GetString(6);
                        abo.Dateregister = reader.GetString(7);
                        abo.Address = reader.GetString(8);
                    }
                    reader.Close();
                    return abo;
                }
            }
            catch (Exception e)
            {
                Asada.DAO.Logs lg = new Asada.DAO.Logs();
                lg.Log(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss") + ", " + e.Message.ToString());
                throw;
            }
        }
    }
}
