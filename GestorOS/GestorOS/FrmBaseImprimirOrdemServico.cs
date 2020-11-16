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
            var ordemServico = meuDataContext.OrdemServicos
                                             .Include("Cliente")
                                             .Include("Objeto")
                                             .Include("SituacaoOrdemServico")
                                             .AsNoTracking()
                                             .Where(os => os.Id == ordemServicoId).FirstOrDefault();

            var endereco = meuDataContext.Enderecos.AsNoTracking().Where(e => e.ClienteId == ordemServico.ClienteId).FirstOrDefault();

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
            
            //Cabeçalho - empresa
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("NumeroOS", Utilitarios.AdicionaZero(ordemServico.Id.ToString())));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Documento", empresa.Documento));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("RazaoSocial", empresa.RazaoSocial));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("NomeFantasia", empresa.NomeFantasia));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Cep", empresa.Cep));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Logradouro", empresa.Logradouro));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Numero", empresa.Numero));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Bairro", empresa.Bairro));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Cidade", empresa.Cidade));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("UF", empresa.UF));

            //Informaçoes - objeto e os
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("PrevisaoEntrega", ordemServico.DataPrevisaoEntrega.ToString("dd/MM/yyyy")));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Situacao", ordemServico.SituacaoOrdemServico.Nome));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Objeto", ordemServico.Objeto.Nome));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("DescricaoProblema", ordemServico.DescricaoProblema));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Observacoes", ordemServico.Observacoes));

            //Informaçoes - cliente
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Cliente", ordemServico.Cliente.NomeFantasia != null ? ordemServico.Cliente.NomeFantasia : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("DocumentoCliente", ordemServico.Cliente.Documento != null ? ordemServico.Cliente.Documento : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Email", ordemServico.Cliente.Email != null ? ordemServico.Cliente.Email : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("Celular", ordemServico.Cliente.Celular != null ? ordemServico.Cliente.Celular : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("CepCliente", endereco != null ? endereco.Cep : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("LogradouroCliente", endereco != null ? endereco.Logradouro : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("NumeroCliente", endereco != null ? endereco.Numero : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("BairroCliente", endereco != null ? endereco.Bairro : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ComplementoCliente", endereco != null ? endereco.Complemento : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("CidadeCliente", endereco != null ? endereco.Cidade : ""));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("UFCliente", endereco != null ? endereco.UF : ""));

            //Informaçoes - valores
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ValorTotalProduto", ordemServico.ValorTotalProduto.ToString("N2")));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ValorTotalServico", ordemServico.ValorTotalServico.ToString("N2")));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ValorTotal", ordemServico.ValorTotal.ToString("N2")));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ValorAcrescimo", ordemServico.ValorAcrescimo.ToString("N2")));
            this.reportViewOS.LocalReport.SetParameters(new ReportParameter("ValorDesconto", ordemServico.ValorDesconto.ToString("N2")));

            //Renderiza o report
            this.reportViewOS.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewOS.RefreshReport();
        }
    }
}










