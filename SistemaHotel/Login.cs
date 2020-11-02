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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            pnlLogin.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);
            

            //Alterando a cor atraves do padrão RGB
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 114, 160);

            pnlLogin.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ChamarLogin();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }

        private void ChamarLogin()
        {
            if (txtUsuario.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo de Usuário", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }
            else if (txtSenha.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo de Senha", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }

            //----------------------------
            //CODIGO DE VALIDAÇÃO DO LOGIN
            //----------------------------

            FrmMenu form = new FrmMenu(); //Inicializa o formulario de menu
            //this.Hide(); //Fecha o form atual
            Limpar();
            txtUsuario.Focus();

            form.Show(); //Mostra o form

        }


        private void Limpar()
        {
            txtUsuario.Text = "";
            txtSenha.Text = "";
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            pnlLogin.Location = new Point(this.Width / 2 - 166, this.Height / 2 - 170);

        }
    }
}
