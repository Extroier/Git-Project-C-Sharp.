
namespace ProjetoMosquitoVelho
{
    partial class frmFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionarios));
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(239, 21);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(112, 34);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "&Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(456, 21);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(112, 34);
            this.btnPesquisar.TabIndex = 5;
            this.btnPesquisar.Text = "&Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(132, 21);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(112, 34);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(347, 21);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(112, 34);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "&Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(27, 21);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(112, 34);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAlterar);
            this.panel1.Controls.Add(this.btnVoltar);
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Location = new System.Drawing.Point(1, 382);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 69);
            this.panel1.TabIndex = 1;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(668, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(112, 34);
            this.btnVoltar.TabIndex = 7;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(560, 21);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 34);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // frmFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionarios";
            this.Text = "Sistema ABC-Funcionários :)";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnLimpar;
    }
}