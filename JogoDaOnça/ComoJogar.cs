using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaOnça
{
    public partial class ComoJogar : BaseForm
    {
        public ComoJogar()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Voltar();
        }
    }
}
