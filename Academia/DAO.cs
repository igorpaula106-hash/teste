using MySql.Data.MySqlClient;//Importar os elementos do MySQL
using System;
using System.Windows.Forms;

namespace Academia
{
    public class DAO
    {
        public MySqlConnection conexao;//Armazenar os parâmetros de configuração com o BD
        public int[] codigo;
        public string[] cpf;
        public string[] nome;
        public string[] telefone;
        public int i;
        public int contador;

        public DAO()
        {
            this.conexao = new MySqlConnection("server=localhost;DataBase=academia;Uid=root;password=");
            try
            {
                this.conexao.Open();//Abrir a conexão com o banco
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro);
            }
        }//fim do construtor

        public string Cadastrar(string nome, decimal peso, string telefone, string cpf, DateTime dataNascimento, string sexo, decimal altura, string objetivo, int planoCodigo)
        {
            string inserir = "insert into aluno " +
                "(nome, peso, telefone, CPF, data_nascimento, sexo, altura, objetivo, plano_codigo) " +
                "values (@nome, @peso, @telefone, @cpf, @data, @sexo, @altura, @objetivo, @plano)";

            using (MySqlCommand sql = new MySqlCommand(inserir, conexao))
            {
                sql.Parameters.AddWithValue("@nome", nome);
                sql.Parameters.AddWithValue("@peso", peso);
                sql.Parameters.AddWithValue("@telefone", telefone);
                sql.Parameters.AddWithValue("@cpf", cpf);
                sql.Parameters.AddWithValue("@data", dataNascimento);
                sql.Parameters.AddWithValue("@sexo", sexo);
                sql.Parameters.AddWithValue("@altura", altura);
                sql.Parameters.AddWithValue("@objetivo", objetivo);
                sql.Parameters.AddWithValue("@plano", planoCodigo);

                return sql.ExecuteNonQuery() + " Cadastrado!";
            }
        }//fim do método cadastrar

        public void PreencherVetor()
        {
            string consultar = "select codigo, CPF, nome, telefone from aluno";

            using (MySqlCommand sql = new MySqlCommand(consultar, conexao))
            using (MySqlDataReader leitura = sql.ExecuteReader())
            {
                // Listas evitam ultrapassar o limite fixo de 100 alunos.
                var listaCodigo = new System.Collections.Generic.List<int>();
                var listaCpf = new System.Collections.Generic.List<string>();
                var listaNome = new System.Collections.Generic.List<string>();
                var listaTelefone = new System.Collections.Generic.List<string>();

                while (leitura.Read())
                {
                    listaCodigo.Add(Convert.ToInt32(leitura["codigo"]));
                    listaCpf.Add(leitura["CPF"].ToString());
                    listaNome.Add(leitura["nome"].ToString());
                    listaTelefone.Add(leitura["telefone"].ToString());
                }

                codigo = listaCodigo.ToArray();
                cpf = listaCpf.ToArray();
                nome = listaNome.ToArray();
                telefone = listaTelefone.ToArray();

                contador = codigo.Length;
                i = contador;
            }//Encerrar o comando DAO
        }//fim do PreencherVetor

        public int QuantidadeDeDados()
        {
            return contador;
        }//fim do QuantidadeDeDados

        public string Atualizar(int codigoAluno, string nomeCampo, string novoDado)
        {
            //Permite somente campos conhecidos.
            string[] camposPermitidos =
            {
                "nome", "peso", "telefone", "CPF",
                "data_nascimento", "sexo", "altura",
                "objetivo", "plano_codigo"
            };

            bool permitido = false;

            foreach (string campo in camposPermitidos)
            {
                if (string.Equals(
                    campo, nomeCampo,
                    StringComparison.OrdinalIgnoreCase))
                {
                    nomeCampo = campo;
                    permitido = true;
                    break;
                }//fim do if
            }

            if (!permitido)
                throw new ArgumentException("Campo inválido.");

            string query =
                $"update aluno set `{nomeCampo}` = @valor where codigo = @codigo";

            using (MySqlCommand sql =
                new MySqlCommand(query, conexao))
            {
                sql.Parameters.AddWithValue("@valor", novoDado);
                sql.Parameters.AddWithValue("@codigo", codigoAluno);

                return sql.ExecuteNonQuery() + " aluno(s) atualizado(s).";
            }//fim do if
        }//fim do Atualizar

        public string Excluir(int codigoAluno)
        {
            string query = "delete from aluno where codigo = @codigo";

            using (MySqlCommand sql = new MySqlCommand(query, conexao))
            {
                sql.Parameters.AddWithValue("@codigo", codigoAluno);

                return sql.ExecuteNonQuery() + " aluno(s) excluído(s).";
            }
        }//fim do Excluir
    }//fim da classe
}//fim do projeto