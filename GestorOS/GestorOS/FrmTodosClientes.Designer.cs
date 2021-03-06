﻿namespace GestorOS
{
    partial class FrmTodosClientes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodosClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lwClientes = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDOCUMENTO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCelular = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editarOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.lwClientes);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 444);
            this.panel1.TabIndex = 2;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(584, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(181, 32);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Adicionar novo - F1";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lwClientes
            // 
            this.lwClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwClientes.BackColor = System.Drawing.Color.SeaShell;
            this.lwClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderCliente,
            this.columnHeaderDOCUMENTO,
            this.columnHeaderCelular});
            this.lwClientes.ContextMenuStrip = this.contextMenuStrip1;
            this.lwClientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwClientes.FullRowSelect = true;
            this.lwClientes.GridLines = true;
            this.lwClientes.Location = new System.Drawing.Point(9, 51);
            this.lwClientes.Name = "lwClientes";
            this.lwClientes.Size = new System.Drawing.Size(756, 379);
            this.lwClientes.TabIndex = 13;
            this.lwClientes.UseCompatibleStateImageBehavior = false;
            this.lwClientes.View = System.Windows.Forms.View.Details;
            this.lwClientes.DoubleClick += new System.EventHandler(this.lwFuncionarios_DoubleClick);
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 64;
            // 
            // columnHeaderCliente
            // 
            this.columnHeaderCliente.Text = "Cliente";
            this.columnHeaderCliente.Width = 379;
            // 
            // columnHeaderDOCUMENTO
            // 
            this.columnHeaderDOCUMENTO.Text = "Documento";
            this.columnHeaderDOCUMENTO.Width = 163;
            // 
            // columnHeaderCelular
            // 
            this.columnHeaderCelular.Text = "Celular";
            this.columnHeaderCelular.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderCelular.Width = 117;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(569, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarOrdemDeServiçoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 28);
            // 
            // editarOrdemDeServiçoToolStripMenuItem
            // 
            this.editarOrdemDeServiçoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarOrdemDeServiçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarOrdemDeServiçoToolStripMenuItem.Image")));
            this.editarOrdemDeServiçoToolStripMenuItem.Name = "editarOrdemDeServiçoToolStripMenuItem";
            this.editarOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.editarOrdemDeServiçoToolStripMenuItem.Text = "Editar cliente";
            this.editarOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.editarOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // FrmTodosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmTodosClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de clientes";
            this.Load += new System.EventHandler(this.FrmTodosClientes_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTodosClientes_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lwClientes;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderCliente;
        private System.Windows.Forms.ColumnHeader columnHeaderDOCUMENTO;
        private System.Windows.Forms.ColumnHeader columnHeaderCelular;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarOrdemDeServiçoToolStripMenuItem;
    }
}