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
    public partial class FrmFinalizarOrdemServicoVenda : Form
    {
        MeuDataContext meuDataContext;
        IList<FormaPagamentoOrdemServico> listaFormaPgtoOS = new List<FormaPagamentoOrdemServico>();
        FormaPagamentoOrdemServico formaPagamentoOrdemServico;

        //Tipo(Venda ou Ordem de Serviço)
        public string tipoFinalizacao;

        public decimal ValorPrincipal;

        bool isFocusCodigoTipoFormaPgto;
        bool isFocusValorPagando;

        public FrmFinalizarOrdemServicoVenda()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmFinalizarOrdemServicoVenda_Load(object sender, EventArgs e)
        {
            FrmFinalizarOrdemServicoVenda frm = new FrmFinalizarOrdemServicoVenda();
            frm.Text = "Finalizando " + tipoFinalizacao;
            lblValor.Text = "Valor da " + tipoFinalizacao;
            btnFinalizar.Text = "Finalizar " + tipoFinalizacao;
            CarregarListaTipoPagamento();
            txtCodigoTipoFormaPgto.Focus();
        }

        private void FrmFinalizarOrdemServicoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode == Keys.Enter)
            {
                if (isFocusCodigoTipoFormaPgto)
                {
                    txtPagando.Focus();
                    isFocusCodigoTipoFormaPgto = false;
                }
                else if (isFocusValorPagando)
                {
                    isFocusValorPagando = false;

                    formaPagamentoOrdemServico = new FormaPagamentoOrdemServico
                    {
                        DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")),
                        TipoFormaPagamentoId = int.Parse(txtCodigoTipoFormaPgto.Text),
                        Valor = Convert.ToDecimal(txtPagando.Text),
                    };


                    txtPagando.Text = Convert.ToDecimal(txtPagando.Text).ToString("N2");

                    listaFormaPgtoOS.Add(formaPagamentoOrdemServico);

                    txtPagando.Text = "0,00";
                    txtCodigoTipoFormaPgto.Clear();
                    txtCodigoTipoFormaPgto.Focus();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CarregarListaTipoPagamento()
        {
            var tipoFormaPagamentos = meuDataContext.TipoFormaPagamentos.AsNoTracking().OrderBy(tfp=> tfp.Id).ToList();

            if (tipoFormaPagamentos.Count > 0)
            {
                lwTipoFormaPagamentos.Items.Clear();
                int item = 0;

                foreach (var tipoFormaPagamento in tipoFormaPagamentos)
                {
                    lwTipoFormaPagamentos.Items.Add(tipoFormaPagamento.Id.ToString());
                    lwTipoFormaPagamentos.Items[item].SubItems.Add(tipoFormaPagamento.Nome);
                    item++;
                }
            }
        }

        private void txtCodigoTipoFormaPgto_Enter(object sender, EventArgs e)
        {
            isFocusCodigoTipoFormaPgto = true;
        }

        private void txtPagando_Enter(object sender, EventArgs e)
        {
            isFocusValorPagando = true;
        }
    }
}
