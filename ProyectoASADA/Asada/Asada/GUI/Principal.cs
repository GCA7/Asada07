using Asada.Entidades;
using Asada2015.DAO;
using Asada2015.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asada2015.GUI
{
    public partial class Principal : Form
    {
        private Usuario usu;
        private Abonado abo;
        private frmAbonados frmAbo;
        private Login log;

        public Principal(Usuario user)
        {
            InitializeComponent();
            this.usu = user;
            this.Pri_Load(usu);
        }

        public void Pri_Load(Usuario user)
        {
            this.usu = user;
            if (this.usu.Name == null)
            {
                archivoToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
                nosotrosToolStripMenuItem.Enabled = false;
                logInToolStripMenuItem.Enabled = true;
                logOutToolStripMenuItem.Enabled = true;
            }
            else
            {
                this.Update();
                archivoToolStripMenuItem.Enabled = true;
                reportesToolStripMenuItem.Enabled = true;
                nosotrosToolStripMenuItem.Enabled = true;
            }
        }
        private bool ValidClosing()
        {
            DialogResult result = MessageBox.Show("  Deseas cerrar el sistema?", "Advertencia!", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void asociadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abo = new Abonado();
            frmAbo = new frmAbonados(usu, abo);
            frmAbo.ShowDialog(this);
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            log = new Login();
            log.ShowDialog(this);
        }


        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ValidClosing())
            {
                this.Dispose();
            }
        }

        private void previstasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prevista pv = new Prevista();
            frmPrevistas fprv = new frmPrevistas(usu,pv);
            fprv.ShowDialog(this);
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.ValidClosing())
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
