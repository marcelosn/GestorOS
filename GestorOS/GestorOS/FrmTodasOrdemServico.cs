using GestorOS.App;
using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodasOrdemServico : Form
    {
        MeuDataContext meuDataContext;
        IList<OrdemServico> ordemServicos = new List<OrdemServico>();
        int qtde;
        decimal valorTotalServico;
        decimal valorTotalProduto;
        decimal valorDesconto;
        decimal valorTotal;

        public FrmTodasOrdemServico()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodasOrdemServico_Load(object sender, EventArgs e)
        {
            txtDataInicial.Focus();
            CarregaTodasOrdemServicos();
        }

        private void CarregaTodasOrdemServicos()
        {
            DateTime dtInicial = Convert.ToDateTime(txtDataInicial.Text);
            DateTime dtFinal = Convert.ToDateTime(txtDataFinal.Text);

            ordemServicos = meuDataContext.OrdemServicos
                                          .AsNoTracking()
                                          .Include("Cliente")
                                          .Include("SituacaoOrdemServico")
                                          .Include("Objeto")
                                          .Where(o => o.DataHoraCadastro >= dtInicial
                                                   && o.DataHoraCadastro <= dtFinal
                                                   && o.Cliente.NomeFantasia.Contains(txtBuscar.Text))
                                           .OrderBy(o => o.DataHoraCadastro).ToList();
            if (ordemServicos.Count > 0)
            {
                lwOrdemSevicos.Items.Clear();

                for (int i = 0; i < ordemServicos.Count; i++)
                {
                    lwOrdemSevicos.Items.Add(Utilitarios.AdicionaZero(ordemServicos[i].Id.ToString()));
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].SituacaoOrdemServico.Nome);
                    lwOrdemSevicos.Items[i].SubItems.Add(Convert.ToDateTime(ordemServicos[i].DataHoraCadastro).ToString("dd/MM/yyyy"));
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].Cliente.NomeFantasia);
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].Cliente.Documento);
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].Objeto.Nome);
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].ValorTotalServico.ToString("C"));
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].ValorTotalProduto.ToString("C"));
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].ValorDesconto.ToString("C"));
                    lwOrdemSevicos.Items[i].SubItems.Add(ordemServicos[i].ValorTotal.ToString("C"));
                }

                CalcularTotalizadores();
            }
        }

        private void CalcularTotalizadores()
        {
            if (ordemServicos.Count != 0)
            {
                qtde = 0;
                valorDesconto = 0;
                valorTotal = 0;
                valorTotalProduto = 0;
                valorTotalServico = 0;

                txtQtde.Clear();
                txtValorTotalProd.Clear();
                txtValorTotalServico.Clear();
                txtValorTotalDesc.Clear();
                txtValorTotal.Clear();

                foreach (var item in ordemServicos)
                {
                    valorDesconto += item.ValorDesconto;
                    valorTotal += item.ValorTotal;
                    valorTotalServico += item.ValorTotalServico;
                    valorTotalProduto += item.ValorTotalProduto;
                }

                txtQtde.Text = ordemServicos.Count().ToString();
                txtValorTotalDesc.Text = valorDesconto.ToString("C");
                txtValorTotalServico.Text = valorTotalServico.ToString("C");
                txtValorTotalProd.Text = valorTotalProduto.ToString("C");
                txtValorTotal.Text = valorTotal.ToString("C");
            }
        }

        private void imprimirOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwOrdemSevicos.Items.Count > 0)
            {
                int ordemServicoId = int.Parse(lwOrdemSevicos.FocusedItem.SubItems[0].Text);

                FrmBaseImprimirOrdemServico frm = new FrmBaseImprimirOrdemServico();
                frm.CarregaReportComprovanteOrdemServico(ordemServicoId);

                frm.ShowDialog();
            }
        }

        private void txtDataFinal_ValueChanged_1(object sender, EventArgs e)
        {
            CarregaTodasOrdemServicos();
        }

        private void txtDataInicial_ValueChanged_1(object sender, EventArgs e)
        {
            CarregaTodasOrdemServicos();
        }

        private void FrmTodasOrdemServico_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmOrdemServico frmOrdemServico = new FrmOrdemServico();
            frmOrdemServico.ShowDialog();
            CarregaTodasOrdemServicos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
                        CarregaTodasOrdemServicos();
        }

        private void editarOrdemDeServiçoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwOrdemSevicos.Items.Count > 0)
            {
                int ordemServicoId = int.Parse(lwOrdemSevicos.FocusedItem.SubItems[0].Text);
                FrmOrdemServico frm = new FrmOrdemServico();
                frm.CarregaOrdemServicoEditar(ordemServicoId);
                frm.ShowDialog();
            }
        }
    }
}