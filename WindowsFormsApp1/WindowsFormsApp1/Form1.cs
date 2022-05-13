using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmDados : Form
    {
        public FrmDados()
        {
            InitializeComponent();
        }

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no txt");
        }

        private void txtBoleano_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no txt");
        }

        private void txtTexto_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no txt");
        }

        private void lblDecimal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicou no Lbl");
        }
    }
}
