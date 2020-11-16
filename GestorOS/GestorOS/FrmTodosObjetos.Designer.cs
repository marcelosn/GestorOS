namespace GestorOS
{
    partial class FrmTodosObjetos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTodosObjetos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNovo = new System.Windows.Forms.Button();
            this.lwObjetos = new System.Windows.Forms.ListView();
            this.columnHeaderCodigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderObjeto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.Controls.Add(this.lwObjetos);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 444);
            this.panel1.TabIndex = 3;
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
            // lwObjetos
            // 
            this.lwObjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwObjetos.BackColor = System.Drawing.Color.SeaShell;
            this.lwObjetos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lwObjetos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCodigo,
            this.columnHeaderObjeto});
            this.lwObjetos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwObjetos.FullRowSelect = true;
            this.lwObjetos.GridLines = true;
            this.lwObjetos.Location = new System.Drawing.Point(9, 51);
            this.lwObjetos.Name = "lwObjetos";
            this.lwObjetos.Size = new System.Drawing.Size(756, 379);
            this.lwObjetos.TabIndex = 13;
            this.lwObjetos.UseCompatibleStateImageBehavior = false;
            this.lwObjetos.View = System.Windows.Forms.View.Details;
            this.lwObjetos.DoubleClick += new System.EventHandler(this.lwClientes_DoubleClick);
            // 
            // columnHeaderCodigo
            // 
            this.columnHeaderCodigo.Text = "Código";
            this.columnHeaderCodigo.Width = 64;
            // 
            // columnHeaderObjeto
            // 
            this.columnHeaderObjeto.Text = "Objeto/Equipamento";
            this.columnHeaderObjeto.Width = 644;
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
            // FrmTodosObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "FrmTodosObjetos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relação de objetos(Equipamentos)";
            this.Load += new System.EventHandler(this.FrmTodosObjetos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmTodosObjetos_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.ListView lwObjetos;
        private System.Windows.Forms.ColumnHeader columnHeaderCodigo;
        private System.Windows.Forms.ColumnHeader columnHeaderObjeto;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}