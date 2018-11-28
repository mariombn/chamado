using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chamados.Views;
using Chamados.Services;

namespace Chamados
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginService loginService = new LoginService();
                var usuario = loginService.efetuarLogin(txtLogin.Text, txtSenha.Text);

                if (usuario.id > 0)
                {
                    Main frmMain = new Main();
                    frmMain.SetUsuarioEntity(usuario);
                    frmMain.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
    }
}
