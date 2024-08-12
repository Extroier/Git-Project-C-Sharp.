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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //LimparCampos
        public void LimparCampos()
        {
            txtValor1.Clear();
            txtValor2.Clear();
            lblResposta.Text = "";
            rdbAdicionar.Checked = false;
            rdbSubtrair.Checked = false;
            rdbMultiplicar.Checked = false;
            rdbDividir.Checked = false;
            rdbPotencia.Checked = false;
            txtValor1.Focus();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Valor1, Valor2, resp=0;
            try
            {
               
                    Valor1 = Convert.ToDouble(txtValor1.Text);
                    Valor2 = Convert.ToDouble(txtValor2.Text);
                 //instânciar o objecto/classe usar o objecto sem modificar sua estrutura. Primeiro se criar variavel de mesmo tipo de objecto,variavel com mesmo nome da classe.
                 Operacoes variaveloperacoes = new Operacoes();
                 if (rdbAdicionar.Checked)
                    resp = Operacoes.somar(Valor1, Valor2);
                 if (rdbSubtrair.Checked)
                    resp = variaveloperacoes.menos(Valor1, Valor2);
                 if (rdbMultiplicar.Checked)
                    resp = variaveloperacoes.vezes(Valor1, Valor2);
                 if (rdbDividir.Checked)
                {
                    if (Valor2 == 0)
                    {
                        MessageBox.Show("Falha,divisão com 0 impossível", "SistemaABC Ensina",
                        MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button3);
                        //execultar metodo limpar
                        LimparCampos();
                    }
                    else
                    {
                        resp = variaveloperacoes.dividir(Valor1, Valor2);
                    }

                }

                if (rdbPotencia.Checked)
                    resp = variaveloperacoes.potencia(Valor1, Valor2);
                lblResposta.Text = resp.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor caro usuário,insira somente números",
              "SistemaABC Implora", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                LimparCampos();
            }


        }

    }
}
