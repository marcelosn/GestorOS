using GestorOS.Data;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmPrincipal : Form
    {
        MeuDataContext meuDataContext;

        public FrmPrincipal()
        {
            InitializeComponent();

            foreach (ToolStripItem item in toolStripBarraMenus.Items)
            {
                meuDataContext = new MeuDataContext();
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void tsOrdemServico_Click(object sender, EventArgs e)
        {
            FrmTodasOrdemServico frmTodasOrdemServico = new FrmTodasOrdemServico();
            frmTodasOrdemServico.ShowDialog();
        }

        private void tsClientes_Click(object sender, EventArgs e)
        {
            FrmTodosClientes frmTodosClientes = new FrmTodosClientes();
            frmTodosClientes.ShowDialog();
        }

        private void tsProdutos_Click(object sender, EventArgs e)
        {
            FrmTodosProdutos frm = new FrmTodosProdutos();
            frm.ShowDialog();
        }

        private void tsServicos_Click(object sender, EventArgs e)
        {
            FrmTodosServicos frm = new FrmTodosServicos();
            frm.ShowDialog();
        }

        private void tsFuncionarios_Click(object sender, EventArgs e)
        {
            FrmTodosFuncionarios frmTodosFuncionarios = new FrmTodosFuncionarios();
            frmTodosFuncionarios.ShowDialog();
        }

        private void tsUnidadeMedida_Click(object sender, EventArgs e)
        {
            FrmTodosUnidadeMedidas frm = new FrmTodosUnidadeMedidas();
            frm.ShowDialog();
        }

        private void tsObjetos_Click(object sender, EventArgs e)
        {
            FrmTodosObjetos frmTodosObjetos = new FrmTodosObjetos();
            frmTodosObjetos.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregaDadosRegistroSotware();
        }

        private void CarregaDadosRegistroSotware()
        {
            var empresa = meuDataContext.Empresas.Take(1).FirstOrDefault();

            if (empresa != null)
            {
                toolStripStatusLabelRegistradoPara.Text = " | Software registrado para: " + empresa.NomeFantasia + " - CNPJ: " + empresa.Documento;
            }
            else
            {
                MessageBox.Show("ATENÇAO!\n\n Este Software não foi registrado. Favor entrar em contato com " +
                                "o administrador do sistema  através do contato\n\nDesenvolvedor: Luís Antônio Oliveira Maia\nCelular: (69)99271-8454",
                                "Mensagem do Desenvolvedor", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frm = new FrmCliente();
            frm.ShowDialog();
        }
    }
}
