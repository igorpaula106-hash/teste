using Academia.Academia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Página_2 : Form
    {
        public Página_2()
        {
            InitializeComponent();

            //"mãozinha" ao passar o mouse pelo menu
            página_inicial.Cursor = Cursors.Hand;
            planos.Cursor = Cursors.Hand;
            produtos_serviços.Cursor = Cursors.Hand;
            contato.Cursor = Cursors.Hand;
        }

        private void Página_2_Load(object sender, EventArgs e)
        {
            
        }

        private void página_inicial_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_1>(this);
        }

        private void planos_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_2>(this);//já está aqui, então não faz nada
        }

        private void produtos_serviços_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<Página_3>(this);
        }

        private void contato_Click(object sender, EventArgs e)
        {
            Navegacao.IrPara<contatos>(this);
        }
    }
}
