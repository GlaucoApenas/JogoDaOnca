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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }
        public void Voltar()
        {
            var principal = new Principal();
            this.Hide();
            principal.ShowDialog();
            this.Close();
        }
        public void Sair()
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Sair?", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
