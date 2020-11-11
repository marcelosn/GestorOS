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
    public partial class FrmTodasOrdemServico : Form
    {
        public FrmTodasOrdemServico()
        {
            InitializeComponent();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            FrmOrdemServico frmOrdemServico = new FrmOrdemServico();
            frmOrdemServico.ShowDialog();
        }
    }
}
