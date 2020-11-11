using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmTodosFuncionarios : Form
    {

        MeuDataContext meuDataContext;
        public Funcionario funcionario;

        public FrmTodosFuncionarios()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmTodosFuncionarios_Load(object sender, EventArgs e)
        {
            txtBuscar.Focus();
            CarregarTodosFuncionarios();
        }

        
        private void FrmTodosFuncionarios_KeyDown(object sender, KeyEventArgs e)
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

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void lwFuncionarios_DoubleClick(object sender, EventArgs e)
        {
            if (lwFuncionarios.Items.Count > 0)
            {
                int funcionarioId = int.Parse(lwFuncionarios.FocusedItem.SubItems[0].Text);

                funcionario = meuDataContext.Funcionarios.Find(funcionarioId);

                this.Close();
            }
        }

        private void CarregarTodosFuncionarios()
        {
            var funcionarios = meuDataContext.Funcionarios.AsNoTracking()
                                                .Where(s => s.Nome.Contains(txtBuscar.Text))
                                                .OrderBy(s => s.Nome).ToList();
            if (funcionarios.Count > 0)
            {
                lwFuncionarios.Items.Clear();
                int item = 0;

                foreach (var funcionario in funcionarios)
                {
                    lwFuncionarios.Items.Add(funcionario.Id.ToString());
                    lwFuncionarios.Items[item].SubItems.Add(funcionario.Nome);
                    lwFuncionarios.Items[item].SubItems.Add(funcionario.CPF);
                    lwFuncionarios.Items[item].SubItems.Add(funcionario.Celular);
                    item++;
                }
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarTodosFuncionarios();
        }
    }
}
