using Asada2015.DAO;
using Asada2015.Entidades;
using Asada2015.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Asada2015
{
    public partial class Login : Form
    {
        /// <summary>
        /// clases a usar 
        /// </summary>
        private Usuario usu;
        private Connection con;
        private Principal pr;

        /// <summary>
        /// constructor vacio de la clase
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Evento click del boton aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAceptar_Click(object sender, EventArgs e)
        {            
            usu = new Usuario();
            //pr = new Principal(usu);
            pr = (Principal) this.Owner;
            if (txtPassword.Text.Trim() == "" || txtUser.Text.Trim() == "")
            {
                MessageBox.Show(this, "Campos en blanco detectados, verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usu.Name = txtUser.Text.Trim();
                usu.Password = txtPassword.Text.Trim();
                con = new Connection(usu);
                if (con.Conexion())
                {
                    this.Hide();
                    pr.Pri_Load(usu);
                    pr.Show();                    
                }
                else
                {
                    MessageBox.Show(this, "Usuario o contraseña incorrectos, Verifique!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                txtPassword.Focus();
            }
        }

        private void txtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnAccept.Focus();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            usu = new Usuario();
            pr = new Principal(usu);
            pr.Show();
            this.Hide();
        }


        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("  Deseas cerrar el sistema?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
            }        
        }   
    }
}
