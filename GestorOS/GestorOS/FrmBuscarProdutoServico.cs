using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmBuscarProdutoServico : Form
    {
        MeuDataContext meuDataContext;
        public Produto produto;
        public Servico servico;

        public FrmBuscarProdutoServico()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmBuscarProdutoServico_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosServicosProdutos();
        }

        private void FrmBuscarProdutoServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosServicosProdutos();
        }

        private void lwProdutosServicos_DoubleClick(object sender, EventArgs e)
        {
            if (lwProdutosServicos.Items.Count > 0)
            {
                int codigo = int.Parse(lwProdutosServicos.FocusedItem.SubItems[0].Text);

                string tipo = lwProdutosServicos.FocusedItem.SubItems[2].Text;

                if (tipo.Equals("Serviço"))
                {
                    servico = meuDataContext.Servicos.Find(codigo);
                }
                else//Produto
                {
                    produto = meuDataContext.Produtos.Find(codigo);
                }

                this.Close();
            }
        }

        private void CarregarTodosServicosProdutos()
        {
            var servicos = meuDataContext.Servicos.AsNoTracking()
                                                .Where(s => s.Nome.Contains(txtBuscar.Text))
                                                .OrderBy(s => s.Nome).ToList();

            var produtos = meuDataContext.Produtos.AsNoTracking()
                                               .Where(s => s.Nome.Contains(txtBuscar.Text))
                                               .OrderBy(s => s.Nome).ToList();

            int item = 0;
            lwProdutosServicos.Items.Clear();

            if (servicos.Count > 0)
            {
                foreach (var servico in servicos)
                {
                    lwProdutosServicos.Items.Add(servico.Id.ToString());
                    lwProdutosServicos.Items[item].SubItems.Add(servico.Nome);
                    lwProdutosServicos.Items[item].SubItems.Add("Serviço");
                    lwProdutosServicos.Items[item].SubItems.Add(servico.Valor.ToString("C"));
                    item++;
                }
            }
            if (produtos.Count > 0)
            {
                foreach (var produto in produtos)
                {
                    lwProdutosServicos.Items.Add(produto.Id.ToString());
                    lwProdutosServicos.Items[item].SubItems.Add(produto.Nome);
                    lwProdutosServicos.Items[item].SubItems.Add("Produto");
                    lwProdutosServicos.Items[item].SubItems.Add(produto.PrecoVenda.ToString("C"));
                    item++;
                }
            }
        }
    }
}
