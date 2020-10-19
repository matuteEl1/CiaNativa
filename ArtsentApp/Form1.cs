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
            this.DoubleBuffered = true;
            dgvStock.VirtualMode = true;
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                            for (int i = 0; i < dgvStock.Rows.Count - 1; i++)
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
                            for (int i = 0; i < dgvStock.Rows.Count - 1; i++)
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
            cboProducto.DataSource = Consultas.GetProductos();
            cboProducto.DisplayMember = "xxx";
            cboProducto.ValueMember = "yyyy";

            dgvStock.DataSource = Consultas.GetGrilla();
        }
    }
}
