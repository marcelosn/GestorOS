using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosProdutos : Form
    {
        MeuDataContext meuDataContext;
        public Produto produto;

        public FrmTodosProdutos()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodosProdutos_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosProdutos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }


        private void CarregarTodosProdutos()
        {
            var produtos = meuDataContext.Produtos
                                         .Include("UnidadeMedida")
                                         .AsNoTracking()
                                         .Where(p => p.Nome.Contains(txtBuscar.Text))
                                         .OrderBy(p => p.Nome).ToList();
            if (produtos.Count > 0)
            {
                lwProdutos.Items.Clear();
                int item = 0;

                foreach (var produto in produtos)
                {
                    lwProdutos.Items.Add(produto.Id.ToString());
                    lwProdutos.Items[item].SubItems.Add(produto.Nome);
                    lwProdutos.Items[item].SubItems.Add(produto.UnidadeMedida.Nome);
                    lwProdutos.Items[item].SubItems.Add(produto.PrecoVenda.ToString("N2"));
                    lwProdutos.Items[item].SubItems.Add(produto.PrecoCusto.ToString("N2"));
                    lwProdutos.Items[item].SubItems.Add(produto.QtdeMinima.ToString());
                    lwProdutos.Items[item].SubItems.Add(produto.QtdeMaxima.ToString());
                    lwProdutos.Items[item].SubItems.Add(produto.QtdeEstoque.ToString());
                    item++;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosProdutos();
        }

        private void FrmTodosProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                btnNovo_Click(this, e);
            }
        }

        private void lwProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (lwProdutos.Items.Count > 0)
            {
                int produtoId = int.Parse(lwProdutos.FocusedItem.SubItems[0].Text);

                produto = meuDataContext.Produtos.Find(produtoId);

                this.Close();
            }
        }
    }
}
