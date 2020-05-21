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
    public partial class FormBens : Form
    {
        DataSet1TableAdapters.BensTableAdapter bensTableAdapter = new DataSet1TableAdapters.BensTableAdapter();
        public FormBens()
        {
            InitializeComponent();
        }

        void Reset()
        {
            dataGridView1.DataSource = bensTableAdapter.Reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                bensTableAdapter.InserirQuery(tbNome.Text.Trim(), tbObs.Text.Trim());
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
                bensTableAdapter.EditarQuery(tbNome.Text.Trim(), tbObs.Text.Trim());
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

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                bensTableAdapter.ApagarQuery(tbNome.Text.Trim());
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

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            try
            {
                bensTableAdapter.ProcurarQuery(tbNome.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FormBens_Load(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
