using GestorOS.App;
using GestorOS.Data;
using Microsoft.Reporting.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmBaseImprimirOrdemServico : Form
    {
        MeuDataContext meuDataContext;

        public FrmBaseImprimirOrdemServico()
        {
            meuDataContext = new MeuDataContext();
            InitializeComponent();
        }

        private void FrmBaseImprimirOrdemServico_Load(object sender, EventArgs e)
        {
        }

        public void CarregaReportComprovanteOrdemServico(int ordemServicoId)
        {
            var ordemServico = meuDataContext.OrdemServicos.Find(ordemServicoId);

            var ordemServicoItens = meuDataContext.OrdemServicoItems
                                                  .Include("Produto")
                                                  .Include("Servico")
                                                  .Include("Funcionario")
                                                  .AsNoTracking()
                                                  .Where(osi => osi.OrdemServicoId == ordemServico.Id).ToList();

            var empresa = meuDataContext.Empresas.Take(1).FirstOrDefault();

            int itemCount = 1;

            //Items da os
            foreach (var item in ordemServicoItens)
            {
                string descricaoServicoOrProduto = item.ServicoId != null ? item.Servico.Nome : item.Produto.Nome;
                string tipoServicoOrProduto = item.ServicoId != null ? "Serviço" : "Produto";

                DataSetGestorOS.OrdemServicoItem.AddOrdemServicoItemRow(itemCount.ToString(),
                                                                        descricaoServicoOrProduto,
                                                                        item.Funcionario.Nome,
                                                                        tipoServicoOrProduto, item.Qtde.ToString(),
                                                                        item.ValorUnitario.ToString("N2"),
                                                                        item.ValorDesconto.ToString("N2"),
                                                                        item.ValorTotal.ToString("N2"), "");
                itemCount++;
            }

            //Cabeçalho da ordem de serviço
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("NumeroOS", Utilitarios.AdicionaZero(ordemServico.Id.ToString())));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Documento", empresa.Documento));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("RazaoSocial", empresa.RazaoSocial));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("NomeFantasia", empresa.NomeFantasia));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cep", empresa.Cep));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Logradouro", empresa.Logradouro));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Numero", empresa.Numero));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Bairro", empresa.Bairro));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cidade", empresa.Cidade));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("UF", empresa.UF));

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
