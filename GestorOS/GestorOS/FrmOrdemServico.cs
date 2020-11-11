﻿using GestorOS.App;
using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmOrdemServico : Form
    {
        MeuDataContext meuDataContext;
        IList<OrdemServicoItem> listaItemOrdemServico = new List<OrdemServicoItem>();
        int item = 1;
        int codigoOperador = 2;
        int qtde;
        decimal valorTotalServico;
        decimal valorTotalProduto;
        decimal valorUnitario;
        decimal valorSubTotal;
        decimal valorDesconto;
        decimal valorTotal;
        string nomeOperador = "Operador padrão";

        public FrmOrdemServico()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmOrdemServico_Load(object sender, EventArgs e)
        {
            IniciarNovaOrdemServico();
            txtCodigoOperador.Text = codigoOperador.ToString();
            txtNomeOperador.Text = nomeOperador;
        }

        private void IniciarNovaOrdemServico()
        {
            txtNumeroOS.Text = Utilitarios.AdicionaZero(RetornaUltimoIdOrdemServico().ToString());
            txtDataAbertura.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtCodigoOperador.Text = codigoOperador.ToString();
            txtNomeOperador.Text = nomeOperador;
            txtDataPrevisaoEntrega.Focus();
            btnRemoverItem.Enabled = false;
            btnSalvar.Enabled = false;
            btnSalvar.Enabled = false;
            CarregaSituacaoOrdemServico();
        }

        private void CarregaSituacaoOrdemServico()
        {
            var situacoes = meuDataContext.SituacaoOrdemServicos.AsNoTracking().OrderBy(s => s.Nome).ToList();

            if (situacoes.Count > 0)
            {
                txtSituacao.DataSource = situacoes;
                txtSituacao.ValueMember = "Id";
                txtSituacao.DisplayMember = "Nome";
                txtSituacao.Text = "INICIADA";
            }
        }

        private int RetornaUltimoIdOrdemServico()
        {
            var ordemServico = meuDataContext.OrdemServicos.Take(1).OrderByDescending(o => o.Id).FirstOrDefault();
            return ordemServico == null ? 1 : ordemServico.Id + 1;
        }

        private void FrmOrdemServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.F1)
            {
                btnAdicionarProdSerc_Click(this, e);
            }
            if (e.KeyCode == Keys.F4)
            {
            }
        }

        private void btnAdicionarProdSerc_Click(object sender, EventArgs e)
        {
            FrmAdicionarItensOS frmAdicionarItensOS = new FrmAdicionarItensOS();
            frmAdicionarItensOS.ShowDialog();

            if (frmAdicionarItensOS.ordemServicoItem != null)
            {
                frmAdicionarItensOS.ordemServicoItem.Item = item;

                listaItemOrdemServico.Add(frmAdicionarItensOS.ordemServicoItem);

                AdicionarItens();

                item++;
            }
            else
            {
                AdicionarItens();
            }
        }

        private void AdicionarItens()
        {
            lwItensOrdemServico.Items.Clear();

            for (int i = 0; i < listaItemOrdemServico.Count; i++)
            {
                lwItensOrdemServico.Items.Add(listaItemOrdemServico[i].Item.ToString());

                if (listaItemOrdemServico[i].Produto != null)
                {
                    lwItensOrdemServico.Items[i].SubItems.Add("Produto");
                    lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].Produto.Id.ToString());
                    lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].Produto.Nome);
                }

                if (listaItemOrdemServico[i].Servico != null)
                {
                    lwItensOrdemServico.Items[i].SubItems.Add("Serviço");
                    lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].ServicoId.ToString());
                    lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].Servico.Nome);
                }

                lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].Qtde.ToString());
                lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].ValorUnitario.ToString("C"));
                lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].ValorSubTotal.ToString("C"));
                lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].ValorDesconto.ToString("C"));
                lwItensOrdemServico.Items[i].SubItems.Add(listaItemOrdemServico[i].ValorTotal.ToString("C"));

                //Habilita comandos basicos
                btnSalvar.Enabled = true;
                btnSalvar.Enabled = true;
                btnRemoverItem.Enabled = true;

                //Totalizadores
                CalcularTotalizadores();
            }
        }

        private void CalcularTotalizadores()
        {
            if (listaItemOrdemServico.Count != 0)
            {
                qtde = 0;
                valorUnitario = 0;
                valorSubTotal = 0;
                valorDesconto = 0;
                valorTotal = 0;
                valorTotalProduto = 0;
                valorTotalServico = 0;

                txtTotallQtdeItem.Clear();
                txtTotalValorUnitario.Clear();
                txtTotalSubTotal.Clear();
                txtTotalDesconto.Clear();
                txtValorTotal.Clear();

                foreach (var item in listaItemOrdemServico)
                {
                    qtde += item.Qtde;
                    valorUnitario += item.ValorUnitario;
                    valorSubTotal += item.ValorSubTotal;
                    valorDesconto += item.ValorDesconto;
                    valorTotal += item.ValorTotal;
                    valorTotalServico += item.ServicoId != 0 ? item.ValorTotal : Convert.ToDecimal(null);
                    valorTotalProduto += item.ProdutoId != 0 ? item.ValorTotal : Convert.ToDecimal(null);
                }

                txtTotallQtdeItem.Text = qtde.ToString();
                txtTotalValorUnitario.Text = valorUnitario.ToString("C");
                txtTotalSubTotal.Text = valorSubTotal.ToString("C");
                txtTotalDesconto.Text = valorDesconto.ToString("C");
                txtValorTotal.Text = valorTotal.ToString("C");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //FrmTodosClientes frmTodosClientes = new FrmTodosClientes();
            //frmTodosClientes.ShowDialog();

            //if (frmTodosClientes.cliente != null)
            //{
            //    txtCodigoCliente.Text = frmTodosClientes.cliente.Id.ToString();
            //    txtNomeCliente.Text = frmTodosClientes.cliente.NomeFantasia;
            //    txtCelular.Text = frmTodosClientes.cliente.Celular;
            //    txtDocumentoCliente.Text = frmTodosClientes.cliente.Documento;
            //}
        }

        private void btnBuscarObjeto_Click(object sender, EventArgs e)
        {
            //FrmTodosObjetos frmTodosObjetos = new FrmTodosObjetos();
            //frmTodosObjetos.ShowDialog();

            //if (frmTodosObjetos.objeto != null)
            //{
            //    txtCodigoEquipamento.Text = frmTodosObjetos.objeto.Id.ToString();
            //    txtNomeObjetoEquipamento.Text = frmTodosObjetos.objeto.Nome;
            //}
        }

        private void btnRemoverItem_Click(object sender, EventArgs e)
        {
            if (lwItensOrdemServico.Items.Count > 0 && lwItensOrdemServico.CheckBoxes == true)
            {
                if (MessageBox.Show("Deseja realizar esta ação ?", "Mensgem sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < lwItensOrdemServico.Items.Count; i++)
                    {
                        if (lwItensOrdemServico.Items[i].Checked == true)
                        {
                            int item = int.Parse(lwItensOrdemServico.Items[i].SubItems[0].Text);

                            var ordemServicoItem = listaItemOrdemServico.Where(a => a.Item == item).FirstOrDefault();

                            listaItemOrdemServico.Remove(ordemServicoItem);
                        }
                    }
                    ckSelecionarTodosItens.Checked = false;
                    MessageBox.Show("Remoção realizada com sucesso", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AdicionarItens();
                }
            }
            else
            {
                MessageBox.Show("Selecione ao menos um item para ser removido", "Mensagem sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void LimparTodosCamposFormulario()
        {
            qtde = 0;
            valorUnitario = 0;
            valorSubTotal = 0;
            valorDesconto = 0;
            valorDesconto = 0;
            valorTotal = 0;
            valorTotalProduto = 0;
            valorTotalServico = 0;

            txtTotallQtdeItem.Clear();
            txtTotalValorUnitario.Clear();
            txtTotalSubTotal.Clear();
            txtTotalDesconto.Clear();
            txtValorTotal.Clear();
            txtCodigoCliente.Clear();
            txtNomeCliente.Clear();
            txtCelular.Clear();
            txtDocumento.Clear();
            txtCodigoObjeto.Clear();
            txtNomeObjeto.Clear();

            lwItensOrdemServico.Items.Clear();

            listaItemOrdemServico = new List<OrdemServicoItem>();

            item = 1;
        }

        private void ckSelecionarTodosItens_CheckedChanged(object sender, EventArgs e)
        {
            if (lwItensOrdemServico.Items.Count > 0)
            {
                if (ckSelecionarTodosItens.Checked == true)
                {
                    for (int i = 0; i < lwItensOrdemServico.Items.Count; i++)
                    {
                        lwItensOrdemServico.Items[i].Checked = true;
                    }
                }
                else
                {
                    for (int i = 0; i < lwItensOrdemServico.Items.Count; i++)
                    {
                        lwItensOrdemServico.Items[i].Checked = false;
                    }
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente salvar esta ordem de serviço ?", "Mensgem sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ValidarCamposObrigatorios())
                {
                    SalvarOrdemServico();

                    if (MessageBox.Show("Ordem de serviço salva com sucesso. \n\nDeseja iniciar uma nova ordem de serviço ?", "Mensgem sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimparTodosCamposFormulario();
                        IniciarNovaOrdemServico();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }

        private void SalvarOrdemServico()
        {
            var ordemServico = new OrdemServico()
            {
                FormaPagamentoId = null,
                ClienteId = Convert.ToInt32(txtCodigoCliente.Text),
                DataPrevisaoEntrega = Convert.ToDateTime(txtDataPrevisaoEntrega.Text),
                DescricaoProblema = txtDescricaoDefeito.Text,
                Observacoes = txtObservacoesGerais.Text,
                OperadorId = Convert.ToInt32(txtCodigoOperador.Text),
                ObjetoId = Convert.ToInt32(txtCodigoObjeto.Text),
                SituacaoOrdemServicoId = Convert.ToInt32(txtSituacao.SelectedValue),
                ValorTotalServico = valorTotalServico,
                ValorTotalProduto = valorTotalProduto,
                ValorAcrescimo = Convert.ToDecimal(null),
                ValorDesconto = valorDesconto,
                ValorTotal = valorTotal,
                DataHoraCadastro = Convert.ToDateTime(txtDataAbertura.Text)
            };

            meuDataContext.OrdemServicos.Add(ordemServico);
            meuDataContext.SaveChanges();

            SalvarOrdemServicoItem(ordemServico.Id);
        }

        private void SalvarOrdemServicoItem(int ordemServicoId)
        {
            foreach (var item in listaItemOrdemServico)
            {
                var ordemServicoItem = new OrdemServicoItem()
                {
                    OrdemServicoId = ordemServicoId,
                    Item = item.Item,
                    FuncionarioId = item.FuncionarioId,
                    Observacao = item.Observacao,
                    ProdutoId = item.Produto != null ? item.ProdutoId : null,
                    ServicoId = item.Servico != null ? item.ServicoId : null,
                    ValorSubTotal = item.ValorSubTotal,
                    ValorDesconto = item.ValorDesconto,
                    ValorUnitario = item.ValorUnitario,
                    ValorTotal = item.ValorTotal,
                    Qtde = item.Qtde
                };

                meuDataContext.OrdemServicoItems.Add(ordemServicoItem);
                meuDataContext.SaveChanges();
            }
        }

        public bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(txtCodigoCliente.Text))
            {
                MessageBox.Show("Informe o cliente.", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarCliente.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodigoObjeto.Text))
            {
                MessageBox.Show("Informe objeto (equipamento)", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnBuscarObjeto.Focus();
                return false;
            }

            return true;
        }
    }
}