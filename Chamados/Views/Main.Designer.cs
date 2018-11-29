namespace Chamados.Views
{
    partial class Main
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.chamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chamadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meusChamadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filaDeChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minhaFIlaDeChamadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurançaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleDeUsuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.trocarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 648);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel.Text = "Usuário Logado: XXXXX";
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chamadosToolStripMenuItem,
            this.chamadosToolStripMenuItem1,
            this.segurançaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1095, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            this.mainMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mainMenu_ItemClicked);
            // 
            // chamadosToolStripMenuItem
            // 
            this.chamadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.chamadosToolStripMenuItem.Name = "chamadosToolStripMenuItem";
            this.chamadosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.chamadosToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // chamadosToolStripMenuItem1
            // 
            this.chamadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirChamadoToolStripMenuItem,
            this.meusChamadosToolStripMenuItem,
            this.filaDeChamadoToolStripMenuItem,
            this.minhaFIlaDeChamadoToolStripMenuItem});
            this.chamadosToolStripMenuItem1.Name = "chamadosToolStripMenuItem1";
            this.chamadosToolStripMenuItem1.Size = new System.Drawing.Size(76, 20);
            this.chamadosToolStripMenuItem1.Text = "Chamados";
            // 
            // abrirChamadoToolStripMenuItem
            // 
            this.abrirChamadoToolStripMenuItem.Name = "abrirChamadoToolStripMenuItem";
            this.abrirChamadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.abrirChamadoToolStripMenuItem.Text = "Novo Chamado";
            this.abrirChamadoToolStripMenuItem.Click += new System.EventHandler(this.abrirChamadoToolStripMenuItem_Click);
            // 
            // meusChamadosToolStripMenuItem
            // 
            this.meusChamadosToolStripMenuItem.Name = "meusChamadosToolStripMenuItem";
            this.meusChamadosToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.meusChamadosToolStripMenuItem.Text = "Meus Chamados";
            // 
            // filaDeChamadoToolStripMenuItem
            // 
            this.filaDeChamadoToolStripMenuItem.Name = "filaDeChamadoToolStripMenuItem";
            this.filaDeChamadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.filaDeChamadoToolStripMenuItem.Text = "Fila de Chamado";
            this.filaDeChamadoToolStripMenuItem.Click += new System.EventHandler(this.filaDeChamadoToolStripMenuItem_Click);
            // 
            // minhaFIlaDeChamadoToolStripMenuItem
            // 
            this.minhaFIlaDeChamadoToolStripMenuItem.Name = "minhaFIlaDeChamadoToolStripMenuItem";
            this.minhaFIlaDeChamadoToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.minhaFIlaDeChamadoToolStripMenuItem.Text = "Minha fila de Chamado";
            // 
            // segurançaToolStripMenuItem
            // 
            this.segurançaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controleDeUsuáriosToolStripMenuItem,
            this.trocarSenhaToolStripMenuItem});
            this.segurançaToolStripMenuItem.Name = "segurançaToolStripMenuItem";
            this.segurançaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.segurançaToolStripMenuItem.Text = "Segurança";
            // 
            // controleDeUsuáriosToolStripMenuItem
            // 
            this.controleDeUsuáriosToolStripMenuItem.Name = "controleDeUsuáriosToolStripMenuItem";
            this.controleDeUsuáriosToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.controleDeUsuáriosToolStripMenuItem.Text = "Controle de Usuários";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem1});
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.sobreToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem1
            // 
            this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
            this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem1.Text = "Sobre";
            this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
            // 
            // trocarSenhaToolStripMenuItem
            // 
            this.trocarSenhaToolStripMenuItem.Name = "trocarSenhaToolStripMenuItem";
            this.trocarSenhaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.trocarSenhaToolStripMenuItem.Text = "Trocar Senha";
            this.trocarSenhaToolStripMenuItem.Click += new System.EventHandler(this.trocarSenhaToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 670);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Chamados PIN 2018";
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chamadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abrirChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurançaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meusChamadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filaDeChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minhaFIlaDeChamadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleDeUsuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarSenhaToolStripMenuItem;
    }
}



