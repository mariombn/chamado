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
    public partial class ControleUsuario : Form
    {
        public ControleUsuario()
        {
            InitializeComponent();
        }

        private void btnCriarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService usuarioService = new UsuarioService();
                usuarioService.inserir(txtLogin.Text, txtSenha.Text, txtConfirmacaoSenha.Text);
                MessageBox.Show("Usuario criado com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
