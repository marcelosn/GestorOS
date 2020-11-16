namespace GestorOS
{
    partial class FrmFinalizarOrdemServicoVenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFinalizarOrdemServicoVenda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorFinalVenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorFaltando = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorRecebido = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValorPrincipal = new System.Windows.Forms.TextBox();
            this.lwPagamentosOrdemServico = new System.Windows.Forms.ListView();
            this.columnHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.txtPagando = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lwTipoFormaPagamentos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCodigoTipoFormaPgto = new System.Windows.Forms.TextBox();
            this.btnFinalizarSalvar = new System.Windows.Forms.Button();
            this.btnAplicarDesconto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 356);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtValorFinalVenda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtValorFaltando);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtValorRecebido);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.txtValorPrincipal);
            this.groupBox1.Controls.Add(this.lwPagamentosOrdemServico);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPagando);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lwTipoFormaPagamentos);
            this.groupBox1.Controls.Add(this.txtCodigoTipoFormaPgto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1092, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas de Pagamento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1022, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 23);
            this.label8.TabIndex = 33;
            this.label8.Text = "Troco";
            // 
            // textBox8
            // 
            this.textBox8.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox8.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(924, 271);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(152, 43);
            this.textBox8.TabIndex = 32;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "0,00";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(930, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 23);
            this.label7.TabIndex = 31;
            this.label7.Text = "Total Final Venda";
            // 
            // txtValorFinalVenda
            // 
            this.txtValorFinalVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorFinalVenda.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFinalVenda.Location = new System.Drawing.Point(924, 199);
            this.txtValorFinalVenda.Name = "txtValorFinalVenda";
            this.txtValorFinalVenda.ReadOnly = true;
            this.txtValorFinalVenda.Size = new System.Drawing.Size(152, 43);
            this.txtValorFinalVenda.TabIndex = 30;
            this.txtValorFinalVenda.TabStop = false;
            this.txtValorFinalVenda.Text = "0,00";
            this.txtValorFinalVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(839, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 23);
            this.label6.TabIndex = 29;
            this.label6.Text = "Faltando";
            // 
            // txtValorFaltando
            // 
            this.txtValorFaltando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorFaltando.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorFaltando.Location = new System.Drawing.Point(766, 199);
            this.txtValorFaltando.Name = "txtValorFaltando";
            this.txtValorFaltando.ReadOnly = true;
            this.txtValorFaltando.Size = new System.Drawing.Size(152, 43);
            this.txtValorFaltando.TabIndex = 28;
            this.txtValorFaltando.TabStop = false;
            this.txtValorFaltando.Text = "0,00";
            this.txtValorFaltando.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(956, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Desconto [F8]";
            // 
            // txtDesconto
            // 
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesconto.Location = new System.Drawing.Point(924, 127);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(152, 43);
            this.txtDesconto.TabIndex = 26;
            this.txtDesconto.TabStop = false;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.Enter += new System.EventHandler(this.txtDesconto_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(833, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Sub Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubTotal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(766, 127);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(152, 43);
            this.txtSubTotal.TabIndex = 24;
            this.txtSubTotal.TabStop = false;
            this.txtSubTotal.Text = "0,00";
            this.txtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(946, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Valor Recebido";
            // 
            // txtValorRecebido
            // 
            this.txtValorRecebido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorRecebido.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorRecebido.Location = new System.Drawing.Point(924, 54);
            this.txtValorRecebido.Name = "txtValorRecebido";
            this.txtValorRecebido.ReadOnly = true;
            this.txtValorRecebido.Size = new System.Drawing.Size(152, 43);
            this.txtValorRecebido.TabIndex = 22;
            this.txtValorRecebido.TabStop = false;
            this.txtValorRecebido.Text = "0,00";
            this.txtValorRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor.ForeColor = System.Drawing.Color.Black;
            this.lblValor.Location = new System.Drawing.Point(792, 28);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(119, 23);
            this.lblValor.TabIndex = 21;
            this.lblValor.Text = "Valor Principal";
            // 
            // txtValorPrincipal
            // 
            this.txtValorPrincipal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPrincipal.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorPrincipal.Location = new System.Drawing.Point(766, 54);
            this.txtValorPrincipal.Name = "txtValorPrincipal";
            this.txtValorPrincipal.ReadOnly = true;
            this.txtValorPrincipal.Size = new System.Drawing.Size(152, 43);
            this.txtValorPrincipal.TabIndex = 20;
            this.txtValorPrincipal.TabStop = false;
            this.txtValorPrincipal.Text = "0,00";
            this.txtValorPrincipal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lwPagamentosOrdemServico
            // 
            this.lwPagamentosOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwPagamentosOrdemServico.BackColor = System.Drawing.Color.SeaShell;
            this.lwPagamentosOrdemServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwPagamentosOrdemServico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTipo,
            this.columnHeaderValor});
            this.lwPagamentosOrdemServico.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwPagamentosOrdemServico.FullRowSelect = true;
            this.lwPagamentosOrdemServico.GridLines = true;
            this.lwPagamentosOrdemServico.Location = new System.Drawing.Point(351, 102);
            this.lwPagamentosOrdemServico.Name = "lwPagamentosOrdemServico";
            this.lwPagamentosOrdemServico.Size = new System.Drawing.Size(394, 212);
            this.lwPagamentosOrdemServico.TabIndex = 2;
            this.lwPagamentosOrdemServico.UseCompatibleStateImageBehavior = false;
            this.lwPagamentosOrdemServico.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderTipo
            // 
            this.columnHeaderTipo.Text = "Tipo";
            this.columnHeaderTipo.Width = 248;
            // 
            // columnHeaderValor
            // 
            this.columnHeaderValor.Text = "Valor";
            this.columnHeaderValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValor.Width = 135;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(347, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Valor (R$)";
            // 
            // txtPagando
            // 
            this.txtPagando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPagando.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagando.Location = new System.Drawing.Point(351, 55);
            this.txtPagando.Name = "txtPagando";
            this.txtPagando.Size = new System.Drawing.Size(394, 43);
            this.txtPagando.TabIndex = 1;
            this.txtPagando.Text = "0,00";
            this.txtPagando.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPagando.Enter += new System.EventHandler(this.txtPagando_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código";
            // 
            // lwTipoFormaPagamentos
            // 
            this.lwTipoFormaPagamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwTipoFormaPagamentos.BackColor = System.Drawing.Color.SeaShell;
            this.lwTipoFormaPagamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwTipoFormaPagamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderNome});
            this.lwTipoFormaPagamentos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwTipoFormaPagamentos.FullRowSelect = true;
            this.lwTipoFormaPagamentos.GridLines = true;
            this.lwTipoFormaPagamentos.Location = new System.Drawing.Point(17, 102);
            this.lwTipoFormaPagamentos.Name = "lwTipoFormaPagamentos";
            this.lwTipoFormaPagamentos.Size = new System.Drawing.Size(328, 212);
            this.lwTipoFormaPagamentos.TabIndex = 15;
            this.lwTipoFormaPagamentos.TabStop = false;
            this.lwTipoFormaPagamentos.UseCompatibleStateImageBehavior = false;
            this.lwTipoFormaPagamentos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Cód.";
            // 
            // columnHeaderNome
            // 
            this.columnHeaderNome.Text = "Nome";
            this.columnHeaderNome.Width = 236;
            // 
            // txtCodigoTipoFormaPgto
            // 
            this.txtCodigoTipoFormaPgto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodigoTipoFormaPgto.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoTipoFormaPgto.Location = new System.Drawing.Point(17, 55);
            this.txtCodigoTipoFormaPgto.Name = "txtCodigoTipoFormaPgto";
            this.txtCodigoTipoFormaPgto.Size = new System.Drawing.Size(328, 43);
            this.txtCodigoTipoFormaPgto.TabIndex = 0;
            this.txtCodigoTipoFormaPgto.Enter += new System.EventHandler(this.txtCodigoTipoFormaPgto_Enter);
            // 
            // btnFinalizarSalvar
            // 
            this.btnFinalizarSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizarSalvar.BackgroundImage")));
            this.btnFinalizarSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizarSalvar.Enabled = false;
            this.btnFinalizarSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarSalvar.Location = new System.Drawing.Point(468, 377);
            this.btnFinalizarSalvar.Name = "btnFinalizarSalvar";
            this.btnFinalizarSalvar.Size = new System.Drawing.Size(268, 41);
            this.btnFinalizarSalvar.TabIndex = 3;
            this.btnFinalizarSalvar.TabStop = false;
            this.btnFinalizarSalvar.Text = "Finalizar - F4";
            this.btnFinalizarSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizarSalvar.UseVisualStyleBackColor = true;
            this.btnFinalizarSalvar.Click += new System.EventHandler(this.btnFinalizarSalvar_Click);
            // 
            // btnAplicarDesconto
            // 
            this.btnAplicarDesconto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAplicarDesconto.BackgroundImage")));
            this.btnAplicarDesconto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAplicarDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarDesconto.Location = new System.Drawing.Point(252, 377);
            this.btnAplicarDesconto.Name = "btnAplicarDesconto";
            this.btnAplicarDesconto.Size = new System.Drawing.Size(210, 41);
            this.btnAplicarDesconto.TabIndex = 6;
            this.btnAplicarDesconto.TabStop = false;
            this.btnAplicarDesconto.Text = "Aplicar Desconto - F8";
            this.btnAplicarDesconto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAplicarDesconto.UseVisualStyleBackColor = true;
            this.btnAplicarDesconto.Click += new System.EventHandler(this.btnAplicarDesconto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(742, 377);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 41);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar - ESC";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmFinalizarOrdemServicoVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1146, 431);
            this.Controls.Add(this.btnFinalizarSalvar);
            this.Controls.Add(this.btnAplicarDesconto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmFinalizarOrdemServicoVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar ";
            this.Load += new System.EventHandler(this.FrmFinalizarOrdemServicoVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmFinalizarOrdemServicoVenda_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lwTipoFormaPagamentos;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderNome;
        private System.Windows.Forms.TextBox txtCodigoTipoFormaPgto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lwPagamentosOrdemServico;
        private System.Windows.Forms.ColumnHeader columnHeaderTipo;
        private System.Windows.Forms.ColumnHeader columnHeaderValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPagando;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorFinalVenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorFaltando;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorRecebido;
        private System.Windows.Forms.Button btnFinalizarSalvar;
        private System.Windows.Forms.Button btnAplicarDesconto;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtValorPrincipal;
    }
}