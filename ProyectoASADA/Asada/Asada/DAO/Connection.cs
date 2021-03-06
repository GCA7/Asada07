﻿using Asada.DAO;
using Asada2015.Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asada2015.DAO
{
    public class Connection
    {
        private string stringConn = "";
        private Usuario user;

        public Connection()
        {
        }

        public Connection(Usuario usu)
        {
            this.user = usu;
        }

        public string Parameters()
        {
            return stringConn = String.Format(ConfigurationManager.ConnectionStrings["Connection"].ToString() + ";Uid=" + user.Name + ";password=" + user.Password);
        }

        public bool Conexion()
        {
            try
            {
                using (MySqlConnection cn = new MySqlConnection(this.Parameters()))
                {
                    cn.Open();
                    return true;
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
    }
}
