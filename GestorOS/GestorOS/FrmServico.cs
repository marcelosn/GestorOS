using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmServico : Form
    {
        MeuDataContext meuDataContext;
        Servico servico;

        public FrmServico()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (servico == null)
            {
                Salvar();
            }
            else
            {
                Alterar();
            }
        }

        private void Salvar()
        {
            if (ValidarCamposObrigatorios())
            {
                var servico = new Servico
                {
                    Nome = txtDescricao.Text,
                    DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy")),
                    Valor = Convert.ToDecimal(txtValor.Text),
                    PercentualValorComissão = string.IsNullOrEmpty(txtValorComissao.Text) ? Convert.ToDecimal(null) : Convert.ToDecimal(txtValorComissao.Text),
                    PercentualComissao = string.IsNullOrEmpty(txtComissao.Text) ? "0%" : txtComissao.Text + "%",
                    UnidadeMedidaId = Convert.ToInt32(txtUnidadeMedida.SelectedValue)
                };

                meuDataContext.Servicos.Add(servico);
                meuDataContext.SaveChanges();

                Mensagem.MensgemSucesso("Serviço");
                this.Close();
            }
        }

        private void Alterar()
        {
            if (ValidarCamposObrigatorios())
            {
                servico.Nome = txtDescricao.Text;
                servico.Valor = Convert.ToDecimal(txtValor.Text);
                servico.PercentualValorComissão = string.IsNullOrEmpty(txtValorComissao.Text) ? Convert.ToDecimal(null) : Convert.ToDecimal(txtValorComissao.Text);
                servico.PercentualComissao = string.IsNullOrEmpty(txtComissao.Text) ? "0%" : txtComissao.Text + "%";

                meuDataContext.SaveChanges();

                Mensagem.MensgemAlteracao("Serviço");

                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmServico_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if(e.KeyCode== Keys.F4)
            {
                btnSalvar_Click(this, e);
            }
        }

        private void FrmServico_Load(object sender, EventArgs e)
        {
            txtDescricao.Focus();
            CarregarUnidadeMedidas();
        }

        private Boolean ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Atenção! Informe o campo nome do serviço.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }
            if(txtUnidadeMedida.SelectedIndex == 0)
            {
                MessageBox.Show("Atenção! Informe o campo unidade de medida", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnidadeMedida.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                MessageBox.Show("Atenção! Informe o campo valor do serviço.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return false;
            }
            return true;
        }

        private void CarregarUnidadeMedidas()
        {
            var unidades = meuDataContext.UnidadeMedidas.AsNoTracking().OrderBy(u => u.Nome).ToList();

            if (unidades.Count > 0)
            {
                txtUnidadeMedida.DataSource = unidades;
                txtUnidadeMedida.DisplayMember = "Nome";
                txtUnidadeMedida.ValueMember = "Id";
                txtUnidadeMedida.Text = "SERVIÇO";
            }
        }

        private void btnAdicionarUnidade_Click(object sender, EventArgs e)
        {
            //FrmUnidadeMedida frmUnidadeMedida = new FrmUnidadeMedida();
            //frmUnidadeMedida.ShowDialog();
            //CarregarUnidadeMedidas();
            //txtUnidadeMedida.Text = frmUnidadeMedida.nomeUnidadeMedida;
        }

        private void txtComissao_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValor.Text) && !string.IsNullOrEmpty(txtComissao.Text))
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
                decimal percentual = Convert.ToDecimal(txtComissao.Text);

                decimal valorPercentual = ((valor * percentual) / 100);

                txtValorComissao.Text = valorPercentual.ToString("N2");
            }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("N2");
            }
        }

        public void CarregaServicoEditar(int servicoId)
        {
            servico = new Servico();

            servico = meuDataContext.Servicos.Find(servicoId);

            if (servico != null)
            {
                txtDescricao.Text = servico.Nome;
                txtUnidadeMedida.SelectedValue = servico.UnidadeMedidaId;
                txtValor.Text = servico.Valor.ToString("N2");
                txtComissao.Text = servico.PercentualComissao;
                txtValorComissao.Text = Convert.ToDecimal(servico.PercentualValorComissão).ToString("N2");
            }
        }
    }
}
