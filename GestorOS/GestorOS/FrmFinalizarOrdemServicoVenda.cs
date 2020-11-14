using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmFinalizarOrdemServicoVenda : Form
    {
        MeuDataContext meuDataContext;
         public IList<FormaPagamentoOrdemServico> listaFormaPgtoOS = new List<FormaPagamentoOrdemServico>();
        FormaPagamentoOrdemServico formaPagamentoOrdemServico;
        TipoFormaPagamento tipoFormaPagamento;

        //Tipo(Venda ou Ordem de Serviço)
        public string tipoFinalizacao;

        public decimal valorPrincipal;
        public decimal valorRecebido;
        public decimal subTotal;
        public decimal valorFinalVenda;
        public decimal valorFaltando;

        bool isFocusCodigoTipoFormaPgto;
        bool isFocusValorPagando;
        bool isFocusDesconto;
        public bool isFinalizar;

        public FrmFinalizarOrdemServicoVenda()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmFinalizarOrdemServicoVenda_Load(object sender, EventArgs e)
        {
            FrmFinalizarOrdemServicoVenda frm = new FrmFinalizarOrdemServicoVenda();
            frm.Text = "Finalizando " + tipoFinalizacao;
            btnFinalizarSalvar.Text = "Finalizar " + tipoFinalizacao + " - F4";
            CarregarListaTipoPagamento();
            txtCodigoTipoFormaPgto.Focus();
        }

        private void FrmFinalizarOrdemServicoVenda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F4)
            {
                btnFinalizarSalvar_Click(this, e);
            }
            if (e.KeyCode == Keys.F8)
            {
                btnAplicarDesconto_Click(this, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (isFocusCodigoTipoFormaPgto)
                {
                    if (!string.IsNullOrEmpty(txtCodigoTipoFormaPgto.Text))
                    {
                        txtPagando.Focus();
                        isFocusCodigoTipoFormaPgto = false;
                        tipoFormaPagamento = meuDataContext.TipoFormaPagamentos.Find(int.Parse(txtCodigoTipoFormaPgto.Text));

                        if (tipoFormaPagamento == null)
                        {
                            txtCodigoTipoFormaPgto.Focus();
                            txtCodigoTipoFormaPgto.Clear();
                            MessageBox.Show("Atenção! O código informado pra tipo de pagamento não existe. Tente outro código por gentileza" +
                                "", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Atenção! Informe o códido para o tipo de pagamento.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigoTipoFormaPgto.Focus();
                    }
                }
                else if (isFocusDesconto)
                {
                    //CalcularDesconto();
                }
                else if (isFocusValorPagando)
                {
                    isFocusValorPagando = false;

                    formaPagamentoOrdemServico = new FormaPagamentoOrdemServico
                    {
                        Id = tipoFormaPagamento.Id,
                        DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")),
                        TipoFormaPagamentoId = tipoFormaPagamento.Id,
                        Valor = Convert.ToDecimal(txtPagando.Text),

                        TipoFormaPagamento = new TipoFormaPagamento()
                        {
                            Id = tipoFormaPagamento.Id,
                            Nome = tipoFormaPagamento.Nome
                        }
                    };

                    txtPagando.Text = Convert.ToDecimal(txtPagando.Text).ToString("N2");

                    IncluirTipoFormaPagamentos();
                    ExibeSumarizadores();
                    CalcularTotal();

                    txtPagando.Text = "0,00";
                    txtCodigoTipoFormaPgto.Clear();
                    txtCodigoTipoFormaPgto.Focus();
                }
            }
        }

        private void ExibeSumarizadores()
        {
            if (listaFormaPgtoOS.Count != 0)
            {
                valorRecebido = 0;
                subTotal = 0;
                valorFaltando = 0;
                valorFinalVenda = 0;
                txtValorRecebido.Clear();
                txtSubTotal.Text = "0,00";
                txtValorFaltando.Text = "0,00";
                txtDesconto.Text = "0,00";
                txtValorFinalVenda.Text = "0,00";
                txtValorFinalVenda.Text = "0,00";
                btnFinalizarSalvar.Enabled = true;

                foreach (var item in listaFormaPgtoOS)
                {
                    valorRecebido += item.Valor;
                    subTotal += item.Valor;
                }

                txtValorRecebido.Text = valorRecebido.ToString("N2");
            }
        }

        private void IncluirTipoFormaPagamentos()
        {
            var removeItemFormaPgto = listaFormaPgtoOS.Where(f => f.Id == formaPagamentoOrdemServico.Id).FirstOrDefault();

            listaFormaPgtoOS.Remove(removeItemFormaPgto);

            lwPagamentosOrdemServico.Items.Clear();
            int item = 0;

            if (formaPagamentoOrdemServico.Valor > 0)
            {
                listaFormaPgtoOS.Add(formaPagamentoOrdemServico);
            }

            if (listaFormaPgtoOS.Count > 0)
            {
                foreach (var itemTipoPagto in listaFormaPgtoOS)
                {
                    lwPagamentosOrdemServico.Items.Add(itemTipoPagto.TipoFormaPagamento.Nome);
                    lwPagamentosOrdemServico.Items[item].SubItems.Add(itemTipoPagto.Valor.ToString("N2"));
                    item++;
                }
            }
        }

        private void CarregarListaTipoPagamento()
        {
            var tipoFormaPagamentos = meuDataContext.TipoFormaPagamentos.AsNoTracking().OrderBy(tfp => tfp.Id).ToList();

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

        private void CalcularTotal()
        {
            if (!string.IsNullOrWhiteSpace(txtPagando.Text))
            {
                valorPrincipal = Convert.ToDecimal(txtValorPrincipal.Text);
                subTotal = valorRecebido;

                valorFaltando = (valorPrincipal - valorRecebido); ;
                valorFinalVenda = subTotal;

                txtValorFaltando.Text = valorFaltando.ToString("N2");
                txtSubTotal.Text = subTotal.ToString("N2");

                if (txtValorPrincipal.Text == txtValorRecebido.Text)
                {
                    txtValorFinalVenda.Text = valorFinalVenda.ToString("N2");
                }
            }
            else
            {
                MessageBox.Show("Atenção! quantindade não pode ser zero", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagando.Focus();
            }
        }

        private void CalcularDesconto()
        {
            if (!string.IsNullOrEmpty(txtDesconto.Text))
            {
                isFocusDesconto = false;
                txtDesconto.ReadOnly = true;
                txtCodigoTipoFormaPgto.Focus();
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

        private void btnFinalizarSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma a finalização desta " + tipoFinalizacao + " ?", "Mensgem sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isFinalizar = true;
                this.Close();
            }
        }

        private void btnAplicarDesconto_Click(object sender, EventArgs e)
        {
            //isFocusCodigoTipoFormaPgto = false;
            //txtDesconto.ReadOnly = false;
            //txtDesconto.Focus();
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            isFocusDesconto = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
