using Academia.Academia;
using System.Windows.Forms;

namespace Academia
{
    public partial class contatos : Form
    {
        public contatos()
        {
            InitializeComponent();

            //"mãozinha" ao passar o mouse pelo menu
            página_inicial.Cursor = Cursors.Hand;
            planos.Cursor = Cursors.Hand;
            produtos_serviços.Cursor = Cursors.Hand;
            contato.Cursor = Cursors.Hand;
        }

        private void contatos_Load(object sender, System.EventArgs e)
        {

        }

        private void página_inicial_Click(object sender, System.EventArgs e)
        {
            Navegacao.IrPara<Página_1>(this);
        }

        private void planos_Click(object sender, System.EventArgs e)
        {
            Navegacao.IrPara<Página_2>(this);
        }

        private void produtos_serviços_Click(object sender, System.EventArgs e)
        {
            Navegacao.IrPara<Página_3>(this);
        }

        private void contato_Click(object sender, System.EventArgs e)
        {
            Navegacao.IrPara<contatos>(this);//já está aqui, então não faz nada
        }
    }
}
