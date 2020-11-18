using GestorOS.Data;
using GestorOS.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestorOS
{
    public partial class FrmCliente : Form
    {
        MeuDataContext meuDataContext;

        Cliente cliente;
        Endereco endereco;

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
            //Novo
            if (cliente == null && endereco == null)
            {
                Salvar();
            }
            //Editar
            else
            {
                Alterar();
            }
        }

        private void Salvar()
        {
            if (ValidarCamposObrigatorios())
            {
                Cliente cliente = new Cliente();
                Endereco endereco = new Endereco();

                cliente.NomeFantasia = rbPessoaFisica.Checked ? txtNomeClienteRazaoSocial.Text : txtFantasia.Text;
                cliente.RazaoSocial = txtNomeClienteRazaoSocial.Text;
                cliente.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                cliente.Celular = string.IsNullOrEmpty(txtCelular.Text) ? cliente.Celular : txtCelular.Text;
                cliente.DataNascimento = txtDataNascimento.Text.Equals("  /  /") ? cliente.DataNascimento : Convert.ToDateTime(txtDataNascimento.Text);
                cliente.Documento = string.IsNullOrEmpty(txtDocumento.Text) ? cliente.Documento : txtDocumento.Text;
                cliente.Email = string.IsNullOrEmpty(txtEmail.Text) ? cliente.Email : txtEmail.Text;
                cliente.OrgaoEmissor = string.IsNullOrEmpty(txtOrgaoEmissor.Text) ? cliente.OrgaoEmissor : txtOrgaoEmissor.Text;
                cliente.RG = string.IsNullOrEmpty(txtRG.Text) ? cliente.RG : txtRG.Text;
                cliente.Telefone = string.IsNullOrEmpty(txtTelefoneFixo.Text) ? cliente.Telefone : txtTelefoneFixo.Text;
                cliente.TipoDocumento = rbPessoaFisica.Checked ? Enum.TipoDocumento.fisica : Enum.TipoDocumento.juridica;

                meuDataContext.Clientes.Add(cliente);
                meuDataContext.SaveChanges();

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

        private void Alterar()
        {
            if (ValidarCamposObrigatorios())
            {
                cliente.NomeFantasia = rbPessoaFisica.Checked ? txtNomeClienteRazaoSocial.Text : txtFantasia.Text;
                cliente.RazaoSocial = rbPessoaFisica.Checked ? txtNomeClienteRazaoSocial.Text : txtNomeClienteRazaoSocial.Text;
                cliente.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                cliente.Celular = string.IsNullOrEmpty(txtCelular.Text) ? cliente.Celular : txtCelular.Text;
                cliente.DataNascimento = txtDataNascimento.Text.Equals("  /  /") ? cliente.DataNascimento : Convert.ToDateTime(txtDataNascimento.Text);
                cliente.Documento = string.IsNullOrEmpty(txtDocumento.Text) ? cliente.Documento : txtDocumento.Text;
                cliente.Email = string.IsNullOrEmpty(txtEmail.Text) ? cliente.Email : txtEmail.Text;
                cliente.OrgaoEmissor = string.IsNullOrEmpty(txtOrgaoEmissor.Text) ? cliente.OrgaoEmissor : txtOrgaoEmissor.Text;
                cliente.RG = string.IsNullOrEmpty(txtRG.Text) ? cliente.RG : txtRG.Text;
                cliente.Telefone = string.IsNullOrEmpty(txtTelefoneFixo.Text) ? cliente.Telefone : txtTelefoneFixo.Text;
                cliente.TipoDocumento = rbPessoaFisica.Checked ? Enum.TipoDocumento.fisica : Enum.TipoDocumento.juridica;

                endereco.ClienteId = cliente.Id;
                endereco.DataHoraCadastro = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                endereco.Bairro = string.IsNullOrEmpty(txtBairro.Text) ? endereco.Bairro : txtBairro.Text;
                endereco.Cep = string.IsNullOrEmpty(txtCEP.Text) ? endereco.Cep : txtCEP.Text;
                endereco.Cidade = string.IsNullOrEmpty(txtCidade.Text) ? endereco.Cidade : txtCidade.Text;
                endereco.Complemento = string.IsNullOrEmpty(txtComplemento.Text) ? endereco.Complemento : txtComplemento.Text;
                endereco.Logradouro = string.IsNullOrEmpty(txtRua.Text) ? endereco.Logradouro : txtRua.Text;
                endereco.Numero = string.IsNullOrEmpty(txtNumero.Text) ? endereco.Numero : txtNumero.Text;
                endereco.UF = txtUF.SelectedIndex == 0 ? endereco.UF : txtUF.SelectedItem.ToString();

                meuDataContext.SaveChanges();

                Mensagem.MensgemAlteracao("Cliente");

                this.Close();
            }
        }

        private bool ValidarCamposObrigatorios()
        {
            if (string.IsNullOrWhiteSpace(txtNomeClienteRazaoSocial.Text) && rbPessoaFisica.Checked)
            {
                MessageBox.Show("Atenção! o campo nome do cliente é obrigatório.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeClienteRazaoSocial.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtNomeClienteRazaoSocial.Text) && rbPessoaJuridica.Checked)
            {
                MessageBox.Show("Atenção! o campo razão social do cliente é obrigatório.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeClienteRazaoSocial.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFantasia.Text) && rbPessoaJuridica.Checked)
            {
                MessageBox.Show("Atenção! o campo nome fantasia do cliente é obrigatório.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFantasia.Focus();
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
            txtNomeClienteRazaoSocial.Focus();
        }

        public void CarregaClienteEditar(int clienteId)
        {
            cliente = new Cliente();
            endereco = new Endereco();

            cliente = meuDataContext.Clientes.Find(clienteId);
            endereco = meuDataContext.Enderecos.FirstOrDefault(ed => ed.ClienteId == cliente.Id);

            if (cliente != null)
            {
                if (cliente.TipoDocumento == 0)
                {
                    rbPessoaFisica.Checked = true;
                    AlterarCamposPessoaFisica();
                }
                else
                {
                    rbPessoaJuridica.Checked = true;
                    AlterarCamposPessoaJuridica();
                }

                //Informações básica
                txtNomeClienteRazaoSocial.Text = cliente.RazaoSocial;
                txtFantasia.Text = cliente.NomeFantasia;
                txtDocumento.Text = cliente.Documento;
                txtDataNascimento.Text = cliente.DataNascimento.ToString();
                txtRG.Text = cliente.RG;
                txtOrgaoEmissor.Text = cliente.OrgaoEmissor;

                //Endereco
                txtCEP.Text = endereco.Cep;
                txtRua.Text = endereco.Logradouro;
                txtNumero.Text = endereco.Numero;
                txtBairro.Text = endereco.Bairro;
                txtCidade.Text = endereco.Cidade;
                txtUF.Text = endereco.UF == null ? "--Selecione--" : endereco.UF;
                txtComplemento.Text = endereco.Complemento;

                //Contato
                txtTelefoneFixo.Text = cliente.Telefone;
                txtCelular.Text = cliente.Celular;
                txtEmail.Text = cliente.Email;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            AlterarCamposPessoaFisica();
        }

        private void rbPessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            AlterarCamposPessoaJuridica();
        }

        private void AlterarCamposPessoaFisica()
        {
            lblCliente.Text = "Nome completo:";
            lblDocument.Text = "CPF:";
            lblFantasia.Text = "";
            txtDocumento.Mask = "999,999,999-99";
            txtRG.Enabled = true;
            txtDataNascimento.Enabled = true;
            txtOrgaoEmissor.Enabled = true;
            txtFantasia.Enabled = false;
            txtNomeClienteRazaoSocial.Focus();
        }

        private void AlterarCamposPessoaJuridica()
        {
            lblCliente.Text = "Razão Social:";
            lblFantasia.Text = "Nome Fantasia:";
            lblDocument.Text = "CNPJ:";
            txtDocumento.Mask = "99,999,999/9999-99";
            txtRG.Clear();
            txtOrgaoEmissor.Clear();
            txtDataNascimento.Enabled = false;
            txtOrgaoEmissor.Enabled = false;
            txtRG.Enabled = false;
            txtFantasia.Enabled = true;
            txtNomeClienteRazaoSocial.Focus();
        }
    }
}
