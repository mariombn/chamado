﻿namespace Chamados.Views
{
    partial class FilaDeChamados
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
            this.gridChamados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hora_criacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridChamados)).BeginInit();
            this.SuspendLayout();
            // 
            // gridChamados
            // 
            this.gridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridChamados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.data_criacao,
            this.hora_criacao,
            this.status});
            this.gridChamados.Location = new System.Drawing.Point(12, 12);
            this.gridChamados.Name = "gridChamados";
            this.gridChamados.Size = new System.Drawing.Size(657, 262);
            this.gridChamados.TabIndex = 0;
            this.gridChamados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridChamados_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Titulo";
            this.titulo.Name = "titulo";
            // 
            // data_criacao
            // 
            this.data_criacao.HeaderText = "Data";
            this.data_criacao.Name = "data_criacao";
            // 
            // hora_criacao
            // 
            this.hora_criacao.HeaderText = "Hora";
            this.hora_criacao.Name = "hora_criacao";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // FilaDeChamados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 336);
            this.Controls.Add(this.gridChamados);
            this.Name = "FilaDeChamados";
            this.Text = "Fila de Chamados";
            this.Load += new System.EventHandler(this.FilaDeChamados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridChamados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridChamados;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn hora_criacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}