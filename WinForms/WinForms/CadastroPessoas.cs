using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms.Repositorios;

namespace WinForms
{
    public partial class Cadastro : Form
    {

        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=theredfusca;Database=cadastro_pessoas";

        Pessoa pessoAtual = new Pessoa(nome: "", cpf: 0);
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio(connectionString);
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void idade_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pessoaRepositorio = new PessoaRepositorio(connectionString);
            pessoaRepositorio.Delete(txtNome.Text);
            LimparCampos();
            BuscarTodasPessoas(pessoaRepositorio);
        }

        private void txtCpf_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
        }

        private void BuscarTodasPessoas(PessoaRepositorio pessoaRepositorio)
        {
            var pessoas = pessoaRepositorio.BuscarPessoas();
            dgPessoa.DataSource = pessoas.ToList(); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            int cpf;

            if (int.TryParse(txtCpf.Text, out cpf))
            {
                var pessoa = new Pessoa(nome, cpf);
                var pessoaRepositorio = new PessoaRepositorio(connectionString);
                pessoaRepositorio.Insert(pessoa);
                LimparCampos();
                BuscarTodasPessoas(pessoaRepositorio);
            }
            else
            {
                MessageBox.Show("Por favor, insira um CPF válido (número inteiro).");
            }



        }

        private void dgPessoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;
            if (dgv == null)
                return;

            txtNome.Text = dgv.CurrentRow.Cells["nome"]?.Value?.ToString();
            txtCpf.Text = dgv.CurrentRow.Cells["cpf"]?.Value?.ToString();
            pessoAtual.Cpf = Convert.ToInt32(txtCpf.Text);
            pessoAtual.Nome = txtNome.Text;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            
            var pessoa = new Pessoa(txtNome.Text, Convert.ToInt32(txtCpf.Text));
            var pessoaRepositorio = new PessoaRepositorio(connectionString);
            pessoaRepositorio.Update(pessoa, pessoAtual);
            LimparCampos();
            BuscarTodasPessoas(pessoaRepositorio);
        }
    }
}
