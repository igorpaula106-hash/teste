using MySql.Data.MySqlClient;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Academia
{
    public partial class Página_Cadastro2 : Form
    {
        private Aluno aluno;
        private DAO bd;

        public Página_Cadastro2(Aluno aluno, DAO bd)
        {
            InitializeComponent();
            this.aluno = aluno;
            this.bd = bd;
        }

        private void Página_Cadastro2_Load(object sender, EventArgs e)
        {
        }

        private void botão_cadastro2_Click(object sender, EventArgs e)
        {
            if (comboBox_sexo.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione o sexo.");
                return;
            }

            decimal peso;
            if (!decimal.TryParse(textBox_peso.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out peso))
            {
                MessageBox.Show("Peso inválido. Exemplo: 70,5");
                textBox_peso.Focus();
                return;
            }

            decimal altura;
            if (!decimal.TryParse(textBox_altura.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out altura))
            {
                MessageBox.Show("Altura inválida. Exemplo: 1,75");
                textBox_altura.Focus();
                return;
            }

            if (comboBox_plano.SelectedIndex < 0)
            {
                MessageBox.Show("Selecione um plano.");
                return;
            }

            // Completa o aluno com os dados desta página
            aluno.Telefone = maskedTextBox_telefone.Text.Trim();
            aluno.DataNascimento = dateTimePicker1.Value.Date;
            aluno.Sexo = comboBox_sexo.Text;
            aluno.Peso = peso;
            aluno.Altura = altura;
            aluno.Objetivo = textBox_objetivo.Text.Trim();
            aluno.PlanoCodigo = comboBox_plano.SelectedIndex + 1;

            try
            {
                string resultado = bd.Cadastrar(aluno.Nome, aluno.Peso, aluno.Telefone,
                                                aluno.Cpf, aluno.DataNascimento, aluno.Sexo,
                                                aluno.Altura, aluno.Objetivo, aluno.PlanoCodigo);
                MessageBox.Show(resultado);
                this.DialogResult = DialogResult.OK;
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Não foi possível cadastrar.\n\n" + erro.Message);
            }
        }//fim de botão_cadastro2_Click

        private void botão_voltar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }//fim de botão_voltar_Click
    }//fim da classe
}//fim do projeto