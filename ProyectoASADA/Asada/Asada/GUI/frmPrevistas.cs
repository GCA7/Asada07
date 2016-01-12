using Asada.DAO;
using Asada.DAO.Asada.DAO;
using Asada.Entidades;
using Asada.GUI;
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
    public partial class frmPrevistas : Form
    {
        private Usuario user;
        private TarifaDAO trfDao;
        private Tarifa trf;
        private Abonado abo;
        private List<Abonado> listAbn;
        private AbonadoDAO abnDao;
        private Prevista prv;
        private PrevistaDAO prvDao;
        private SectorDAO secDao;
        private SerchPrevista serchPrv;
        private Principal fpr;
        private string btnSaveOption;

        public frmPrevistas(Usuario usu, Prevista pv)
        {
            InitializeComponent();
            this.user = usu;
            this.prv = pv;
            this.ValidUtils(prv);
            this.Prev_Load(usu,prv);
        }

        public void Prev_Load(Usuario usu, Prevista prv)
        {
            // Llena el combobox tarifas
            //trfDao = new TarifaDAO(this.user);
            //cbxRate.DisplayMember = "TypeAppString";
            //cbxRate.ValueMember = "Code";
            //cbxRate.DataSource = trfDao.LoadTarifa();
            cbxRate.Items.Add("Mensual Fija");
            cbxRate.Items.Add("Metros Cúbicos");
            cbxRate.SelectedItem = 0;

            // LLena el combo de Abonados
            abnDao = new AbonadoDAO(this.user);
            cbxAbonado.DisplayMember = "Name";
            cbxAbonado.ValueMember = "Identification";
            if (abnDao.LoadAbonado1().Count > 0)
            {
                cbxAbonado.DataSource = abnDao.LoadAbonado1();
            }
            else
            {
                MessageBox.Show("No hay abonados disponibles para asignar a las previstas!", "Atención");
                //mostrar popup, notificacion o mensaje en un label o formulario, por al menos 3 segundos 
            }

            // obtiene el consecutivo de previstas
            prvDao = new PrevistaDAO(this.user);
            txtCode.Text = prvDao.ConsecutivePrv().ToString();
            txtCode.ReadOnly = true;
            txtCode.Enabled = false;

            // se obtienen y establecen los sectores
            secDao = new SectorDAO(this.user);
            cbxSector.DisplayMember = "Description";
            cbxSector.ValueMember = "Code";
            cbxSector.DataSource = secDao.LoadSector();
        }

        private Prevista GetInfo()
        {
            prv = new Prevista();
            trf = new Tarifa();
            prv.Code = txtCode.Text.Trim();
            prv.CodeRate = cbxRate.SelectedIndex.ToString();
            prv.Sector = cbxSector.SelectedValue.ToString();
            prv.Identification = cbxAbonado.SelectedValue.ToString();

            int n = cbxRate.SelectedIndex;
            if (n == 0)
            {
                trf.TypeApplication = true;
                prv.IsActive = true;
            }
            else
            {
                trf.TypeApplication = false;
                prv.IsActive = false;
            }

            prv.Ubication = txtAddress.Text;

            return prv;
        }

        private bool ValidUtils(Prevista pv)
        {
            prv = new Prevista();
            prv = pv;

            if (pv.Code == null)
            {
                btnNewUpdate.Text = "Guardar";
                return false;
            }
            else
            {
                btnNewUpdate.Text = "Actualizar";
                checkBoxState.Checked = true;

                return true;
            }

        }
        
        private void btnSerch_Click(object sender, EventArgs e)
        {
            serchPrv = new SerchPrevista(this.user);
            serchPrv.ShowDialog(this);
            this.Hide();
        }

        private void btnNewUpdate_Click(object sender, EventArgs e)
        {
            prvDao = new PrevistaDAO(this.user);            
            btnSaveOption = btnNewUpdate.Text;
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show(this, "Se detecto campos vacíos!  Verifique...", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                switch (btnSaveOption)
                {
                    case "Guardar":
                        if (prvDao.InsertNew((prv = this.GetInfo())))
                        {
                            MessageBox.Show(this, "Datos almacenados correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //refrescar el combo de abonados sin prevista
                        }
                        else
                        {
                            MessageBox.Show(this, "Error al guardar los datos!  Verifique...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        break;

                    case "Actualizar":
                        prvDao.UpdatePrv((prv = this.GetInfo()));
                        this.ValidUtils(prv);
                        break;
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void frmPrevistas_FormClosed(object sender, FormClosedEventArgs e)
        {
            fpr = (Principal)this.Owner;
            fpr.Pri_Load(user);
            fpr.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            fpr = (Principal)this.Owner;
            fpr.Pri_Load(user);
            fpr.Show();
        }
    }
}
