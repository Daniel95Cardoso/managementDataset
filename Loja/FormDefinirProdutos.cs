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

namespace Loja.Produtos
{
    public partial class FormDefinirProdutos : Form
    {
        DataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter = new DataSet1TableAdapters.ProdutosTableAdapter();
        public FormDefinirProdutos()
        {
            InitializeComponent();
        }
        
       
        private void FormDefinirProdutos_Load(object sender, EventArgs e)
        {
            Reset();
        }

        void Reset()
        {
            dataGridView1.DataSource = produtosTableAdapter.Reset();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Int32 Stock = 0;
            try
            {
            produtosTableAdapter.InserirQuery(tbNome.Text.Trim(), Stock);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
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
            produtosTableAdapter.EditarQuery(tbNome.Text.Trim(), Convert.ToInt32(tbStock.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
            finally
            {
                Reset();
            }
        }

        private void btnApagar_Click_1(object sender, EventArgs e)
        {
            try
            {
            produtosTableAdapter.ApagarQuery(tbNome.Text.Trim());

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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = produtosTableAdapter.ProcurarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "erro");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
