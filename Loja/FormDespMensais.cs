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
    public partial class FormDespMensais : Form
    {
        DataSet1TableAdapters.DespMensaisTableAdapter despMensaisTableAdapter = new DataSet1TableAdapters.DespMensaisTableAdapter();

        public FormDespMensais()
        {
            InitializeComponent();
        }

        void Reset()
        {
            dataGridView1.DataSource = despMensaisTableAdapter.Reset();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (rbSim.Checked)
            {
                String Pago = "SIM";
                Int32 Moeda = 14;
                try
                {
                    despMensaisTableAdapter.InserirQuery(Convert.ToDateTime(dateTimePicker1.Text),tbDescricao.Text.Trim(), Convert.ToDecimal(tbDespesa.Text.Trim()), 
                                                         Convert.ToInt32(tbFuncionario.Text), Convert.ToInt32(tbBens.Text), Convert.ToDecimal(tbImRelativo.Text), Pago, Moeda);
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
            else 
            {
                String Pago = "NAO";
                Int32 Moeda = 14;
                try
                {
                    despMensaisTableAdapter.InserirQuery(Convert.ToDateTime(dateTimePicker1.Text), tbDescricao.Text.Trim(), Convert.ToDecimal(tbDespesa.Text.Trim()),
                                                         Convert.ToInt32(tbFuncionario.Text), Convert.ToInt32(tbBens.Text), Convert.ToDecimal(tbImRelativo.Text), Pago, Moeda);

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
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (rbSim.Checked)
            {
                String Pago = "SIM";
                Int32 Moeda = 14;
                try
                {
                    despMensaisTableAdapter.EditarQuery(Convert.ToDateTime(dateTimePicker1.Text), tbDescricao.Text.Trim(), Convert.ToDecimal(tbDespesa.Text.Trim()),
                                                        Convert.ToInt32(tbFuncionario.Text), Convert.ToInt32(tbBens.Text), Convert.ToDecimal(tbImRelativo.Text), 
                                                        Pago, Moeda, Convert.ToInt32(tbidDespMensais.Text));
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
            else
            {
                String Pago = "NAO";
                Int32 Moeda = 14;
                try
                {
                    despMensaisTableAdapter.EditarQuery(Convert.ToDateTime(dateTimePicker1.Text), tbDescricao.Text.Trim(), Convert.ToDecimal(tbDespesa.Text.Trim()),
                                                        Convert.ToInt32(tbFuncionario.Text), Convert.ToInt32(tbBens.Text), Convert.ToDecimal(tbImRelativo.Text),
                                                       Pago, Moeda, Convert.ToInt32(tbidDespMensais.Text));
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
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void FormDespMensais_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                despMensaisTableAdapter.ApagarQuery(Convert.ToInt32(tbidDespMensais.Text));
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
                dataGridView1.DataSource = despMensaisTableAdapter.ProcurarQuery(Convert.ToInt32(tbidDespMensais.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Inserir todos os campos!");
            }
        }
    }
}
