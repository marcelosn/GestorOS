namespace GestorOS
{
    partial class FrmTodasOrdemServico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodasOrdemServico));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQtde = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorTotalProd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTotalServico = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtValorTotalDesc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtDataFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDataInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.lwOrdemSevicos = new System.Windows.Forms.ListView();
            this.columnHeadeNO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSituacao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDataAbertura = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEquip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVlServico = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVlProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValorDesc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVLT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imprimirOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarOrdemDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtQtde);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtValorTotalProd);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtValorTotalServico);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtValorTotalDesc);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtValorTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.lwOrdemSevicos);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1118, 616);
            this.panel2.TabIndex = 1;
            // 
            // txtQtde
            // 
            this.txtQtde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtQtde.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtde.Location = new System.Drawing.Point(10, 568);
            this.txtQtde.Name = "txtQtde";
            this.txtQtde.ReadOnly = true;
            this.txtQtde.Size = new System.Drawing.Size(78, 29);
            this.txtQtde.TabIndex = 11;
            this.txtQtde.TabStop = false;
            this.txtQtde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(8, 547);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quantidade";
            // 
            // txtValorTotalProd
            // 
            this.txtValorTotalProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotalProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalProd.Location = new System.Drawing.Point(664, 568);
            this.txtValorTotalProd.Name = "txtValorTotalProd";
            this.txtValorTotalProd.ReadOnly = true;
            this.txtValorTotalProd.Size = new System.Drawing.Size(135, 29);
            this.txtValorTotalProd.TabIndex = 9;
            this.txtValorTotalProd.TabStop = false;
            this.txtValorTotalProd.Text = "0,00";
            this.txtValorTotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(661, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Valor total produto";
            // 
            // txtValorTotalServico
            // 
            this.txtValorTotalServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotalServico.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalServico.Location = new System.Drawing.Point(523, 568);
            this.txtValorTotalServico.Name = "txtValorTotalServico";
            this.txtValorTotalServico.ReadOnly = true;
            this.txtValorTotalServico.Size = new System.Drawing.Size(135, 29);
            this.txtValorTotalServico.TabIndex = 7;
            this.txtValorTotalServico.TabStop = false;
            this.txtValorTotalServico.Text = "0,00";
            this.txtValorTotalServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(520, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor total serviço";
            // 
            // txtValorTotalDesc
            // 
            this.txtValorTotalDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotalDesc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotalDesc.Location = new System.Drawing.Point(805, 568);
            this.txtValorTotalDesc.Name = "txtValorTotalDesc";
            this.txtValorTotalDesc.ReadOnly = true;
            this.txtValorTotalDesc.Size = new System.Drawing.Size(135, 29);
            this.txtValorTotalDesc.TabIndex = 5;
            this.txtValorTotalDesc.TabStop = false;
            this.txtValorTotalDesc.Text = "0,00";
            this.txtValorTotalDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(802, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Valor total desconto";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTotal.Location = new System.Drawing.Point(946, 568);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(135, 29);
            this.txtValorTotal.TabIndex = 3;
            this.txtValorTotal.TabStop = false;
            this.txtValorTotal.Text = "0,00";
            this.txtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(943, 548);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnNovo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.txtDataFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDataInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1093, 69);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(900, 24);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(181, 32);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "Adicionar novo - F1";
            this.btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(498, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Pesquisar:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(587, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(304, 30);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataFinal.Location = new System.Drawing.Point(350, 25);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(141, 30);
            this.txtDataFinal.TabIndex = 3;
            this.txtDataFinal.ValueChanged += new System.EventHandler(this.txtDataFinal_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data final:";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDataInicial.Location = new System.Drawing.Point(106, 27);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(141, 30);
            this.txtDataInicial.TabIndex = 1;
            this.txtDataInicial.ValueChanged += new System.EventHandler(this.txtDataInicial_ValueChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data incial:";
            // 
            // lwOrdemSevicos
            // 
            this.lwOrdemSevicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwOrdemSevicos.BackColor = System.Drawing.Color.SeaShell;
            this.lwOrdemSevicos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwOrdemSevicos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeadeNO,
            this.columnHeaderSituacao,
            this.columnHeaderDataAbertura,
            this.columnHeaderCliente,
            this.columnHeaderDoc,
            this.columnHeaderEquip,
            this.columnHeaderVlServico,
            this.columnHeaderVlProd,
            this.columnHeaderValorDesc,
            this.columnHeaderVLT});
            this.lwOrdemSevicos.ContextMenuStrip = this.contextMenuStrip1;
            this.lwOrdemSevicos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwOrdemSevicos.FullRowSelect = true;
            this.lwOrdemSevicos.GridLines = true;
            this.lwOrdemSevicos.Location = new System.Drawing.Point(13, 86);
            this.lwOrdemSevicos.Name = "lwOrdemSevicos";
            this.lwOrdemSevicos.Size = new System.Drawing.Size(1096, 456);
            this.lwOrdemSevicos.TabIndex = 0;
            this.lwOrdemSevicos.UseCompatibleStateImageBehavior = false;
            this.lwOrdemSevicos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeadeNO
            // 
            this.columnHeadeNO.Text = "Nº.OS";
            this.columnHeadeNO.Width = 79;
            // 
            // columnHeaderSituacao
            // 
            this.columnHeaderSituacao.Text = "Situação";
            this.columnHeaderSituacao.Width = 200;
            // 
            // columnHeaderDataAbertura
            // 
            this.columnHeaderDataAbertura.Text = "Data Abertura";
            this.columnHeaderDataAbertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDataAbertura.Width = 127;
            // 
            // columnHeaderCliente
            // 
            this.columnHeaderCliente.Text = "Cliente";
            this.columnHeaderCliente.Width = 288;
            // 
            // columnHeaderDoc
            // 
            this.columnHeaderDoc.Text = "CPF/CNPJ";
            this.columnHeaderDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoc.Width = 122;
            // 
            // columnHeaderEquip
            // 
            this.columnHeaderEquip.Text = "Objeto";
            this.columnHeaderEquip.Width = 183;
            // 
            // columnHeaderVlServico
            // 
            this.columnHeaderVlServico.Text = "Valor Total Serviço";
            this.columnHeaderVlServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderVlServico.Width = 144;
            // 
            // columnHeaderVlProd
            // 
            this.columnHeaderVlProd.Text = "Valor Total Produto";
            this.columnHeaderVlProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderVlProd.Width = 149;
            // 
            // columnHeaderValorDesc
            // 
            this.columnHeaderValorDesc.Text = "Valor Desconto";
            this.columnHeaderValorDesc.Width = 117;
            // 
            // columnHeaderVLT
            // 
            this.columnHeaderVLT.Text = "Valor Total";
            this.columnHeaderVLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeaderVLT.Width = 110;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirOrdemDeServiçoToolStripMenuItem,
            this.editarOrdemDeServiçoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(253, 52);
            // 
            // imprimirOrdemDeServiçoToolStripMenuItem
            // 
            this.imprimirOrdemDeServiçoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imprimirOrdemDeServiçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirOrdemDeServiçoToolStripMenuItem.Image")));
            this.imprimirOrdemDeServiçoToolStripMenuItem.Name = "imprimirOrdemDeServiçoToolStripMenuItem";
            this.imprimirOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.imprimirOrdemDeServiçoToolStripMenuItem.Text = "Imprimir ordem de serviço";
            this.imprimirOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.imprimirOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // editarOrdemDeServiçoToolStripMenuItem
            // 
            this.editarOrdemDeServiçoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editarOrdemDeServiçoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarOrdemDeServiçoToolStripMenuItem.Image")));
            this.editarOrdemDeServiçoToolStripMenuItem.Name = "editarOrdemDeServiçoToolStripMenuItem";
            this.editarOrdemDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(252, 24);
            this.editarOrdemDeServiçoToolStripMenuItem.Text = "Editar ordem de serviço";
            this.editarOrdemDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.editarOrdemDeServiçoToolStripMenuItem_Click);
            // 
            // FrmTodasOrdemServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1142, 640);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmTodasOrdemServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de ordens de serviços";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmTodasOrdemServico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTodasOrdemServico_KeyDown_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lwOrdemSevicos;
        private System.Windows.Forms.ColumnHeader columnHeadeNO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DateTimePicker txtDataFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtDataInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.TextBox txtQtde;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorTotalProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTotalServico;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtValorTotalDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeaderSituacao;
        private System.Windows.Forms.ColumnHeader columnHeaderDataAbertura;
        private System.Windows.Forms.ColumnHeader columnHeaderCliente;
        private System.Windows.Forms.ColumnHeader columnHeaderDoc;
        private System.Windows.Forms.ColumnHeader columnHeaderEquip;
        private System.Windows.Forms.ColumnHeader columnHeaderVlServico;
        private System.Windows.Forms.ColumnHeader columnHeaderVlProd;
        private System.Windows.Forms.ColumnHeader columnHeaderValorDesc;
        private System.Windows.Forms.ColumnHeader columnHeaderVLT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imprimirOrdemDeServiçoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarOrdemDeServiçoToolStripMenuItem;
    }
}