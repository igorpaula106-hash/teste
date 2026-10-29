using Academia.Academia;
using System.Windows.Forms;

namespace Academia
{
    public partial class Página_3 : Form
    {
        public Página_3()
        {
            InitializeComponent();

            //"mãozinha" ao passar o mouse pelo menu
            página_inicial.Cursor = Cursors.Hand;
            planos.Cursor = Cursors.Hand;
            produtos_serviços.Cursor = Cursors.Hand;
            contato.Cursor = Cursors.Hand;
        }

        private void Página_3_Load(object sender, System.EventArgs e)
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
            Navegacao.IrPara<Página_3>(this);//já está aqui, então não faz nada
        }

        private void contato_Click(object sender, System.EventArgs e)
        {
            Navegacao.IrPara<contatos>(this);
        }
    }
}
