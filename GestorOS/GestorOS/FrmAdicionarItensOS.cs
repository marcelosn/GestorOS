using GestorOS.Models;
using System;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmAdicionarItensOS : Form
    {
        //Armazena-serviço ou produto e item ordem servico
        Produto produto;
        Servico servico;

        public OrdemServicoItem ordemServicoItem;
        decimal subTotal;

        bool isFocusQtde = false;
        bool isFocusValorDesconto = false;

        public FrmAdicionarItensOS()
        {
            InitializeComponent();
        }

        private void btnBuscarFuncionario_Click(object sender, EventArgs e)
        {
            FrmTodosFuncionarios frmTodosFuncionarios = new FrmTodosFuncionarios();
            frmTodosFuncionarios.ShowDialog();

            if (frmTodosFuncionarios.funcionario != null)
            {
                txtCodigoFuncionario.Text = frmTodosFuncionarios.funcionario.Id.ToString();
                txtNomeFuncionario.Text = frmTodosFuncionarios.funcionario.Nome;
            }
        }

        private void btnBuscarProdutoServico_Click(object sender, EventArgs e)
        {
            FrmBuscarProdutoServico frmBuscarProdutoServico = new FrmBuscarProdutoServico();
            frmBuscarProdutoServico.ShowDialog();

            if (frmBuscarProdutoServico.produto != null)
            {
                produto = frmBuscarProdutoServico.produto;
                txtCodProdServico.Text = frmBuscarProdutoServico.produto.Id.ToString();
                txtNomeProdutoServico.Text = frmBuscarProdutoServico.produto.Nome;
                txtValorUnitario.Text = frmBuscarProdutoServico.produto.PrecoVenda.ToString("C");
            }
            else if (frmBuscarProdutoServico.servico != null)
            {
                servico = frmBuscarProdutoServico.servico;
                txtCodProdServico.Text = frmBuscarProdutoServico.servico.Id.ToString();
                txtNomeProdutoServico.Text = frmBuscarProdutoServico.servico.Nome;
                txtValorUnitario.Text = frmBuscarProdutoServico.servico.Valor.ToString("C");
            }
            txtQtde.Text = "1";
            txtQtde.Focus();

            CalcularTotal();
        }


        private void CalcularTotal()
        {
            if (!string.IsNullOrWhiteSpace(txtQtde.Text))
            {
                int qtde = int.Parse(txtQtde.Text);
                decimal valorUnitario = Convert.ToDecimal(txtValorUnitario.Text.Substring(2));
                decimal desconto = txtValorDesconto.Text.Contains("R$") ? Convert.ToDecimal(txtValorDesconto.Text.Substring(2)) : Convert.ToDecimal(txtValorDesconto.Text);

                subTotal = (valorUnitario * qtde);

                decimal total = (subTotal - desconto);

                txtValorTotal.Text = total.ToString("C");
                txtValorDesconto.Text = desconto.ToString("C");
            }
            else
            {
                MessageBox.Show("Atenção! quantindade não pode ser zero", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtde.Focus();
            }
        }

        private void CalcularDesconto()
        {
            if (!string.IsNullOrEmpty(txtValorDesconto.Text))
            {
                CalcularTotal();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObrigatorios())
            {
                ordemServicoItem = new OrdemServicoItem()
                {
                    Item = 1,
                    Observacao = txtObservacaoItem.Text,
                    Qtde = int.Parse(txtQtde.Text),
                    ValorDesconto = Convert.ToDecimal(txtValorDesconto.Text.Substring(2)),
                    ValorUnitario = Convert.ToDecimal(txtValorUnitario.Text.Substring(2)),
                    ValorSubTotal = subTotal,
                    ValorTotal = Convert.ToDecimal(txtValorTotal.Text.Substring(2)),
                    ServicoId = servico == null ? Convert.ToInt32(null) : servico.Id,
                    ProdutoId = produto == null ? Convert.ToInt32(null) : produto.Id,
                    FuncionarioId = int.Parse(txtCodigoFuncionario.Text),
                    Produto = produto,
                    Servico = servico
                };

                this.Close();
            }
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(txtCodigoFuncionario.Text))
            {
                MessageBox.Show("Informe o nome do profissional que\n vai realizar o serviço.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarFuncionario.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodProdServico.Text))
            {
                MessageBox.Show("Informe o nome do serviço ou produto.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarProdutoServico.Focus();
                return false;
            }
            return true;
        }

        private void txtQtde_Enter(object sender, EventArgs e)
        {
            isFocusQtde = true;
        }

        private void txtValorDesconto_Enter(object sender, EventArgs e)
        {
            isFocusValorDesconto = true;
        }

        private void FrmAdicionarItensOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnSalvar_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (isFocusQtde)
                {
                    CalcularTotal();
                    isFocusQtde = false;
                    txtValorDesconto.Focus();
                }
                else if (isFocusValorDesconto)
                {
                    CalcularDesconto();
                    isFocusValorDesconto = false;
                    txtObservacaoItem.Focus();
                }
            }
        }
    }
}
