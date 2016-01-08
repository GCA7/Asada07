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
    public partial class frmAbonados : Form
    {
        private Usuario usu;
        private Abonado abo;
        private AbonadoDAO aboDao;
        private Principal fpr;
        private string btnSaveOption;

        public frmAbonados(Usuario us, Abonado ab)
        {
            InitializeComponent();
            this.usu = us;
            this.abo = ab;
            this.Abo_Load(abo,usu);
        }


        public void Abo_Load(Abonado ab, Usuario user)
        {
            abo = new Abonado();
            abo = ab;

            if (radioButton1.Checked == true)
            {
                MtxtIdentification.Mask = "00-0000-0000";
                
            }
            else
            {
                MtxtIdentification.Mask = "00-0000-0000-0000-0000";
            }

            if (abo.Identification == null)
            {
                btnSaveUpdate.Text = "Guardar";
                MtxtIdentification.Enabled = true;   // txt modo sin edicion
                MtxtIdentification.ReadOnly = false; // txt modo solo lectura 
                return;
            }
            else
            {
                btnSaveUpdate.Text = "Editar";
                MtxtIdentification.AppendText(abo.Identification.ToString());
                MtxtIdentification.Enabled = false; 
                MtxtIdentification.ReadOnly = true; 
                TxtName.Text = abo.Name.ToString();
                TxtFirstN.Text = abo.Firstname.ToString();
                TxtLastN.Text = abo.Lastname.ToString();
                MtxtMovil.Text = abo.Movil.ToString();
                MtxtPhone.AppendText(abo.Phonenum.ToString());
                TxtEmail.Text = abo.Email.ToString();
                dateTimePicker1.Text = abo.Dateregister.ToString();
                TxtAddress.Text = abo.Address.ToString();
            }            
        }

        private void ReseTextBox()
        {
            this.Abo_Load(abo, usu);
            MtxtIdentification.ResetText();
            TxtName.ResetText();
            TxtFirstN.ResetText();
            TxtLastN.ResetText();
            MtxtPhone.ResetText();
            MtxtMovil.ResetText();
            TxtEmail.ResetText();
            TxtAddress.ResetText();
        }
        private string RemoveScript()
        {
            char[] number = MtxtIdentification.Text.Trim().ToCharArray();
            for (int i = 0; i < number.Length ; i++)
            {
                
            }
            return "";
        }
        private Abonado GetInfo()
        {
            abo = new Abonado();
            abo.Identification = MtxtIdentification.Text;
            abo.Name = TxtName.Text;
            abo.Firstname = TxtFirstN.Text;
            abo.Lastname = TxtLastN.Text;
            abo.Movil = MtxtMovil.Text;
            abo.Phonenum = MtxtPhone.Text;
            abo.Email = TxtEmail.Text;
            abo.Address = TxtAddress.Text;            
            abo.Dateregister = dateTimePicker1.Value.ToString("yyyy/MM/dd");
            return abo;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            SerchAbonado serch = new SerchAbonado(usu);            
            serch.ShowDialog(this);
        }
        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            btnSaveOption = btnSaveUpdate.Text;
            aboDao = new AbonadoDAO(this.usu);
            if (TxtName.Text.Trim() == "" || TxtFirstN.Text.Trim() == "" || TxtLastN.Text.Trim() == "" || MtxtPhone.Text.Trim() == "" || TxtAddress.Text == "")
            {
                MessageBox.Show(this, "Campos en blanco detectados, verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                switch (btnSaveOption)
                {
                    case "Guardar":                        
                        if (!aboDao.InsertNew((abo = GetInfo())))
                        {
                            MessageBox.Show(this, "El número de identificación ya existe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show(this, "Usuario agregado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ReseTextBox();
                        }
                        break;

                    case "Editar":
                        aboDao.Update((abo = GetInfo()));
                        MessageBox.Show(this, "Datos actualizados correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        abo = new Abonado();
                        this.ReseTextBox();
                        break;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            aboDao = new AbonadoDAO(this.usu);
            if (TxtName.Text.Trim() == "" || TxtFirstN.Text.Trim() == "" || TxtLastN.Text.Trim() == "" || MtxtPhone.Text.Trim() == "" || TxtAddress.Text == "")
            {
                MessageBox.Show(this, "Campos en blanco detectados, verifique!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (aboDao.Delete((abo = GetInfo())))
                {
                    MessageBox.Show(this, "Usuario eliminado correctamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(this, "No se puede eliminar el usuario por motivo de ", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            fpr = (Principal)this.Owner;
            fpr.Pri_Load(usu);
            fpr.Show();
        }

        private void frmAbonados_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            fpr = (Principal)this.Owner;
            fpr.Pri_Load(usu);
            fpr.Show();
        } 

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (MtxtIdentification.MaskCompleted)
            {
                return;
            }
            else
            {
                MtxtIdentification.Mask = "00-0000-0000";
            } 
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            if (MtxtIdentification.MaskCompleted)
            {
                return;
            }
            else
            {
                MtxtIdentification.Mask = "00-0000-0000-0000-0000";
            }
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            TxtName.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxtFirstN_TextChanged(object sender, EventArgs e)
        {
            TxtFirstN.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxtLastN_TextChanged(object sender, EventArgs e)
        {
            TxtLastN.CharacterCasing = CharacterCasing.Upper;
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            TxtEmail.CharacterCasing = CharacterCasing.Lower;
        }

        private void TxtAddress_TextChanged(object sender, EventArgs e)
        {
            TxtAddress.CharacterCasing = CharacterCasing.Upper;
        }

                
    }
}
