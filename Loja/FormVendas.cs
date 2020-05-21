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
    public partial class FormVendas : Form
    {
        DataSet1TableAdapters.VendasTableAdapter vendasTableAdapter = new DataSet1TableAdapters.VendasTableAdapter();
        DataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter = new DataSet1TableAdapters.ProdutosTableAdapter();
        public FormVendas()
        {
            InitializeComponent();
        }

        private void Reset() 
        {
            dataGridView1.DataSource = vendasTableAdapter.Reset();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            FormDefinirProdutos formDefinirProdutos = new FormDefinirProdutos();
            formDefinirProdutos.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormNovosClientes formNovosClientes = new FormNovosClientes();
            formNovosClientes.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbQuantidade.Text) || String.IsNullOrEmpty(tbPreco.Text))
            {
                MessageBox.Show("Quantidade ou Preço estão vazias");
            }
            else
            {
                String data = dateTimePicker.Text;
                try
                {
                    vendasTableAdapter.InserirQuery(Convert.ToDateTime(data), Convert.ToInt32(tbQuantidade.Text.Trim()), Convert.ToDecimal(tbPreco.Text.Trim()), Convert.ToInt32(tbIdCliente.Text.Trim()), Convert.ToInt32(tbIDProduto.Text.Trim()), tbObs.Text.Trim());
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbQuantidade.Text) || String.IsNullOrEmpty(tbPreco.Text))
            {
                MessageBox.Show("Quantidade ou Preço estão vazias");
            }
            else
            {
                Decimal Total = Convert.ToDecimal(tbPreco.Text.Trim()) * Convert.ToDecimal(tbQuantidade.Text.Trim());
                try
                {
                    String data = dateTimePicker.Text;
                    vendasTableAdapter.FQuery_Editar_Vendas(Convert.ToDateTime(data), Convert.ToInt32(tbQuantidade.Text.Trim()), Convert.ToDecimal(tbPreco.Text.Trim()), Convert.ToInt32(tbIdCliente.Text.Trim()), Convert.ToInt32(tbIDProduto.Text.Trim()), tbObs.Text.Trim(), Total, Convert.ToInt32(tbIdVendas.Text.Trim()));
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
               vendasTableAdapter.ApagarQuery(Convert.ToInt32(tbIdVendas.Text.Trim()));
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
                dataGridView1.DataSource = vendasTableAdapter.ProcurarQuery(Convert.ToInt32(tbIdVendas.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVendas_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
