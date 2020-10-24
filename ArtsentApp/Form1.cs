using ArtsentApp.Repositorio;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtsentApp
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnImportar, "Importar");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRefresh, "Refrezcar");
            cboProducto.DataSource = Consultas.GetProductos();
            cboProducto.DisplayMember = "CodigoDescripcion";
            cboProducto.ValueMember = "Codigo";
            cboProducto.SelectedIndex = -1;
        }

        private async void btnImportar_Click(object sender, EventArgs e)
        {
            var task = ImportFile();
            await task;
        }

        private async Task ImportFile()
        {
            await Task.Run(() =>
            {
                try
                {
                    string path = @"C:\Artsant\";
                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);
                    string now = DateTime.Now.ToString("dd_MM_yyyy HH_mm_ss");
                    string file = path + @"Stock_" + now + ".txt";
                    if (!File.Exists(file))
                    {
                        using (StreamWriter sw = File.CreateText(file))
                        {
                            for (int i = 0; i < dgvStock.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvStock.Columns.Count; j++)
                                {
                                    sw.Write("\t" + dgvStock.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                                sw.WriteLine("");
                                sw.WriteLine("-----------------------------------------------------");
                            }
                            sw.Close();
                            MessageBox.Show("Data Exported");

                        }
                    }
                    else
                    {
                        using (StreamWriter sw = File.CreateText(file))
                        {
                            for (int i = 0; i < dgvStock.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvStock.Columns.Count; j++)
                                {
                                    sw.Write("\t" + dgvStock.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                                }
                                sw.WriteLine("");
                                sw.WriteLine("-----------------------------------------------------");
                            }
                            sw.Close();
                            MessageBox.Show("Data Exported");

                        }
                    }

                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            });
        }

        private void frmStock_Load(object sender, EventArgs e)
        {

        }


        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CargarGrilla(cboProducto.SelectedValue.ToString());
            lblCodDesc.Text = cboProducto.SelectedValue.ToString();
        }
        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDesc.Checked)
            {
                cboProducto.DisplayMember = "DescripcionCodigo";
                cboProducto.ValueMember = "Descripcion";
                if(cboProducto.Text != "")
                {
                    lblCodDesc.Text = cboProducto.SelectedValue.ToString();
                }
                
            }
            else
            {
                cboProducto.DisplayMember = "CodigoDescripcion";
                cboProducto.ValueMember = "Codigo";
                if (cboProducto.Text != "")
                {
                    lblCodDesc.Text = cboProducto.SelectedValue.ToString();
                }
            }
        }

        private void CargarGrilla(string codigo)
        {
            dgvStock.DataSource = Consultas.GetGrilla(codigo);
            lblDisponible.Text = " Total Disponible: " + Disponibilidad().ToString();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = Consultas.GetGrilla(cboProducto.SelectedValue.ToString());
            lblDisponible.Text = " Total Disponible: " + Disponibilidad().ToString();
        }

        private void cboProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dgvStock.DataSource = Consultas.GetGrilla(cboProducto.SelectedValue.ToString());
                lblDisponible.Text = " Total Disponible: " + Disponibilidad().ToString();
            }
        }

        private decimal Disponibilidad()
        {
            decimal suma = 0;
            foreach (DataGridViewRow row in dgvStock.Rows)
            {
                if (row.Cells["STOCK"].Value != null)
                    suma += (decimal)row.Cells["STOCK"].Value;
            }
            return suma;
        }
    }
}
