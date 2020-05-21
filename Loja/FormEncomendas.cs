using Loja.Produtos;
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
    public partial class FormEncomendas : Form
    {
        DataSet1TableAdapters.EncomendasTableAdapter encomendasTableAdapter = new DataSet1TableAdapters.EncomendasTableAdapter();
        DataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter = new DataSet1TableAdapters.ProdutosTableAdapter();

        public FormEncomendas()
        {
            InitializeComponent();
        }

        private void FormEncomendas_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset() 
        {
            dataGridView1.DataSource = encomendasTableAdapter.Reset();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormDefinirProdutos formDefinirProdutos = new FormDefinirProdutos();
            formDefinirProdutos.Show();
        }

        private void btnForncedores_Click(object sender, EventArgs e)
        {
            FormFornecedores formFornecedores = new FormFornecedores();
            formFornecedores.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            String data = dateTimePicker.Text;
            try
            {
                encomendasTableAdapter.InserirQuery(Convert.ToInt32(tbQuantidade.Text.Trim()), Convert.ToDecimal(tbPreco.Text.Trim()), Convert.ToDateTime(data), Convert.ToInt32(tbIDProduto.Text.Trim()), Convert.ToInt32(tbIdFornecedor.Text.Trim()), tbObs.Text.Trim(), tbIdEncomendas.Text.Trim());
                produtosTableAdapter.FQuery_Guardar_Encomenda();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                encomendasTableAdapter.FQuery_Editar_Encomenda(Convert.ToInt32(tbQuantidade.Text.Trim()), Convert.ToDecimal(tbPreco.Text.Trim()), Convert.ToDateTime(dateTimePicker.Text), Convert.ToInt32(tbIDProduto.Text.Trim()), Convert.ToInt32(tbIdFornecedor.Text.Trim()), tbObs.Text.Trim(), tbIdEncomendas.Text.Trim());
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
                encomendasTableAdapter.ApagaQuery(tbIdEncomendas.Text.Trim());
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
                dataGridView1.DataSource = encomendasTableAdapter.ProcurarQuery(tbIdEncomendas.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }
    }
}
