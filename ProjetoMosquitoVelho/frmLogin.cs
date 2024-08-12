using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMosquitoVelho
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            /*
            this.Close();*/
            Application.Exit();                                           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.Equals("LORDE DO MUNDO") && txtSenha.Text.Equals("majestade")) 
            {
                frmMenuPrincipal open = new frmMenuPrincipal();
                open.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido");
                limparCampos();
            }
        }
        public void limparCampos()
        {
            txtUser.Clear();
            txtSenha.Clear();
            txtUser.Focus();

        }

        private void PctImagem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Self Destruction Mode Activated.");
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
                    }
            if (e.KeyCode == Keys.Delete)
            {
                Application.Exit();
            }

        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEntrar.Focus();
            }
        }
    }
}
