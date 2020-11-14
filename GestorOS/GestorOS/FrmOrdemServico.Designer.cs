namespace GestorOS
{
    partial class FrmOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrdemServico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckSelecionarTodosItens = new System.Windows.Forms.CheckBox();
            this.txtTotallQtdeItem = new System.Windows.Forms.TextBox();
            this.txtTotalValorUnitario = new System.Windows.Forms.TextBox();
            this.txtTotalSubTotal = new System.Windows.Forms.TextBox();
            this.txtTotalDesconto = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lwItensOrdemServico = new System.Windows.Forms.ListView();
            this.columnHeaderItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTipo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderServProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderQtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVlrUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDesconto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValorTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtObservacoesGerais = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDescricaoDefeito = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNomeObjeto = new System.Windows.Forms.TextBox();
            this.btnBuscarObjeto = new System.Windows.Forms.Button();
            this.txtCodigoObjeto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDataPrevisaoEntrega = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomeOperador = new System.Windows.Forms.TextBox();
            this.txtCodigoOperador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataAbertura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumeroOS = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoverItem = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAdicionarProdSerc = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 605);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckSelecionarTodosItens);
            this.groupBox4.Controls.Add(this.txtTotallQtdeItem);
            this.groupBox4.Controls.Add(this.txtTotalValorUnitario);
            this.groupBox4.Controls.Add(this.txtTotalSubTotal);
            this.groupBox4.Controls.Add(this.txtTotalDesconto);
            this.groupBox4.Controls.Add(this.txtValorTotal);
            this.groupBox4.Controls.Add(this.lwItensOrdemServico);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 387);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1119, 204);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informações sobe Serviços / Produtos e Técnico";
            // 
            // ckSelecionarTodosItens
            // 
            this.ckSelecionarTodosItens.AutoSize = true;
            this.ckSelecionarTodosItens.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckSelecionarTodosItens.Location = new System.Drawing.Point(12, 158);
            this.ckSelecionarTodosItens.Name = "ckSelecionarTodosItens";
            this.ckSelecionarTodosItens.Size = new System.Drawing.Size(206, 24);
            this.ckSelecionarTodosItens.TabIndex = 18;
            this.ckSelecionarTodosItens.Text = "Selecionar todos os items";
            this.ckSelecionarTodosItens.UseVisualStyleBackColor = true;
            this.ckSelecionarTodosItens.CheckedChanged += new System.EventHandler(this.ckSelecionarTodosItens_CheckedChanged);
            // 
            // txtTotallQtdeItem
            // 
            this.txtTotallQtdeItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotallQtdeItem.Location = new System.Drawing.Point(624, 157);
            this.txtTotallQtdeItem.Name = "txtTotallQtdeItem";
            this.txtTotallQtdeItem.ReadOnly = true;
            this.txtTotallQtdeItem.Size = new System.Drawing.Size(55, 29);
            this.txtTotallQtdeItem.TabIndex = 17;
            this.txtTotallQtdeItem.TabStop = false;
            this.txtTotallQtdeItem.Text = "0";
            this.txtTotallQtdeItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalValorUnitario
            // 
            this.txtTotalValorUnitario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalValorUnitario.Location = new System.Drawing.Point(684, 157);
            this.txtTotalValorUnitario.Name = "txtTotalValorUnitario";
            this.txtTotalValorUnitario.ReadOnly = true;
            this.txtTotalValorUnitario.Size = new System.Drawing.Size(93, 29);
            this.txtTotalValorUnitario.TabIndex = 16;
            this.txtTotalValorUnitario.TabStop = false;
            this.txtTotalValorUnitario.Text = "0,00";
            this.txtTotalValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalSubTotal
            // 
            this.txtTotalSubTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSubTotal.Location = new System.Drawing.Point(782, 157);
            this.txtTotalSubTotal.Name = "txtTotalSubTotal";
            this.txtTotalSubTotal.ReadOnly = true;
            this.txtTotalSubTotal.Size = new System.Drawing.Size(95, 29);
            this.txtTotalSubTotal.TabIndex = 15;
            this.txtTotalSubTotal.TabStop = false;
            this.txtTotalSubTotal.Text = "0,00";
            this.txtTotalSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalDesconto
            // 
            this.txtTotalDesconto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDesconto.Location = new System.Drawing.Point(882, 157);
            this.txtTotalDesconto.Name = "txtTotalDesconto";
            this.txtTotalDesconto.ReadOnly = true;
            this.txtTotalDesconto.Size = new System.Drawing.Size(100, 29);
            this.txtTotalDesconto.TabIndex = 14;
            this.txtTotalDesconto.TabStop = false;
            this.txtTotalDesconto.Text = "0,00";
            this.txtTotalDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(987, 157);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(94, 29);
            this.txtValorTotal.TabIndex = 13;
            this.txtValorTotal.TabStop = false;
            this.txtValorTotal.Text = "0,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lwItensOrdemServico
            // 
            this.lwItensOrdemServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwItensOrdemServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lwItensOrdemServico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwItensOrdemServico.CheckBoxes = true;
            this.lwItensOrdemServico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderItem,
            this.columnHeaderTipo,
            this.columnHeaderCod,
            this.columnHeaderServProd,
            this.columnHeaderQtde,
            this.columnHeaderVlrUnitario,
            this.columnHeaderSubTotal,
            this.columnHeaderDesconto,
            this.columnHeaderValorTotal});
            this.lwItensOrdemServico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwItensOrdemServico.GridLines = true;
            this.lwItensOrdemServico.Location = new System.Drawing.Point(10, 21);
            this.lwItensOrdemServico.Name = "lwItensOrdemServico";
            this.lwItensOrdemServico.Size = new System.Drawing.Size(1098, 131);
            this.lwItensOrdemServico.TabIndex = 12;
            this.lwItensOrdemServico.UseCompatibleStateImageBehavior = false;
            this.lwItensOrdemServico.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderItem
            // 
            this.columnHeaderItem.Text = "Item";
            this.columnHeaderItem.Width = 55;
            // 
            // columnHeaderTipo
            // 
            this.columnHeaderTipo.Text = "Tipo";
            this.columnHeaderTipo.Width = 97;
            // 
            // columnHeaderCod
            // 
            this.columnHeaderCod.Text = "Cód.";
            this.columnHeaderCod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderCod.Width = 48;
            // 
            // columnHeaderServProd
            // 
            this.columnHeaderServProd.Text = "Produto/Serviço";
            this.columnHeaderServProd.Width = 410;
            // 
            // columnHeaderQtde
            // 
            this.columnHeaderQtde.Text = "Qtde";
            this.columnHeaderQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeaderVlrUnitario
            // 
            this.columnHeaderVlrUnitario.Text = "Valor Unit.";
            this.columnHeaderVlrUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderVlrUnitario.Width = 101;
            // 
            // columnHeaderSubTotal
            // 
            this.columnHeaderSubTotal.Text = "SubTotal";
            this.columnHeaderSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderSubTotal.Width = 96;
            // 
            // columnHeaderDesconto
            // 
            this.columnHeaderDesconto.Text = "Desconto";
            this.columnHeaderDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderDesconto.Width = 101;
            // 
            // columnHeaderValorTotal
            // 
            this.columnHeaderValorTotal.Text = "Valor Total";
            this.columnHeaderValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderValorTotal.Width = 97;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtObservacoesGerais);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtDescricaoDefeito);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtNomeObjeto);
            this.groupBox3.Controls.Add(this.btnBuscarObjeto);
            this.groupBox3.Controls.Add(this.txtCodigoObjeto);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1119, 178);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Informações do objeto / Equipamento:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(570, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 23);
            this.label16.TabIndex = 16;
            this.label16.Text = "Observações gerais:";
            // 
            // txtObservacoesGerais
            // 
            this.txtObservacoesGerais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacoesGerais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoesGerais.Location = new System.Drawing.Point(570, 109);
            this.txtObservacoesGerais.Multiline = true;
            this.txtObservacoesGerais.Name = "txtObservacoesGerais";
            this.txtObservacoesGerais.Size = new System.Drawing.Size(538, 58);
            this.txtObservacoesGerais.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(10, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 23);
            this.label15.TabIndex = 14;
            this.label15.Text = "Defeito / Solicitação:";
            // 
            // txtDescricaoDefeito
            // 
            this.txtDescricaoDefeito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescricaoDefeito.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoDefeito.Location = new System.Drawing.Point(10, 109);
            this.txtDescricaoDefeito.Multiline = true;
            this.txtDescricaoDefeito.Name = "txtDescricaoDefeito";
            this.txtDescricaoDefeito.Size = new System.Drawing.Size(549, 58);
            this.txtDescricaoDefeito.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(176, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 23);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nome do objeto:";
            // 
            // txtNomeObjeto
            // 
            this.txtNomeObjeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeObjeto.Location = new System.Drawing.Point(180, 48);
            this.txtNomeObjeto.Name = "txtNomeObjeto";
            this.txtNomeObjeto.ReadOnly = true;
            this.txtNomeObjeto.Size = new System.Drawing.Size(928, 29);
            this.txtNomeObjeto.TabIndex = 7;
            this.txtNomeObjeto.TabStop = false;
            // 
            // btnBuscarObjeto
            // 
            this.btnBuscarObjeto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarObjeto.BackgroundImage")));
            this.btnBuscarObjeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarObjeto.Location = new System.Drawing.Point(145, 47);
            this.btnBuscarObjeto.Name = "btnBuscarObjeto";
            this.btnBuscarObjeto.Size = new System.Drawing.Size(35, 31);
            this.btnBuscarObjeto.TabIndex = 2;
            this.btnBuscarObjeto.UseVisualStyleBackColor = true;
            this.btnBuscarObjeto.Click += new System.EventHandler(this.btnBuscarObjeto_Click);
            // 
            // txtCodigoObjeto
            // 
            this.txtCodigoObjeto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoObjeto.Location = new System.Drawing.Point(10, 48);
            this.txtCodigoObjeto.Name = "txtCodigoObjeto";
            this.txtCodigoObjeto.ReadOnly = true;
            this.txtCodigoObjeto.Size = new System.Drawing.Size(135, 29);
            this.txtCodigoObjeto.TabIndex = 1;
            this.txtCodigoObjeto.TabStop = false;
            this.txtCodigoObjeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 23);
            this.label14.TabIndex = 0;
            this.label14.Text = "Código:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtDocumento);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtNomeCliente);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.txtCodigoCliente);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1119, 90);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações do cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(902, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 23);
            this.label9.TabIndex = 12;
            this.label9.Text = "Celular:";
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(902, 48);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.ReadOnly = true;
            this.txtCelular.Size = new System.Drawing.Size(206, 29);
            this.txtCelular.TabIndex = 11;
            this.txtCelular.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(726, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Documento:";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumento.Location = new System.Drawing.Point(730, 48);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.ReadOnly = true;
            this.txtDocumento.Size = new System.Drawing.Size(166, 29);
            this.txtDocumento.TabIndex = 9;
            this.txtDocumento.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(176, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Cliente:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(180, 48);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.ReadOnly = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(544, 29);
            this.txtNomeCliente.TabIndex = 7;
            this.txtNomeCliente.TabStop = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuscarCliente.BackgroundImage")));
            this.btnBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarCliente.Location = new System.Drawing.Point(145, 47);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(35, 31);
            this.btnBuscarCliente.TabIndex = 2;
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoCliente.Location = new System.Drawing.Point(10, 48);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.ReadOnly = true;
            this.txtCodigoCliente.Size = new System.Drawing.Size(135, 29);
            this.txtCodigoCliente.TabIndex = 1;
            this.txtCodigoCliente.TabStop = false;
            this.txtCodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Código:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSituacao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtDataPrevisaoEntrega);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNomeOperador);
            this.groupBox1.Controls.Add(this.txtCodigoOperador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDataAbertura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNumeroOS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 90);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações básica";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(902, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Situação:";
            // 
            // txtSituacao
            // 
            this.txtSituacao.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSituacao.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtSituacao.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.FormattingEnabled = true;
            this.txtSituacao.Location = new System.Drawing.Point(902, 46);
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(206, 31);
            this.txtSituacao.TabIndex = 2;
            this.txtSituacao.Text = "--Selecione--";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(731, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Previsão de entrega:";
            // 
            // txtDataPrevisaoEntrega
            // 
            this.txtDataPrevisaoEntrega.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataPrevisaoEntrega.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataPrevisaoEntrega.Location = new System.Drawing.Point(735, 47);
            this.txtDataPrevisaoEntrega.Name = "txtDataPrevisaoEntrega";
            this.txtDataPrevisaoEntrega.Size = new System.Drawing.Size(161, 30);
            this.txtDataPrevisaoEntrega.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(372, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome do operador:";
            // 
            // txtNomeOperador
            // 
            this.txtNomeOperador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeOperador.Location = new System.Drawing.Point(376, 48);
            this.txtNomeOperador.Name = "txtNomeOperador";
            this.txtNomeOperador.ReadOnly = true;
            this.txtNomeOperador.Size = new System.Drawing.Size(353, 29);
            this.txtNomeOperador.TabIndex = 6;
            this.txtNomeOperador.TabStop = false;
            // 
            // txtCodigoOperador
            // 
            this.txtCodigoOperador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoOperador.Location = new System.Drawing.Point(299, 48);
            this.txtCodigoOperador.Name = "txtCodigoOperador";
            this.txtCodigoOperador.ReadOnly = true;
            this.txtCodigoOperador.Size = new System.Drawing.Size(76, 29);
            this.txtCodigoOperador.TabIndex = 5;
            this.txtCodigoOperador.TabStop = false;
            this.txtCodigoOperador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // txtDataAbertura
            // 
            this.txtDataAbertura.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataAbertura.Location = new System.Drawing.Point(151, 48);
            this.txtDataAbertura.Name = "txtDataAbertura";
            this.txtDataAbertura.ReadOnly = true;
            this.txtDataAbertura.Size = new System.Drawing.Size(135, 29);
            this.txtDataAbertura.TabIndex = 3;
            this.txtDataAbertura.TabStop = false;
            this.txtDataAbertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data de abertura:";
            // 
            // txtNumeroOS
            // 
            this.txtNumeroOS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroOS.Location = new System.Drawing.Point(10, 48);
            this.txtNumeroOS.Name = "txtNumeroOS";
            this.txtNumeroOS.ReadOnly = true;
            this.txtNumeroOS.Size = new System.Drawing.Size(135, 29);
            this.txtNumeroOS.TabIndex = 1;
            this.txtNumeroOS.TabStop = false;
            this.txtNumeroOS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número OS:";
            // 
            // btnRemoverItem
            // 
            this.btnRemoverItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoverItem.BackgroundImage")));
            this.btnRemoverItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoverItem.Enabled = false;
            this.btnRemoverItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItem.Location = new System.Drawing.Point(35, 626);
            this.btnRemoverItem.Name = "btnRemoverItem";
            this.btnRemoverItem.Size = new System.Drawing.Size(146, 41);
            this.btnRemoverItem.TabIndex = 1;
            this.btnRemoverItem.TabStop = false;
            this.btnRemoverItem.Text = "Remover item";
            this.btnRemoverItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverItem.UseVisualStyleBackColor = true;
            this.btnRemoverItem.Click += new System.EventHandler(this.btnRemoverItem_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(975, 626);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar - ESC";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalvar.BackgroundImage")));
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(688, 625);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(130, 41);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.TabStop = false;
            this.btnSalvar.Text = "Salvar - F4";
            this.btnSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAdicionarProdSerc
            // 
            this.btnAdicionarProdSerc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarProdSerc.BackgroundImage")));
            this.btnAdicionarProdSerc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdicionarProdSerc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarProdSerc.Location = new System.Drawing.Point(187, 626);
            this.btnAdicionarProdSerc.Name = "btnAdicionarProdSerc";
            this.btnAdicionarProdSerc.Size = new System.Drawing.Size(277, 41);
            this.btnAdicionarProdSerc.TabIndex = 1;
            this.btnAdicionarProdSerc.Text = "Adicionar Produto e Serviço -F1";
            this.btnAdicionarProdSerc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarProdSerc.UseVisualStyleBackColor = true;
            this.btnAdicionarProdSerc.Click += new System.EventHandler(this.btnAdicionarProdSerc_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFinalizar.BackgroundImage")));
            this.btnFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFinalizar.Enabled = false;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(824, 626);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(145, 41);
            this.btnFinalizar.TabIndex = 4;
            this.btnFinalizar.Text = "Finalizar - F5";
            this.btnFinalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // FrmOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1168, 676);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAdicionarProdSerc);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRemoverItem);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar ordem de serviço";
            this.Load += new System.EventHandler(this.FrmOrdemServico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrdemServico_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNumeroOS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomeOperador;
        private System.Windows.Forms.TextBox txtCodigoOperador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDataAbertura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox txtSituacao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker txtDataPrevisaoEntrega;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtObservacoesGerais;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtDescricaoDefeito;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNomeObjeto;
        private System.Windows.Forms.Button btnBuscarObjeto;
        private System.Windows.Forms.TextBox txtCodigoObjeto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListView lwItensOrdemServico;
        private System.Windows.Forms.ColumnHeader columnHeaderItem;
        private System.Windows.Forms.CheckBox ckSelecionarTodosItens;
        private System.Windows.Forms.TextBox txtTotallQtdeItem;
        private System.Windows.Forms.TextBox txtTotalValorUnitario;
        private System.Windows.Forms.TextBox txtTotalSubTotal;
        private System.Windows.Forms.TextBox txtTotalDesconto;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Button btnRemoverItem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAdicionarProdSerc;
        private System.Windows.Forms.ColumnHeader columnHeaderTipo;
        private System.Windows.Forms.ColumnHeader columnHeaderCod;
        private System.Windows.Forms.ColumnHeader columnHeaderServProd;
        private System.Windows.Forms.ColumnHeader columnHeaderQtde;
        private System.Windows.Forms.ColumnHeader columnHeaderVlrUnitario;
        private System.Windows.Forms.ColumnHeader columnHeaderSubTotal;
        private System.Windows.Forms.ColumnHeader columnHeaderDesconto;
        private System.Windows.Forms.ColumnHeader columnHeaderValorTotal;
        private System.Windows.Forms.Button btnFinalizar;
    }
}