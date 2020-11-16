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

                cliente.NomeFantasia = txtNomeCliente.Text;
                cliente.RazaoSocial = txtNomeCliente.Text;
                cliente.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                cliente.Celular = string.IsNullOrEmpty(txtCelular.Text) ? cliente.Celular : txtCelular.Text;
                cliente.DataNascimento = string.IsNullOrEmpty(txtDataNascimento.Text) ? cliente.DataNascimento : Convert.ToDateTime(txtDataNascimento.Text);
                cliente.Documento = string.IsNullOrEmpty(txtCpf.Text) ? cliente.Documento : txtCpf.Text;
                cliente.Email = string.IsNullOrEmpty(txtEmail.Text) ? cliente.Email : txtEmail.Text;
                cliente.OrgaoEmissor = string.IsNullOrEmpty(txtOrgaoEmissor.Text) ? cliente.OrgaoEmissor : txtOrgaoEmissor.Text;
                cliente.RG = string.IsNullOrEmpty(txtRG.Text) ? cliente.RG : txtRG.Text;
                cliente.Telefone = string.IsNullOrEmpty(txtTelefoneFixo.Text) ? cliente.Telefone : txtTelefoneFixo.Text;
                cliente.TipoDocumento = Enum.TipoDocumento.fisica;

                meuDataContext.Clientes.Add(cliente);
                meuDataContext.SaveChanges();

                Endereco endereco = new Endereco();

                endereco.ClienteId = cliente.Id;
                endereco.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                endereco.Bairro = string.IsNullOrEmpty(txtBairro.Text) ? endereco.Bairro : txtBairro.Text;
                endereco.Cep = string.IsNullOrEmpty(txtCEP.Text) ? endereco.Cep : txtCEP.Text;
                endereco.Cidade = string.IsNullOrEmpty(txtCidade.Text) ? endereco.Cidade : txtCidade.Text;
                endereco.Complemento = string.IsNullOrEmpty(txtComplemento.Text) ? endereco.Complemento : txtComplemento.Text;
                endereco.Logradouro = string.IsNullOrEmpty(txtRua.Text) ? endereco.Logradouro : txtRua.Text;
                endereco.Numero = string.IsNullOrEmpty(txtNumero.Text) ? endereco.Numero : txtNumero.Text;
                endereco.UF = txtUF.SelectedIndex == 0 ? endereco.UF : txtUF.SelectedItem.ToString();

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
            if (txtCelular.Text.Length != 11)
            {
                MessageBox.Show("Atenção! o campo celular é obrigatório.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCelular.Focus();
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
