using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmBaseImprimirOrdemServico : Form
    {
        public FrmBaseImprimirOrdemServico()
        {
            InitializeComponent();
        }

        private void FrmBaseImprimirOrdemServico_Load(object sender, EventArgs e)
        {
        }

        public void CarregaReportComprovanteOrdemServico(int ordemServicoId)
        {

            //Cabeçalho
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("empresa","Ret CAR"));

            //Items da os
            DataSetGestorOS.OrdemServicoItem.AddOrdemServicoItemRow("1", "Formatação", "Luis Maia", "Serviço", "1", "100,00", "0,00", "100,00", "");
          
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
