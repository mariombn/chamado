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
using Chamados.Entitys;


namespace Chamados.Views
{
    public partial class novoChamado : Form
    {
        private Main parent = null;

        public novoChamado(Main _parent)
        {
            this.parent = _parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool retorno = false;
            try
            {
                ChamadoService chamadoService = new ChamadoService();
                UsuarioEntity usuario = this.parent.GetUsuarioEntity();

                retorno = chamadoService.criarChamado(txtTitulo.Text, txtDescricao.Text, usuario.id);
                MessageBox.Show("Chamado aberto com Sucesso");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void novoChamado_Load(object sender, EventArgs e)
        {

        }
    }
}
