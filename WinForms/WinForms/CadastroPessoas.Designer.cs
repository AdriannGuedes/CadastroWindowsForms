namespace WinForms
{
    partial class Cadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            this.Nome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.idade = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.dgPessoa = new System.Windows.Forms.DataGridView();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCpf = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).BeginInit();
            this.SuspendLayout();
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            this.Nome.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNome
            // 
            resources.ApplyResources(this.txtNome, "txtNome");
            this.txtNome.Name = "txtNome";
            // 
            // idade
            // 
            resources.ApplyResources(this.idade, "idade");
            this.idade.Name = "idade";
            this.idade.Click += new System.EventHandler(this.idade_Click);
            // 
            // btnAdicionar
            // 
            resources.ApplyResources(this.btnAdicionar, "btnAdicionar");
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // dgPessoa
            // 
            this.dgPessoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgPessoa, "dgPessoa");
            this.dgPessoa.Name = "dgPessoa";
            this.dgPessoa.RowTemplate.Height = 28;
            this.dgPessoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPessoa_CellClick);
            // 
            // btnEditar
            // 
            resources.ApplyResources(this.btnEditar, "btnEditar");
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnDeletar
            // 
            resources.ApplyResources(this.btnDeletar, "btnDeletar");
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.button3_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // txtCpf
            // 
            resources.ApplyResources(this.txtCpf, "txtCpf");
            this.txtCpf.Name = "txtCpf";
            // 
            // Cadastro
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.dgPessoa);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.idade);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Nome);
            this.Name = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPessoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label idade;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgPessoa;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtCpf;
    }
}

