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
    public partial class ChamadoDetalhes : Form
    {
        Main parnet = null;
        int id;
        string status;

        public ChamadoDetalhes(Main _parent, int id)
        {
            this.parnet = _parent;
            this.id = id;
            InitializeComponent();
        }

        private void ChamadoDetalhes_Load(object sender, EventArgs e)
        {
            try
            {
                ChamadoService chamadoService = new ChamadoService();
                UsuarioService usuarioService = new UsuarioService();
                txtTitulo.Enabled = false;
                txtDescricao.Enabled = false;

                var chamadoEntity = chamadoService.obterPorId(this.id);

                txtTitulo.Text = chamadoEntity.titulo;
                txtDescricao.Text = chamadoEntity.descricao;
                lblData.Text = chamadoEntity.criacaoData;
                lblHora.Text = chamadoEntity.criacaoHora;
                this.status = chamadoEntity.status;
                var userCriacao = usuarioService.obterPorId(chamadoEntity.criacaoUserId);

                lblCriacaoUser.Text = userCriacao.login;

                if (status != "aberto")
                {
                    var userAtendimento = usuarioService.obterPorId(chamadoEntity.userId);
                    lblUser.Text = userAtendimento.login;
                    btnAtender.Enabled = false;
                    if (status == "encerrado")
                    {
                        btnEncerrar.Enabled = false;
                    }
                }
                else
                {
                    btnEncerrar.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }

        private void btnAtender_Click(object sender, EventArgs e)
        {
            try
            {
                ChamadoService chamadoService = new ChamadoService();
                chamadoService.atendeChamado(this.id, this.parnet.GetUsuarioEntity().id);
                btnAtender.Enabled = false;
                btnEncerrar.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            try
            {
                ChamadoService chamadoService = new ChamadoService();
                chamadoService.fechaChamado(this.id);
                btnAtender.Enabled = false;
                btnEncerrar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}