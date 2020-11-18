using GestorOS.App;
using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmProduto : Form
    {
        MeuDataContext meuDataContext;
        Produto produto;
        bool isFocusPrecoVenda;
        bool isFocusMargemLucro;

        public FrmProduto()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        public void CarregaProdutoEditar(int produtoId)
        {
            produto = new Produto();

            produto = meuDataContext.Produtos.Find(produtoId);

            if (produto != null)
            {
                txtNomeProduto.Text = produto.Nome;
                txtUnidadeMedida.SelectedValue = produto.UnidadeMedidaId;
                txtDescricao.Text = produto.DescricaoGeral;
                txtCodigoBarra.Text = Utilitarios.AdicionaZeroCodigoBarra(produto.CodigoBarra);
                txtValorCusto.Text = produto.PrecoCusto.ToString("N2");
                txtValorVenda.Text = produto.PrecoVenda.ToString("N2");
                txtMargemLucro.Text = produto.MargemLucro;
                txtQtdeMinima.Text = produto.QtdeMinima.ToString();
                txtQtdeMaxima.Text = produto.QtdeMaxima.ToString();
                txtQtdeEstoque.Text = produto.QtdeEstoque.ToString();
            }
        }

        private void CarregarUnidadeMedidas()
        {
            var unidades = meuDataContext.UnidadeMedidas.AsNoTracking().OrderBy(u => u.Nome).ToList();

            if (unidades.Count > 0)
            {
                txtUnidadeMedida.DataSource = unidades;
                txtUnidadeMedida.DisplayMember = "Nome";
                txtUnidadeMedida.ValueMember = "Id";
                txtUnidadeMedida.Text = "UNIDADE";
            }
        }

        private int RetornaUltimoIdProduto()
        {
            var produto = meuDataContext.Produtos.Take(1).OrderByDescending(o => o.Id).FirstOrDefault();
            return produto == null ? 1 : produto.Id + 1;
        }

        private void Salvar()
        {
            if (ValidarCamposObrigatorios())
            {
                produto = new Produto();

                produto.Nome = txtNomeProduto.Text;
                produto.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                produto.UnidadeMedidaId = Convert.ToInt32(txtUnidadeMedida.SelectedValue);
                produto.DescricaoGeral = string.IsNullOrEmpty(txtDescricao.Text) ? null : txtDescricao.Text;
                produto.CodigoBarra = string.IsNullOrEmpty(txtCodigoBarra.Text) ? Utilitarios.AdicionaZeroCodigoBarra(RetornaUltimoIdProduto().ToString()) : txtCodigoBarra.Text;
                produto.PrecoCusto = Convert.ToDecimal(txtValorCusto.Text);
                produto.PrecoVenda = Convert.ToDecimal(txtValorVenda.Text);
                produto.MargemLucro = txtMargemLucro.Text;
                produto.QtdeMinima = Convert.ToInt32(txtQtdeMinima.Text);
                produto.QtdeMaxima = Convert.ToInt32(txtQtdeMaxima.Text);
                produto.QtdeEstoque = string.IsNullOrEmpty(txtQtdeEstoque.Text) ? 0 : Convert.ToInt32(txtQtdeEstoque.Text);

                meuDataContext.Produtos.Add(produto);
                meuDataContext.SaveChanges();

                Mensagem.MensgemSucesso("Produto");
                this.Close();
            }
        }

        private void Alterar()
        {
            if (ValidarCamposObrigatorios())
            {
                produto.Nome = txtNomeProduto.Text;
                produto.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                produto.UnidadeMedidaId = Convert.ToInt32(txtUnidadeMedida.SelectedValue);
                produto.DescricaoGeral = string.IsNullOrEmpty(txtDescricao.Text) ? null : txtDescricao.Text;
                produto.CodigoBarra = Utilitarios.AdicionaZeroCodigoBarra(txtCodigoBarra.Text);
                produto.PrecoCusto = Convert.ToDecimal(txtValorCusto.Text);
                produto.PrecoVenda = Convert.ToDecimal(txtValorVenda.Text);
                produto.MargemLucro = txtMargemLucro.Text;
                produto.QtdeMinima = int.Parse(txtQtdeMinima.Text);
                produto.QtdeMaxima = int.Parse(txtQtdeMaxima.Text);
                produto.QtdeEstoque = int.Parse(txtQtdeEstoque.Text);

                meuDataContext.SaveChanges();

                Mensagem.MensgemAlteracao("Produto");

                this.Close();
            }
        }

        private Boolean ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("Informe o campo nome do produto.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProduto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtValorCusto.Text))
            {
                MessageBox.Show("Informe o campo preço de custo do produto.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCusto.Focus();
                return false;
            }
            if (Convert.ToDecimal(txtValorCusto.Text) <= 0)
            {
                MessageBox.Show("Atenção! o campo preço de custo do produto não pode ser zero", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCusto.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtValorVenda.Text))
            {
                MessageBox.Show("Atenção! Informe o campo preço de venda do produto.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorVenda.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMargemLucro.Text))
            {
                MessageBox.Show("Atenção! Informe o campo margem de lucro do produto.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMargemLucro.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQtdeMinima.Text))
            {
                MessageBox.Show("Atenção! Informe o campo quantidade mínima do produto para estoque.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdeMinima.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtQtdeMaxima.Text))
            {
                MessageBox.Show("Atenção! Informe o campo quantidade máxima do produto para estoque.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdeMaxima.Focus();
                return false;
            }
            return true;
        }

        private void FrmProduto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (isFocusMargemLucro)
                {
                    isFocusMargemLucro = false;
                    CalcularValorVendaOrMargemLucro();
                }
                else if (isFocusPrecoVenda)
                {
                    isFocusPrecoVenda = false;
                    CalcularValorVendaOrMargemLucro();
                }
            }
            if (e.KeyCode == Keys.F4)
            {
                btnSalvar_Click(this, e);
            }
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            txtNomeProduto.Focus();
            CarregarUnidadeMedidas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (produto == null)
            {
                Salvar();
            }
            else
            {
                Alterar();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CalcularValorVendaOrMargemLucro()
        {
            if (!string.IsNullOrEmpty(txtValorCusto.Text) && Convert.ToDecimal(txtValorCusto.Text) > 0)
            {
                if (!string.IsNullOrEmpty(txtMargemLucro.Text))
                {
                    decimal valorCusto = Convert.ToDecimal(txtValorCusto.Text);
                    decimal juros = Convert.ToDecimal(txtMargemLucro.Text);

                    decimal valorLucro = ((valorCusto * juros) / 100);
                    decimal valorVenda = (valorCusto + valorLucro);

                    txtValorVenda.Text = valorVenda.ToString("N2");
                    txtValorVenda.Focus();
                }
                if (!string.IsNullOrEmpty(txtValorVenda.Text) && Convert.ToDecimal(txtValorVenda.Text) > 0)
                {
                    decimal valorVenda = Convert.ToDecimal(txtValorVenda.Text);
                    decimal valorCusto = Convert.ToDecimal(txtValorCusto.Text);
                    decimal portacentagem = (valorVenda / valorCusto) - 1;

                    portacentagem = (portacentagem * 100);

                    txtMargemLucro.Text = portacentagem.ToString("N");

                    txtMargemLucro.Focus();
                }
            }
            else
            {
                MessageBox.Show("Atenção! Informe o campo preço de custo do produto.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCusto.Focus();
            }
        }

        private void txtValorCusto_Leave(object sender, EventArgs e)
        {
            txtValorCusto.Text = string.IsNullOrEmpty(txtValorCusto.Text) ? null : Convert.ToDecimal(txtValorCusto.Text).ToString("N2");
        }

        private void txtValorVenda_Leave(object sender, EventArgs e)
        {
            txtValorVenda.Text = string.IsNullOrEmpty(txtValorVenda.Text) ? null : Convert.ToDecimal(txtValorVenda.Text).ToString("N2");
        }

        private void txtValorVenda_Enter(object sender, EventArgs e)
        {
            isFocusPrecoVenda = true;
        }

        private void txtMargemLucro_Enter(object sender, EventArgs e)
        {
            isFocusMargemLucro = true;
        }
    }
}
