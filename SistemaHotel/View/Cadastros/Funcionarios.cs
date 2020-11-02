using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotel.View.Cadastros
{
    public partial class FrmFuncionarios : Form
    {
        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            rbNome.Checked = true;

        }

        //Metodo de inicialização
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtCPF.Enabled = true;
            txtEndereco.Enabled = true;
            txtTelefone.Enabled = true;
            cbCargo.Enabled = true;
            txtNome.Focus();
        }

        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCPF.Enabled = false;
            txtEndereco.Enabled = false;
            txtTelefone.Enabled = false;
            cbCargo.Enabled = false;
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtCPF.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
            cbCargo.Text = "";
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarCPF.Enabled = false;
            txtBuscarNome.Enabled = true;

            txtBuscarCPF.Visible = false;
            txtBuscarNome.Visible = true;

            txtBuscarCPF.Text = "";
            txtBuscarNome.Text = "";
        }

        private void rbCPF_CheckedChanged(object sender, EventArgs e)
        {
            txtBuscarCPF.Enabled = true;
            txtBuscarNome.Enabled = false;

            txtBuscarCPF.Visible = true;
            txtBuscarNome.Visible = false;

            txtBuscarCPF.Text = "";
            txtBuscarNome.Text = "";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            btnSalvar.Enabled = true;
            btnNovo.Enabled = false;

            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }
            else if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }


            /*
                Codigo para o botão salvar 
            */


            MessageBox.Show("Registro Salvo com Sucesso!", "Dados salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnSalvar.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void grid_Click(object sender, EventArgs e)
        {
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.ToString().Trim() == "")
            {
                txtNome.Text = "";
                MessageBox.Show("Preencha o Nome!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }
            else if (txtCPF.Text == "   .   .   -")
            {
                MessageBox.Show("Preencha o CPF!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCPF.Focus(); //recebe o foco, "seleciona o campo"
                return;
            }

            /*
                Codigo para o botão editar
            */

            MessageBox.Show("Registro Editado com Sucesso!", "Dados alterados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnNovo.Enabled = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            limparCampos();
            desabilitarCampos();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                /* Registro é excluido! */


                /*----------------------*/

                MessageBox.Show("Registro Excluido com Sucesso!", "Registro excluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnNovo.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;

                txtNome.Text = "";
                txtNome.Enabled = false;
            }
        }
    }
}
