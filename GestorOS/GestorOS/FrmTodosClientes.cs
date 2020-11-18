using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosClientes : Form
    {
        MeuDataContext meuDataContext;
        public Cliente cliente;

        public FrmTodosClientes()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodosClientes_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosClientes();
        }

        private void FrmTodosClientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnNovo_Click(this, e);
            }
        }

        private void lwFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            if (lwClientes.Items.Count > 0)
            {
                int clienteId = int.Parse(lwClientes.FocusedItem.SubItems[0].Text);

                cliente = meuDataContext.Clientes.Find(clienteId);

                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
            CarregarTodosClientes();
        }


        private void CarregarTodosClientes()
        {
            var clientes = meuDataContext.Clientes.AsNoTracking()
                                                  .Where(s => s.NomeFantasia.Contains(txtBuscar.Text) || s.Documento.Contains(txtBuscar.Text))
                                                  .OrderBy(s => s.NomeFantasia).ToList();
            if (clientes.Count > 0)
            {
                lwClientes.Items.Clear();
                int item = 0;

                foreach (var funcionario in clientes)
                {
                    lwClientes.Items.Add(funcionario.Id.ToString());
                    lwClientes.Items[item].SubItems.Add(funcionario.NomeFantasia);
                    lwClientes.Items[item].SubItems.Add(funcionario.Documento);
                    lwClientes.Items[item].SubItems.Add(funcionario.Celular);
                    item++;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosClientes();
        }

        private void editarOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwClientes.Items.Count > 0)
            {
                int clienteId = int.Parse(lwClientes.FocusedItem.SubItems[0].Text);
                FrmCliente frm = new FrmCliente();
                frm.CarregaClienteEditar(clienteId);
                frm.ShowDialog();
                CarregarTodosClientes();
            }
        }
    }
}
