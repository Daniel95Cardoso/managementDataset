using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class FormFornecedores : Form
    {
        DataSet1TableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter = new DataSet1TableAdapters.FornecedoresTableAdapter();
        public FormFornecedores()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Reset()
        {
            dataGridView1.DataSource = fornecedoresTableAdapter.Reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {            
                fornecedoresTableAdapter.InserirQuery(tbNome.Text.Trim(), tbContacto.Text.Trim(), tbMorada.Text.Trim(), tbEmail.Text.Trim(), tbObs.Text.Trim());
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

        private void FormFornecedores_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedoresTableAdapter.EditarQuery(tbNome.Text.Trim(), tbContacto.Text.Trim(), tbMorada.Text.Trim(), tbEmail.Text.Trim(), tbObs.Text.Trim());
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                fornecedoresTableAdapter.ApagarQuery(tbNome.Text.Trim());
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

        private void btnProcura_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = fornecedoresTableAdapter.ProcurarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }
    }
}
