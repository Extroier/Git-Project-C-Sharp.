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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            frmLogin open = new frmLogin();
            open.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCalculadora open = new frmCalculadora();
            open.Show();
            this.Hide();
        }
    }
}
