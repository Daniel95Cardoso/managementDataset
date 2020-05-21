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
    public partial class FormDespContentor : Form
    {
        DataSet1TableAdapters.DespContentorTableAdapter despContentorTableAdapter = new DataSet1TableAdapters.DespContentorTableAdapter();
        public FormDespContentor()
        {
            InitializeComponent();
        }

        void Reset()
        {
            dataGridView1.DataSource = despContentorTableAdapter.Reset();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime data2 = Convert.ToDateTime(dateTimePicker2.Text);
                despContentorTableAdapter.EditarQuery(Convert.ToDecimal(tbValorFatura.Text.Trim()), Convert.ToDecimal(tbFrete.Text.Trim()), Convert.ToDecimal(tbDespachante.Text.Trim()), Convert.ToDecimal(tbTaxaComissoes.Text.Trim()), data, 14, data2, Convert.ToInt32(tbidDespContentor.Text));

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
                DateTime data = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime data2 = Convert.ToDateTime(dateTimePicker2.Text);
                despContentorTableAdapter.InserirQuery(Convert.ToDecimal(tbValorFatura.Text.Trim()), Convert.ToDecimal(tbFrete.Text.Trim()), Convert.ToDecimal(tbDespachante.Text.Trim()), Convert.ToDecimal(tbTaxaComissoes.Text.Trim()), data, 14, data2);

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

        private void FormDespContentor_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                despContentorTableAdapter.ApagarQuery(Convert.ToInt32(tbidDespContentor.Text.Trim()));
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
                dataGridView1.DataSource = despContentorTableAdapter.ProcurarQuery(Convert.ToInt32(tbidDespContentor.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
        }
    }
}
