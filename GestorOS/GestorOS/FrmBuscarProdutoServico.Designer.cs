namespace GestorOS
{
    partial class FrmBuscarProdutoServico
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lwProdutosServicos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDescricao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lwProdutosServicos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 444);
            this.panel1.TabIndex = 0;
            // 
            // lwProdutosServicos
            // 
            this.lwProdutosServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwProdutosServicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwProdutosServicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderDescricao,
            this.columnHeaderTipo,
            this.columnHeaderValorUnitario});
            this.lwProdutosServicos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwProdutosServicos.FullRowSelect = true;
            this.lwProdutosServicos.GridLines = true;
            this.lwProdutosServicos.Location = new System.Drawing.Point(9, 51);
            this.lwProdutosServicos.Name = "lwProdutosServicos";
            this.lwProdutosServicos.Size = new System.Drawing.Size(756, 379);
            this.lwProdutosServicos.TabIndex = 13;
            this.lwProdutosServicos.UseCompatibleStateImageBehavior = false;
            this.lwProdutosServicos.View = System.Windows.Forms.View.Details;
            this.lwProdutosServicos.DoubleClick += new System.EventHandler(this.lwProdutosServicos_DoubleClick);
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 64;
            // 
            // columnHeaderDescricao
            // 
            this.columnHeaderDescricao.Text = "Produto/Serviço";
            this.columnHeaderDescricao.Width = 379;
            // 
            // columnHeaderTipo
            // 
            this.columnHeaderTipo.Text = "Tipo";
            this.columnHeaderTipo.Width = 163;
            // 
            // columnHeaderValorUnitario
            // 
            this.columnHeaderValorUnitario.Text = "Valor";
            this.columnHeaderValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValorUnitario.Width = 117;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(756, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FrmBuscarProdutoServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmBuscarProdutoServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de produtos e serviços";
            this.Load += new System.EventHandler(this.FrmBuscarProdutoServico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBuscarProdutoServico_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ListView lwProdutosServicos;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderDescricao;
        private System.Windows.Forms.ColumnHeader columnHeaderTipo;
        private System.Windows.Forms.ColumnHeader columnHeaderValorUnitario;
    }
}