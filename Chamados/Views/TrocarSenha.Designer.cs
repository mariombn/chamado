namespace Chamados.Views
{
    partial class TrocarSenha
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSenhaAtual = new System.Windows.Forms.TextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.txtConfirmacaoSenha = new System.Windows.Forms.TextBox();
            this.btnTrocar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Senha Atual:";
            // 
            // txtSenhaAtual
            // 
            this.txtSenhaAtual.Location = new System.Drawing.Point(86, 23);
            this.txtSenhaAtual.Name = "txtSenhaAtual";
            this.txtSenhaAtual.PasswordChar = '*';
            this.txtSenhaAtual.Size = new System.Drawing.Size(100, 20);
            this.txtSenhaAtual.TabIndex = 1;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(201, 21);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirmação:";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Enabled = false;
            this.txtNovaSenha.Location = new System.Drawing.Point(86, 69);
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.PasswordChar = '*';
            this.txtNovaSenha.Size = new System.Drawing.Size(100, 20);
            this.txtNovaSenha.TabIndex = 5;
            // 
            // txtConfirmacaoSenha
            // 
            this.txtConfirmacaoSenha.Enabled = false;
            this.txtConfirmacaoSenha.Location = new System.Drawing.Point(86, 95);
            this.txtConfirmacaoSenha.Name = "txtConfirmacaoSenha";
            this.txtConfirmacaoSenha.PasswordChar = '*';
            this.txtConfirmacaoSenha.Size = new System.Drawing.Size(100, 20);
            this.txtConfirmacaoSenha.TabIndex = 6;
            // 
            // btnTrocar
            // 
            this.btnTrocar.Enabled = false;
            this.btnTrocar.Location = new System.Drawing.Point(201, 93);
            this.btnTrocar.Name = "btnTrocar";
            this.btnTrocar.Size = new System.Drawing.Size(75, 23);
            this.btnTrocar.TabIndex = 7;
            this.btnTrocar.Text = "Trocar Senha";
            this.btnTrocar.UseVisualStyleBackColor = true;
            this.btnTrocar.Click += new System.EventHandler(this.btnTrocar_Click);
            // 
            // TrocarSenha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 134);
            this.Controls.Add(this.btnTrocar);
            this.Controls.Add(this.txtConfirmacaoSenha);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.txtSenhaAtual);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "TrocarSenha";
            this.Text = "Trocar Senha";
            this.Load += new System.EventHandler(this.TrocarSenha_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSenhaAtual;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.TextBox txtConfirmacaoSenha;
        private System.Windows.Forms.Button btnTrocar;
    }
}