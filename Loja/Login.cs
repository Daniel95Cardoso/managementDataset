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

namespace Loja
{
    public partial class Login : Form
    {
        DataSet1TableAdapters.FuncionarioTableAdapter funcionarioTableAdapter = new DataSet1TableAdapters.FuncionarioTableAdapter();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnnEntrar_Click(object sender, EventArgs e)
        {
            try 
            {
                String useradmin = "admin";
                String passadmin = "adminleveleve";
                String uservisita = "visita";
                String passvisita = "visita";
                if (Convert.ToString(tbUser.Text) == useradmin && Convert.ToString(tbPassword.Text) == passadmin && Validacao() == true)
                {
                    PainelAdmin painelAdmin = new PainelAdmin();
                    painelAdmin.Show();
                    Visible = false;

                }
                else if (Convert.ToString(tbUser.Text) == uservisita && Convert.ToString(tbPassword.Text) == passvisita && Validacao() == true) 
                {
                    FormAdminDashBVisita formAdminDashBVisita = new FormAdminDashBVisita();
                    formAdminDashBVisita.Show();
                    Visible = false;
                }
                else 
                {
                    MessageBox.Show("User ou Pass Incorretos!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Invalido");
            }
        }


        private bool Validacao()
        {
            if (string.IsNullOrWhiteSpace(tbUser.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)) 
            {
                MessageBox.Show("Nome de utilizador ou password estão em branco!!");
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
