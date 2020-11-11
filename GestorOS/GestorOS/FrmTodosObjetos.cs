using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosObjetos : Form
    {
        MeuDataContext meuDataContext;
        public Objeto  objeto;

        public FrmTodosObjetos()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodosObjetos_KeyDown(object sender, KeyEventArgs e)
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

        private void lwClientes_DoubleClick(object sender, EventArgs e)
        {
            if (lwObjetos.Items.Count > 0)
            {
                int objetoId = int.Parse(lwObjetos.FocusedItem.SubItems[0].Text);

                objeto = meuDataContext.Objetos.Find(objetoId);

                this.Close();
            }
        }

        private void FrmTodosObjetos_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosObjetos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }


        private void CarregarTodosObjetos()
        {
            var objetos = meuDataContext.Objetos.AsNoTracking()
                                                .Where(s => s.Nome.Contains(txtBuscar.Text))
                                                .OrderBy(s => s.Nome).ToList();
            if (objetos.Count > 0)
            {
                lwObjetos.Items.Clear();
                int item = 0;

                foreach (var objeto in objetos)
                {
                    lwObjetos.Items.Add(objeto.Id.ToString());
                    lwObjetos.Items[item].SubItems.Add(objeto.Nome);
                    item++;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosObjetos();
        }
    }
}
