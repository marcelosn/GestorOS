using System.Windows.Forms;

namespace GestorOS
{
    public static class Mensagem
    {
        public static void MensgemSucesso(string entidade)
        {
            MessageBox.Show(entidade + " salvo com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensgemExclusão(string entidade)
        {
            MessageBox.Show(entidade + " exluido com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MensgemAlteracao(string entidade)
        {
            MessageBox.Show(entidade + " alterado com sucesso", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
