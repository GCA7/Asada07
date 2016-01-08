using Asada.Entidades;
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

namespace Asada.GUI
{
    public partial class SerchPrevista : Form
    {
        private frmPrevistas fprv;
        private Usuario user;
        private Prevista prv;        
        private PrevistaDAO prvDao;
        private DataTable dt;
        private DataSet dts, dts1;
        //private string columnName = "", filterValue = "", rowFilter = "";

        public SerchPrevista(Usuario us)
        {
            InitializeComponent();
            this.user = us;
        }

        private Prevista GetInfo()
        {
            prv.Code = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            prv.CodeRate = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            prv.Identification = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            prv.Sector = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            prv.Balance = float.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            prv.IsActive = bool.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            prv.Ubication = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            return prv;
        }

        private void SerchPrevista_Load(object sender, EventArgs e)
        {
            prv = new Prevista();
            dt = new DataTable();
            dts = new DataSet();
            prvDao = new PrevistaDAO(this.user);
            // Con la información del adaptador se rellena el DataTable
            prvDao.LoadPrevista().Fill(dt);
            dts.Tables.Add(dt);
            // Se asigna el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = dts.Tables[0];
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.GetInfo();            
            this.Hide();
            fprv.Prev_Load(user, prv);
            fprv.Show();
        }

        private void SerchPrevista_FormClosed(object sender, FormClosedEventArgs e)
        {
            prv = new Prevista();
            this.Hide();
            fprv.Prev_Load(user, prv);
            fprv.Show();
        }
    }
}
