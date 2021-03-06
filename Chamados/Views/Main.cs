﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chamados.Entitys;

namespace Chamados.Views
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;
        private UsuarioEntity usuario;

        public Main()
        {
            InitializeComponent();
        }

        public void SetUsuarioEntity(UsuarioEntity usuario)
        {
            this.usuario = usuario;
        }

        public UsuarioEntity GetUsuarioEntity()
        {
            return this.usuario;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel.Text = "Logado como: " + this.usuario.login;
            statusStrip.Refresh();

            if (this.GetUsuarioEntity().id != 1)
            {
                controleDeUsuáriosToolStripMenuItem.Enabled = false;
            }
        }

        private void mainMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            novoChamado novoChamado = new novoChamado(this);
            novoChamado.MdiParent = this;
            novoChamado.Show();
        }

        private void filaDeChamadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FilaDeChamados filaDeChamado = new FilaDeChamados(this);
            filaDeChamado.MdiParent = this;
            filaDeChamado.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            sobre sobre = new sobre();
            sobre.Show();
        }

        private void trocarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrocarSenha trocaSenha = new TrocarSenha(this);
            trocaSenha.MdiParent = this;
            trocaSenha.Show();
        }

        private void controleDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleUsuario controleUsuario = new ControleUsuario();
            controleUsuario.MdiParent = this;
            controleUsuario.Show();
        }

        private void meusChamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
