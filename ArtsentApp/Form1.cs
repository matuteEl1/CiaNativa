using ArtsentApp.Repositorio;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtsentApp
{
    public partial class frmStock : Form
    {
        private bool firtLaunch = true;
        public frmStock()
        {
            InitializeComponent();
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnImportar, "Importar");
            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnRefresh, "Refrezcar");
            cboProducto.DataSource = Consultas.GetProductos();
            cboProducto.DisplayMember = "Codigo";
            cboProducto.ValueMember = "Descripcion";
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

        private void chkDescripcion_CheckedChanged(object sender, EventArgs e)
        {
            if(chkDescripcion.Checked)
            {
                cboProducto.DisplayMember = "Descripcion";
                cboProducto.ValueMember = "Codigo";
            }
            else
            {
                cboProducto.DisplayMember = "Codigo";
                cboProducto.ValueMember = "Descripcion";
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firtLaunch)
            {
                firtLaunch = false;
                return;
            }
            if (cboProducto.Text == "")
                return;
            else
                dgvStock.DataSource = Consultas.GetGrilla(cboProducto.Text);
        }

        private void cboProducto_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (firtLaunch)
            {
                firtLaunch = false;
                return;
            }
            dgvStock.DataSource = Consultas.GetGrilla(cboProducto.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvStock.DataSource = Consultas.GetGrilla(cboProducto.Text);
        }
    }
}
