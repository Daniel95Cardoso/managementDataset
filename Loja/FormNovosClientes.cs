using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Loja
{
    public partial class FormNovosClientes : Form
    {
        DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter = new DataSet1TableAdapters.ClientesTableAdapter();
        public FormNovosClientes()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNovosClientes_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clientesTableAdapter.InserirQuery(tbNome.Text.Trim(), tbContacto.Text.Trim(), tbMorada.Text.Trim(), tbNIdentificacao.Text.Trim(), tbCoordenadas.Text.Trim(), tbTipoDocumento.Text.Trim(), tbObs.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
            finally
            {
                Reset();
            }
        }

        void Reset()
        {
            dataGridView1.DataSource = clientesTableAdapter.Reset();
        }

        private void btnProcura_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = clientesTableAdapter.ProcurarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try                
            {
                clientesTableAdapter.ApagarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
            finally
            {
                Reset();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                clientesTableAdapter.EditarQuery(tbNome.Text.Trim(), tbContacto.Text.Trim(), tbMorada.Text.Trim(), tbNIdentificacao.Text.Trim(), tbCoordenadas.Text.Trim(), tbTipoDocumento.Text.Trim(), tbObs.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
            finally
            {
                Reset();
            }
        }
    }
}
