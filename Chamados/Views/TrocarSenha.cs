using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chamados.Services;

namespace Chamados.Views
{
    public partial class TrocarSenha : Form
    {
        private Main parent;

        public TrocarSenha(Main _parent)
        {
            this.parent = _parent;
            InitializeComponent();
        }

        private void TrocarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginService loginService = new LoginService();
                loginService.efetuarLogin(this.parent.GetUsuarioEntity().login, txtSenhaAtual.Text);
                txtNovaSenha.Enabled = true;
                txtConfirmacaoSenha.Enabled = true;
                btnTrocar.Enabled = true;
                txtSenhaAtual.Enabled = false;
                btnValidar.Enabled = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTrocar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService usuarioService = new UsuarioService();
                usuarioService.trocaSenha(this.parent.GetUsuarioEntity().id, txtNovaSenha.Text, txtConfirmacaoSenha.Text);
                MessageBox.Show("Senha Alterada com sucesso!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
