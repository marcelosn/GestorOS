using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosServicos : Form
    {
        MeuDataContext meuDataContext;
        public Servico servico;

        public FrmTodosServicos()
        {
            meuDataContext = new MeuDataContext();
            InitializeComponent();
        }

        private void FrmTodosServicos_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosServicos();
        }

        private void lwServicos_DoubleClick(object sender, EventArgs e)
        {
            if (lwServicos.Items.Count > 0)
            {
                int servicoId = int.Parse(lwServicos.FocusedItem.SubItems[0].Text);

                servico = meuDataContext.Servicos.Find(servicoId);

                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosServicos();
        }

        private void FrmTodosServicos_KeyDown(object sender, KeyEventArgs e)
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

        private void CarregarTodosServicos()
        {
            var servicos = meuDataContext.Servicos
                                         .Include("UnidadeMedida")
                                         .AsNoTracking()
                                         .Where(s => s.Nome.Contains(txtBuscar.Text))
                                         .OrderBy(s => s.Nome).ToList();
            if (servicos.Count > 0)
            {
                lwServicos.Items.Clear();
                int item = 0;

                foreach (var servico in servicos)
                {
                    lwServicos.Items.Add(servico.Id.ToString());
                    lwServicos.Items[item].SubItems.Add(servico.Nome);
                    lwServicos.Items[item].SubItems.Add(servico.UnidadeMedida.Nome);
                    lwServicos.Items[item].SubItems.Add(servico.Valor.ToString("N2"));
                    lwServicos.Items[item].SubItems.Add(servico.PercentualComissao);
                    lwServicos.Items[item].SubItems.Add(Convert.ToDecimal(servico.PercentualValorComissão).ToString("N2"));
                    item++;
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmServico frm = new FrmServico();
            frm.ShowDialog();
            CarregarTodosServicos();
        }
    }
}
