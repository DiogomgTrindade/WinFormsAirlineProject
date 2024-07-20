using ProjetoFinalVoos;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace CRUDVoos
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();

        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            FormSobre _formSobre = new FormSobre();
            _formSobre.Show();
        }

       
        private void btnCriarVoo_Click(object sender, EventArgs e)
        {
            CRUDVoo _crudVoo = new CRUDVoo();
            _crudVoo.Show();
        }

        private void btnCriarAparelho_Click(object sender, EventArgs e)
        {
            CRUDAparelho _crudAparelho = new CRUDAparelho();
            _crudAparelho.Show();
        }

        private void btnComprarBilhetes_Click(object sender, EventArgs e)
        {
            FormCompraBilhetes _formCompraBilhetes = new FormCompraBilhetes();
            _formCompraBilhetes.Show();
        }

        private void btnVerVoos_Click(object sender, EventArgs e)
        {
            FormVerVoos _formVerVoos = new FormVerVoos();
            _formVerVoos.Show();
        }

    }
}
