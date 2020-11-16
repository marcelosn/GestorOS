namespace GestorOS
{
    partial class FrmTodosProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodosProdutos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lwProdutos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.columnHeaderPrecoVenda = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPrecoCusto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQtdeMinima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQtdeMaxima = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQtdeEstoque = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderUnidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.lwProdutos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1128, 444);
            this.panel1.TabIndex = 3;
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(936, 10);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(181, 32);
            this.btnNovo.TabIndex = 14;
            this.btnNovo.Text = "Adicionar novo - F1";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // lwProdutos
            // 
            this.lwProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwProdutos.BackColor = System.Drawing.Color.SeaShell;
            this.lwProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwProdutos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderProduto,
            this.columnHeaderUnidade,
            this.columnHeaderPrecoVenda,
            this.columnHeaderPrecoCusto,
            this.columnHeaderQtdeMinima,
            this.columnHeaderQtdeMaxima,
            this.columnHeaderQtdeEstoque});
            this.lwProdutos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwProdutos.FullRowSelect = true;
            this.lwProdutos.GridLines = true;
            this.lwProdutos.Location = new System.Drawing.Point(9, 51);
            this.lwProdutos.Name = "lwProdutos";
            this.lwProdutos.Size = new System.Drawing.Size(1108, 379);
            this.lwProdutos.TabIndex = 13;
            this.lwProdutos.UseCompatibleStateImageBehavior = false;
            this.lwProdutos.View = System.Windows.Forms.View.Details;
            this.lwProdutos.DoubleClick += new System.EventHandler(this.lwProdutos_DoubleClick);
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 64;
            // 
            // columnHeaderProduto
            // 
            this.columnHeaderProduto.Text = "Produto";
            this.columnHeaderProduto.Width = 379;
            // 
            // txtBuscar
            // 
            this.txtBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 9);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(921, 33);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // columnHeaderPrecoVenda
            // 
            this.columnHeaderPrecoVenda.Text = "Preço Venda";
            this.columnHeaderPrecoVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderPrecoVenda.Width = 100;
            // 
            // columnHeaderPrecoCusto
            // 
            this.columnHeaderPrecoCusto.Text = "Preço Custo";
            this.columnHeaderPrecoCusto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderPrecoCusto.Width = 100;
            // 
            // columnHeaderQtdeMinima
            // 
            this.columnHeaderQtdeMinima.Text = "Qtde Mínima";
            this.columnHeaderQtdeMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQtdeMinima.Width = 110;
            // 
            // columnHeaderQtdeMaxima
            // 
            this.columnHeaderQtdeMaxima.Text = "Qtde Máxima";
            this.columnHeaderQtdeMaxima.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQtdeMaxima.Width = 110;
            // 
            // columnHeaderQtdeEstoque
            // 
            this.columnHeaderQtdeEstoque.Text = "Qtde Estoque";
            this.columnHeaderQtdeEstoque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderQtdeEstoque.Width = 110;
            // 
            // columnHeaderUnidade
            // 
            this.columnHeaderUnidade.Text = "Unidade";
            this.columnHeaderUnidade.Width = 100;
            // 
            // FrmTodosProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1152, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmTodosProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de produtos";
            this.Load += new System.EventHandler(this.FrmTodosProdutos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTodosProdutos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lwProdutos;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderProduto;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ColumnHeader columnHeaderUnidade;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecoVenda;
        private System.Windows.Forms.ColumnHeader columnHeaderPrecoCusto;
        private System.Windows.Forms.ColumnHeader columnHeaderQtdeMinima;
        private System.Windows.Forms.ColumnHeader columnHeaderQtdeMaxima;
        private System.Windows.Forms.ColumnHeader columnHeaderQtdeEstoque;
    }
}