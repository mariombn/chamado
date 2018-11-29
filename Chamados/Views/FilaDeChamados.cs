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
    public partial class FilaDeChamados : Form
    {
        private Main parent = null;

        public FilaDeChamados(Main _parent)
        {
            this.parent = _parent;
            InitializeComponent();
        }

        private void FilaDeChamados_Load(object sender, EventArgs e)
        {
            this.carregarDados();
        }

        private void gridChamados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idChamado = Int32.Parse(gridChamados[0, e.RowIndex].Value.ToString());
                ChamadoDetalhes frmChamadoDetalhe = new ChamadoDetalhes(this.parent, idChamado);
                frmChamadoDetalhe.MdiParent = this.parent;
                frmChamadoDetalhe.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro!");
            }
        }

        private void btnAtualizarLista_Click(object sender, EventArgs e)
        {
            gridChamados.Rows.Clear();
            this.carregarDados();
        }

        private void carregarDados()
        {
            try
            {
                ChamadoService chamadoService = new ChamadoService();
                UsuarioService usuarioService = new UsuarioService();
                List<ChamadoEntity> chamados = chamadoService.listarTodos();

                foreach (ChamadoEntity chamado in chamados)
                {
                    DataGridViewRow row = (DataGridViewRow)gridChamados.Rows[0].Clone();
                    row.Cells[0].Value = chamado.id.ToString();
                    row.Cells[1].Value = chamado.titulo;
                    row.Cells[2].Value = chamado.criacaoData;
                    row.Cells[3].Value = chamado.criacaoHora;
                    row.Cells[4].Value = chamado.status;
                    row.Cells[5].Value = usuarioService.obterPorId(chamado.criacaoUserId).login;
                    if (chamado.userId != 0)
                    {
                        row.Cells[6].Value = usuarioService.obterPorId(chamado.userId).login;
                    }
                    else
                    {
                        row.Cells[6].Value = "SEM ATENDIMENTO";
                    }
                    gridChamados.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
