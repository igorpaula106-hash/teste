using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Academia
{
    public partial class Página_Cadastro1 : Form
    {
        DAO bd;

        public Página_Cadastro1()
        {
            InitializeComponent();
            bd = new DAO();
        }

        private void Página_de_Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void botão_cadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_nome.Text))
            {
                MessageBox.Show("Informe o nome do aluno.");
                textBox_nome.Focus();
                return;
            }

            string cpf = new string(maskedTextBox_CPF.Text.Where(char.IsDigit).ToArray());
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve ter 11 dígitos.");
                maskedTextBox_CPF.Focus();
                return;
            }

            Aluno aluno = new Aluno
            {
                Nome = textBox_nome.Text.Trim(),
                Cpf = cpf
            };

            this.Hide();
            using (Página_Cadastro2 pagina2 = new Página_Cadastro2(aluno, bd))
            {
                DialogResult resultado = pagina2.ShowDialog();

                if (resultado == DialogResult.OK)
                    LimparCampos();
            }
            this.Show();
        }//fim de botão_cadastro_Click

        private void LimparCampos()
        {
            textBox_nome.Clear();
            maskedTextBox_CPF.Clear();
            textBox_nome.Focus();
        }//fim de LimparCampos
    }//fim da classe
}//fim do projeto