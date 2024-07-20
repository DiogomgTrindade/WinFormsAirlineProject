using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalVoos
{
    public partial class FormSobre : Form
    {
        public FormSobre()
        {
            InitializeComponent();

        }

        private void FormSobre_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToString("d");
            linkLabelLinkedIn.Links.Add(0, linkLabelLinkedIn.Text.Length, "https://www.linkedin.com/in/diogo-trindade-0695b0313/");
        }



        private void linkLabelLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Link.LinkData.ToString()) { UseShellExecute = true });
        }
    }
}
