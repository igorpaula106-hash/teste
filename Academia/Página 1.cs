using Academia.Academia;
using System;
using System.Windows.Forms;

namespace Academia
{
    public partial class Página_1 : Form
    {

        DAO bd;

        public Página_1()
        {
            InitializeComponent();
            bd = new DAO();

            Navegacao.Registrar(this);//só nesta página, que é a primeira a abrir

            // "mãozinha" ao passar o mouse pelo menu
            página_inicial.Cursor = Cursors.Hand;
            planos.Cursor = Cursors.Hand;
            produtos_serviços.Cursor = Cursors.Hand;
            contato.Cursor = Cursors.Hand;
        }

        private void Página_1_Load(object sender, EventArgs e)
        {

        }

        private void página_inicial_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_1>(this);//já está aqui, então não faz nada
        }

        private void planos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_2>(this);
        }

        private void produtos_serviços_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_3>(this);
        }

        private void contato_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<contatos>(this);
        }

        private void cadastro_aluno_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Cadastro1>(this);
        }

        private void login_aluno_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_Login>(this);
        }
    }//fim da classe
}//fim do projeto
