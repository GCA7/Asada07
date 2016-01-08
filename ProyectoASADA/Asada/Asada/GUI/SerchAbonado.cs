using Asada2015.DAO;
using Asada2015.Entidades;
using System;
using System.Collections;
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
    public partial class SerchAbonado : Form
    {
        private frmAbonados frmAbo;
        private Abonado abo;
        private AbonadoDAO aboDao;
        private Usuario usu;
        private DataTable dt;
        private DataSet dts, dts1;
        private string columnName = "", filterValue = "", rowFilter = "", filtertext = "";
        private int rows = 0, columns = 0;
        public SerchAbonado(Usuario us)
        {
            InitializeComponent();
            this.usu = us;
        }

        /// <summary>
        /// este evento se ejecuta al escribir en el textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dts1 = dts.Copy();
            if (textBox1.Text.Trim() != string.Empty)
            {

                if (RbIdentification.Checked)
                {
                    columnName = "Cédula";
                    filtertext = filtraced();
                    //filtertext = maskedTextBox1.Text;                    
                }
                else
                {
                    if (RbName.Checked)
                    {
                        columnName = "Nombre";
                        filtertext = textBox1.Text;
                    }
                    else
                    {
                        columnName = "Apellidos";
                        filtertext = textBox1.Text;
                    }
                }
                // forma generica admite cambio de columnas
                rowFilter = columnName + (filterValue = " like '%" + filtertext + "%'");
                dts1.Tables[0].DefaultView.RowFilter = rowFilter;
                dataGridView1.DataSource = dts1.Tables[0].DefaultView;
                RowsBackColor(dataGridView1);
            }
            else
            {
                dataGridView1.DataSource = dts.Tables[0];
                RowsBackColor(dataGridView1);
            }
            filtertext = "";
        }

        /// <summary>
        /// da color a fila de por medio en el dataGridView1
        /// </summary>
        /// <param name="dataGridView1"></param>
        private void RowsBackColor(DataGridView dataGridView1)
        {
            System.Drawing.Color c = Color.LightSkyBlue;
            rows = dataGridView1.RowCount;
            columns = dataGridView1.ColumnCount;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i % 2 == 0)
                    {
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = c;
                    }
                }
            }
        }

        /// <summary>
        /// ayuda a filtrar la cedula sin que el usuario agregue los guiones
        /// </summary>
        /// <returns></returns>
        private string filtraced()
        {
            int cont = 0;
            string num = "";
            for (int i = 0; i < textBox1.TextLength; i++)
            {
                cont++;
                if (cont == 3 || cont == 7 || cont == 11 || cont == 15)
                {
                    num += "-";
                    num += textBox1.Text[i].ToString();
                }
                else
                {
                    num += textBox1.Text[i].ToString();
                }

            }
            return num;
        }

        private Abonado GetInfo()
        {
            abo = aboDao.SerchOneAbonado(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return abo;
        }

        /// <summary>
        /// load del formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerchAbonado_Load(object sender, EventArgs e)
        {
            aboDao = new AbonadoDAO(usu);
            abo = new Abonado();
            dt = new DataTable();
            dts = new DataSet();
            // Con la información del adaptador, desde el metodo cargaAbonado se rellena el DataTable
            aboDao.LoadAbonado().Fill(dt);
            dts.Tables.Add(dt);
            // Se asigna el DataTable como origen de datos del DataGridView
            dataGridView1.DataSource = dts.Tables[0];
            RowsBackColor(dataGridView1);
        }

        /// <summary>
        /// evento doble clic sobre el dataGridView1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            abo = GetInfo();
            this.Hide();
            frmAbo = (frmAbonados)this.Owner;
            frmAbo.Abo_Load(abo, usu);
            frmAbo.Show();
        }

        private void BtnAccept_Click(object sender, EventArgs e)
        {
            abo = GetInfo();
            this.Hide();
            frmAbo = (frmAbonados)this.Owner;
            frmAbo.Abo_Load(abo, usu);
            frmAbo.Show();
        }

        private void SerchAbonado_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.OutAction();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.OutAction();
        }

        private void OutAction()
        {
            abo = new Abonado();
            frmAbo = (frmAbonados)this.Owner;
            frmAbo.Abo_Load(abo, usu);
            frmAbo.Show();
        }
    }
}