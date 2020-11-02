using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void FrmMenu_Resize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            pnlTopo.BackColor = Color.FromArgb(230, 230, 230);
            pnlRight.BackColor = Color.FromArgb(150, 150, 150);
        }

        private void funcionáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastros.FrmFuncionarios form = new View.Cadastros.FrmFuncionarios();
            form.Show();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Cadastros.FrmCargo form = new View.Cadastros.FrmCargo();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            View.Produtos.FrmProdutos form = new View.Produtos.FrmProdutos();
            form.Show();
        }

        private void novoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View.Produtos.FrmProdutos form = new View.Produtos.FrmProdutos();
            form.Show();
        }
    }
}
