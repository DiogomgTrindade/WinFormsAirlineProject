using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoFinalVoos
{
    public partial class FormVerVoos : Form
    {
        List<Voo> Voos;
        public FormVerVoos()
        {
            InitializeComponent();
            Voos = new List<Voo>();
        }



        private void btnComprarBilhetes_Click(object sender, EventArgs e)
        {
            FormCompraBilhetes _formCompraBilhetes = new FormCompraBilhetes();
            _formCompraBilhetes.Show();
            this.Close();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void FormVerVoos_Load(object sender, EventArgs e)
        {
            List<Aparelho> Aparelhos = new List<Aparelho>();
            List<Bilhete> Bilhetes = new List<Bilhete>();


            Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            Carregar.CarregarVoos(Voos, Aparelhos, @"ListaVoos.txt");
            Carregar.CarregarBilhetes(Voos, Bilhetes, @"ListaBilhetes.txt");

            InitLista();


        }


        /// <summary>
        /// Inicializa a listBox
        /// </summary>
        private void InitLista()
        {
            listBoxVoos.Items.Clear();
            listBoxVoos.DataSource = Voos;
            listBoxVoos.DisplayMember = "DadosVoo";
        }


        /// <summary>
        /// Atualiza a listBox
        /// </summary>
        /// <param name="displayMember">será o DisplayMember atribuido à listBox</param>
        private void AtualizarLista(string displayMember)
        {
            listBoxVoos.DataSource = null;
            listBoxVoos.DataSource = Voos;
            listBoxVoos.DisplayMember = displayMember;
        }

        private void comboBoxOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxOrdenar.SelectedIndex == 0)
            {
                Voos = Voos.OrderBy(v => v.DataVoo).ToList();
                AtualizarLista("DadosVooData");
            }
            else if(comboBoxOrdenar.SelectedIndex == 1)
            {
                Voos = Voos.OrderBy(v => v.Origem).ToList();
                AtualizarLista("DadosVooOrigem");
            }
            else if (comboBoxOrdenar.SelectedIndex == 2)
            {
                Voos = Voos.OrderBy(v => v.DataVoo).ThenBy(v => v.Origem).ToList();
                AtualizarLista("DadosVoo");
            }
        }
    }
}
