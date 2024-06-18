using Dapper;
using Npgsql;
using System;
using System.Collections.Generic;

namespace WinForms.Repositorios
{
    public class PessoaRepositorio
    {
        private readonly string connectionString;

        public PessoaRepositorio(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Insert(Pessoa pessoa)
        {
            using (var conexao = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    conexao.Execute("INSERT INTO cadastro (nome, cpf) VALUES(@nome, @cpf);",
                        new
                        {
                            nome = pessoa.Nome,
                            cpf = pessoa.Cpf
                        });
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao inserir pessoa no banco de dados", ex);
                }
            }
        }

        public void Update(Pessoa pessoa, Pessoa pessoa1)
        {
            
            using (var conexao = new NpgsqlConnection(connectionString))
            {
                try
                {

                    conexao.Open();
                    conexao.Execute("UPDATE cadastro SET nome = @nome, cpf = @cpfNovo WHERE cpf = @cpfAntigo;",
    new
    {
                     nome = pessoa.Nome,
                     cpfNovo = pessoa.Cpf, // novo valor do CPF
                     cpfAntigo = pessoa1.Cpf  // valor antigo do CPF para identificar o registro
    });

                    /* conexao.Execute("UPDATE cadastro SET nome = @nome, cpf = @cpf WHERE cpf = @cpf;", 
                         pessoa

                     );*/



                }
                catch (Exception ex)
                {
                  

                    throw new Exception($"Erro ao atualizar pessoa com nome {pessoa.Nome} no banco de dados", ex);
                }
            }
        }

       

        public void Delete(string nome)
        {
            using (var conexao = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    conexao.Execute("DELETE FROM cadastro WHERE nome = @nome;",
                        new
                        {
                            nome
                        });
                 
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao deletar pessoa com nome {nome} no banco de dados", ex);
                }
            }
        }

        public IEnumerable<Pessoa> BuscarPessoas()
        {
            using (var conexao = new NpgsqlConnection(connectionString))
            {
                try
                {
                    conexao.Open();
                    var sql = "SELECT nome, cpf FROM cadastro";
                    return conexao.Query<Pessoa>(sql);
                }
                catch (Exception ex)
                {
                    throw new Exception($"Erro ao buscar pessoas no banco de dados", ex);
                }
            }
        }
    }
}