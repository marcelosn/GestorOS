using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosUnidadeMedidas : Form
    {
        MeuDataContext meuDataContext;
        public UnidadeMedida unidadeMedida;

        public FrmTodosUnidadeMedidas()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodosUnidadeMedidas_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregaTodasUnidades();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void CarregaTodasUnidades()
        {
            var unidades = meuDataContext.UnidadeMedidas
                                         .AsNoTracking()
                                         .Where(u => u.Nome.Contains(txtBuscar.Text) || u.Sigla.Contains(txtBuscar.Text)).OrderBy(u=> u.Nome).ToList();
            if (unidades.Count > 0)
            {
                lwUnidades.Items.Clear();
                int item = 0;

                foreach (var unidade in unidades)
                {
                    lwUnidades.Items.Add(unidade.Id.ToString());
                    lwUnidades.Items[item].SubItems.Add(unidade.Nome);
                    lwUnidades.Items[item].SubItems.Add(unidade.Sigla);
                    item++;
                }
            }
        }

        private void FrmTodosUnidadeMedidas_KeyDown(object sender, KeyEventArgs e)
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregaTodasUnidades();
        }

        private void lwUnidades_DoubleClick(object sender, EventArgs e)
        {
            if (lwUnidades.Items.Count > 0)
            {
                int unidadeId = int.Parse(lwUnidades.FocusedItem.SubItems[0].Text);

                unidadeMedida = meuDataContext.UnidadeMedidas.Find(unidadeId);

                this.Close();
            }
        }
    }
}
