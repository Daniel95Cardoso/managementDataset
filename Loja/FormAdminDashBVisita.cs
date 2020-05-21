using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loja
{
    public partial class FormAdminDashBVisita : Form
    {
        #region TableAdapter
        DataSet1TableAdapters.BensTableAdapter bensTableAdapter = new DataSet1TableAdapters.BensTableAdapter();
        DataSet1TableAdapters.ProdutosTableAdapter produtosTableAdapter = new DataSet1TableAdapters.ProdutosTableAdapter();
        DataSet1TableAdapters.DespContentorTableAdapter despContentorTableAdapter = new DataSet1TableAdapters.DespContentorTableAdapter();
        DataSet1TableAdapters.DespMensaisTableAdapter despMensaisTableAdapter = new DataSet1TableAdapters.DespMensaisTableAdapter();
        DataSet1TableAdapters.EncomendasTableAdapter encomendasTableAdapter = new DataSet1TableAdapters.EncomendasTableAdapter();
        DataSet1TableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter = new DataSet1TableAdapters.FornecedoresTableAdapter();
        DataSet1TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter = new DataSet1TableAdapters.FuncionarioTableAdapter();
        DataSet1TableAdapters.MoedaTableAdapter moedaTableAdapter = new DataSet1TableAdapters.MoedaTableAdapter();
        DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter = new DataSet1TableAdapters.ClientesTableAdapter();
        DataSet1TableAdapters.VendasTableAdapter vendasTableAdapter = new DataSet1TableAdapters.VendasTableAdapter();
        #endregion
        public FormAdminDashBVisita()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            String procurar = tbProcurar.Text.Trim();
            String procurarTabela = cbProcurar.Text.Trim();
            try
            {
                if (String.IsNullOrEmpty(procurar))
                {
                    if (procurarTabela == "Bens")
                    {
                        dataGridView1.DataSource = bensTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Produtos")
                    {
                        dataGridView1.DataSource = produtosTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Despesas Contentor")
                    {
                        dataGridView1.DataSource = despContentorTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Despesas Mensais")
                    {
                        dataGridView1.DataSource = despMensaisTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Encomendas")
                    {
                        dataGridView1.DataSource = encomendasTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Fornecedores")
                    {
                        dataGridView1.DataSource = fornecedoresTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Funcionarios")
                    {
                        dataGridView1.DataSource = funcionarioTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Moeda")
                    {
                        dataGridView1.DataSource = moedaTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Clientes")
                    {
                        dataGridView1.DataSource = clientesTableAdapter.Reset();
                    }
                    else if (procurarTabela == "Vendas")
                    {
                        dataGridView1.DataSource = vendasTableAdapter.Reset();
                    }
                    else
                    {
                        MessageBox.Show("Erro!");
                    }

                }
                else
                {
                    if (procurarTabela == "Bens")
                    {
                        dataGridView1.DataSource = bensTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Produtos")
                    {
                        dataGridView1.DataSource = produtosTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Despesas Contentor")
                    {
                        dataGridView1.DataSource = despContentorTableAdapter.ProcurarQuery(Convert.ToInt32(procurar));
                    }
                    else if (procurarTabela == "Despesas Mensais")
                    {
                        dataGridView1.DataSource = despMensaisTableAdapter.ProcurarQuery(Convert.ToInt32(procurar));
                    }
                    else if (procurarTabela == "Encomendas")
                    {
                        dataGridView1.DataSource = encomendasTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Fornecedores")
                    {
                        dataGridView1.DataSource = fornecedoresTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Funcionarios")
                    {
                        dataGridView1.DataSource = funcionarioTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Moeda")
                    {
                        dataGridView1.DataSource = moedaTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Clientes")
                    {
                        dataGridView1.DataSource = clientesTableAdapter.ProcurarQuery(procurar);
                    }
                    else if (procurarTabela == "Vendas")
                    {
                        dataGridView1.DataSource = vendasTableAdapter.ProcurarQuery(Convert.ToInt32(procurar));
                    }
                    else
                    {
                        MessageBox.Show("Erro!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }
    }
}
