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
                                             .AsNoTracking()
                                             .Include("Cliente")
                                             .Include("Objeto")
                                             .Where(os=> os.Id == ordemServicoId).FirstOrDefault();

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

            //Informaçoes - objeto
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Objeto", ordemServico.Objeto.Nome));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DescricaoProblema", ordemServico.DescricaoProblema));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Observacoes", ordemServico.Observacoes));

            //Informaçoes - cliente
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cliente", ordemServico.Cliente.NomeFantasia));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("DocumentoCliente", ordemServico.Cliente.Documento));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Email", ordemServico.Cliente.Email)) ;
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Celular", ordemServico.Cliente.Celular));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CepCliente", endereco.Cep));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("LogradouroCliente", endereco.Logradouro));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("NumeroCliente", endereco.Numero));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("BairroCliente",endereco.Bairro));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ComplementoCliente", endereco.Complemento));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CidadeCliente", endereco.Cidade));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("UFCliente", endereco.UF));

            //Informaçoes - valores
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ValorTotalProduto", ordemServico.ValorTotalProduto.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ValorTotalServico", ordemServico.ValorTotalServico.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ValorTotal", ordemServico.ValorTotal.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ValorAcrescimo", ordemServico.ValorAcrescimo.ToString("N2")));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("ValorDesconto", ordemServico.ValorDesconto.ToString("N2")));

            //Renderiza o report
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
    
    
    
    
    
    
    
    
    

