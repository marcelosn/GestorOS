namespace GestorOS
{
    partial class FrmTodosServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodosServicos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lwServicos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderComissao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValorComiss = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Controls.Add(this.lwServicos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 444);
            this.panel1.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(726, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(181, 32);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Adicionar novo - F1";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lwServicos
            // 
            this.lwServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwServicos.BackColor = System.Drawing.Color.SeaShell;
            this.lwServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderServico,
            this.columnHeaderUnidade,
            this.columnHeaderValor,
            this.columnHeaderComissao,
            this.columnHeaderValorComiss});
            this.lwServicos.ContextMenuStrip = this.contextMenuStrip1;
            this.lwServicos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwServicos.FullRowSelect = true;
            this.lwServicos.GridLines = true;
            this.lwServicos.HideSelection = false;
            this.lwServicos.Location = new System.Drawing.Point(9, 51);
            this.lwServicos.Name = "lwServicos";
            this.lwServicos.Size = new System.Drawing.Size(898, 379);
            this.lwServicos.TabIndex = 13;
            this.lwServicos.UseCompatibleStateImageBehavior = false;
            this.lwServicos.View = System.Windows.Forms.View.Details;
            this.lwServicos.DoubleClick += new System.EventHandler(this.lwServicos_DoubleClick);
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 64;
            // 
            // columnHeaderServico
            // 
            this.columnHeaderServico.Text = "Serviço";
            this.columnHeaderServico.Width = 371;
            // 
            // columnHeaderUnidade
            // 
            this.columnHeaderUnidade.Text = "Unidade";
            this.columnHeaderUnidade.Width = 110;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValor.Width = 100;
            // 
            // columnHeaderComissao
            // 
            this.columnHeaderComissao.Text = "% Comissão";
            this.columnHeaderComissao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderComissao.Width = 100;
            // 
            // columnHeaderValorComiss
            // 
            this.columnHeaderValorComiss.Text = "Valor Comissão";
            this.columnHeaderValorComiss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValorComiss.Width = 120;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(711, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarOrdemDeServiçoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 50);
            // 
            // editarOrdemDeServiçoToolStripMenuItem
            // 
            this.editarOrdemDeServiçoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarOrdemDeServiçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarOrdemDeServiçoToolStripMenuItem.Image")));
            this.editarOrdemDeServiçoToolStripMenuItem.Name = "editarOrdemDeServiçoToolStripMenuItem";
            this.editarOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.editarOrdemDeServiçoToolStripMenuItem.Text = "Editar serviço";
            this.editarOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.editarOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // FrmTodosServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(942, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmTodosServicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de serviços";
            this.Load += new System.EventHandler(this.FrmTodosServicos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTodosServicos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lwServicos;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderServico;
        private System.Windows.Forms.ColumnHeader columnHeaderUnidade;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.ColumnHeader columnHeaderComissao;
        private System.Windows.Forms.ColumnHeader columnHeaderValorComiss;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editarOrdemDeServiçoToolStripMenuItem;
    }
}