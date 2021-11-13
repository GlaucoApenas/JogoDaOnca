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
    public partial class Principal : BaseForm
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            var jogo = new Jogo();
            this.Hide();
            jogo.ShowDialog();
            this.Close();
        }

        private void btnComoJogar_Click(object sender, EventArgs e)
        {
            var comojogar = new ComoJogar();
            this.Hide();    
            comojogar.ShowDialog();
            this.Close();
        }

        private void btnQuemSomos_Click(object sender, EventArgs e)
        {
            var quemSomos = new QuemSomos();
            this.Hide();
            quemSomos.ShowDialog();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
    }
}
