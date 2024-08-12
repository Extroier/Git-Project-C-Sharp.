
namespace ProjetoMosquitoVelho
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnEventos = new System.Windows.Forms.Button();
            this.btnOrçamento = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnFornecedores = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEventos
            // 
            this.btnEventos.Location = new System.Drawing.Point(620, 58);
            this.btnEventos.Name = "btnEventos";
            this.btnEventos.Size = new System.Drawing.Size(168, 166);
            this.btnEventos.TabIndex = 3;
            this.btnEventos.Text = "&Eventos";
            this.btnEventos.UseVisualStyleBackColor = true;
            // 
            // btnOrçamento
            // 
            this.btnOrçamento.Location = new System.Drawing.Point(620, 242);
            this.btnOrçamento.Name = "btnOrçamento";
            this.btnOrçamento.Size = new System.Drawing.Size(168, 163);
            this.btnOrçamento.TabIndex = 5;
            this.btnOrçamento.Text = "&Orçamento";
            this.btnOrçamento.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(718, 420);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(70, 29);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.Location = new System.Drawing.Point(207, 242);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(168, 163);
            this.btnProdutos.TabIndex = 8;
            this.btnProdutos.Text = "&Produtos";
            this.btnProdutos.UseVisualStyleBackColor = true;
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(12, 242);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(168, 163);
            this.btnUsuario.TabIndex = 9;
            this.btnUsuario.Text = "&Usuário";
            this.btnUsuario.UseVisualStyleBackColor = true;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.Location = new System.Drawing.Point(12, 60);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(168, 163);
            this.btnFuncionarios.TabIndex = 10;
            this.btnFuncionarios.Text = "&Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = true;
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(207, 60);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(168, 163);
            this.btnTarefas.TabIndex = 11;
            this.btnTarefas.Text = "&Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(419, 60);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(168, 163);
            this.btnClientes.TabIndex = 12;
            this.btnClientes.Text = "&Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.Location = new System.Drawing.Point(419, 242);
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(168, 163);
            this.btnFornecedores.TabIndex = 13;
            this.btnFornecedores.Text = "&Fornecedores";
            this.btnFornecedores.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(708, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 25);
            this.button1.TabIndex = 14;
            this.button1.Text = "&Calculadora";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFornecedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnFuncionarios);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnProdutos);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnOrçamento);
            this.Controls.Add(this.btnEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnOrçamento;
        private System.Windows.Forms.Button btnEventos;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnFornecedores;
        private System.Windows.Forms.Button button1;
    }
}