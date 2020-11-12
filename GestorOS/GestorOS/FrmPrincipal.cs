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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            foreach (ToolStripItem item in toolStripBarraMenus.Items)
            {
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
            
        }

        private void tsServicos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsFuncionarios_Click(object sender, EventArgs e)
        {
            FrmTodosFuncionarios frmTodosFuncionarios = new FrmTodosFuncionarios();
            frmTodosFuncionarios.ShowDialog();
        }

        private void tsUnidadeMedida_Click(object sender, EventArgs e)
        {

        }

        private void tsObjetos_Click(object sender, EventArgs e)
        {
            FrmTodosObjetos frmTodosObjetos = new FrmTodosObjetos();
            frmTodosObjetos.ShowDialog();
        }
    }
}
