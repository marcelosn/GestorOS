using GestorOS.Data;
using GestorOS.Models;
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
    public partial class FrmCliente : Form
    {
        MeuDataContext meuDataContext;

        public FrmCliente()
        {
            InitializeComponent();
            meuDataContext = new MeuDataContext();
        }

        private void FrmCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F4)
            {
                btnSalvar_Click(this, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCamposObrigatorios())
            {
                Cliente cliente = new Cliente();

                cliente.Celular = txtCelular.Text;
                cliente.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                cliente.DataNascimento = txtDataNascimento.Value;
                cliente.Documento = txtCpf.Text;
                cliente.Email = txtEmail.Text;
                cliente.NomeFantasia = txtNomeCliente.Text;
                cliente.OrgaoEmissor = txtOrgaoEmissor.Text;
                cliente.RG = txtRG.Text;
                cliente.Telefone = txtTelefoneFixo.Text;
                cliente.TipoDocumento = Enum.TipoDocumento.fisica;

                meuDataContext.Clientes.Add(cliente);
                meuDataContext.SaveChanges();

                Endereco endereco = new Endereco();

                endereco.ClienteId = cliente.Id;
                endereco.Bairro = txtBairro.Text;
                endereco.Cep = txtCEP.Text;
                endereco.Cidade = txtCidade.Text;
                endereco.Complemento = txtComplemento.Text;
                endereco.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                endereco.Logradouro = txtRua.Text;
                endereco.Numero = txtNumero.Text;
                endereco.UF = txtUF.SelectedItem.ToString();

                meuDataContext.Enderecos.Add(endereco);
                meuDataContext.SaveChanges();

                Mensagem.MensgemSucesso("Cliente");

                this.Close();
            }
        }
        
        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNomeCliente.Text))
            {
                MessageBox.Show("Atenção! o campo nome do cliente é obrigatório.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCliente.Focus();
                return false;
            }
            return true;
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            txtNomeCliente.Focus();
        }
    }
}
