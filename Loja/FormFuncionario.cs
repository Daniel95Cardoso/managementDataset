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
    public partial class FormFuncionario : Form
    {
        DataSet1TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter = new DataSet1TableAdapters.FuncionarioTableAdapter();
        public FormFuncionario()
        {
            InitializeComponent();
        }

        void Reset()
        {
            dataGridView1.DataSource = funcionarioTableAdapter.Reset();
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionarioTableAdapter.ApagarQuery(tbNome.Text.Trim());
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
                funcionarioTableAdapter.EditarQuery(tbNome.Text.Trim(), tbFuncao.Text.Trim(), tbMorada.Text.Trim(), Convert.ToInt32(tbContacto.Text.Trim()), tbEmail.Text.Trim(), tbPassword.Text.Trim());
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                funcionarioTableAdapter.InserirQuery(tbNome.Text.Trim(), tbFuncao.Text.Trim(), tbMorada.Text.Trim(), Convert.ToInt32(tbContacto.Text.Trim()), tbEmail.Text.Trim(), tbPassword.Text.Trim());
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = funcionarioTableAdapter.ProcurarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
        }
    }
}
