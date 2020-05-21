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
    public partial class FormMoeda : Form
    {
        DataSet1TableAdapters.MoedaTableAdapter moedaTableAdapter = new DataSet1TableAdapters.MoedaTableAdapter();
        public FormMoeda()
        {
            InitializeComponent();
        }

        void Reset()
        {
            dataGridView1.DataSource = moedaTableAdapter.Reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                moedaTableAdapter.InserirQuery(tbNomeMoeda.Text.Trim(), Convert.ToDecimal(tbValor.Text.Trim()));

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

        private void FormMoeda_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                moedaTableAdapter.EditarQuery(tbNomeMoeda.Text.Trim(), Convert.ToDecimal(tbValor.Text.Trim()));
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
                moedaTableAdapter.ApagarQuery(tbNomeMoeda.Text.Trim());
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
                dataGridView1.DataSource = moedaTableAdapter.ProcurarQuery(tbNomeMoeda.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
        }
    }
}
