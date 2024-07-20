using Biblioteca;

namespace ProjetoFinalVoos
{
    public partial class FormCompraBilhetes : Form
    {
        List<Voo> Voos;
        List<Aparelho> Aparelhos;
        int contaVoos;
        int contaBilhetes;
        List<Bilhete> Bilhetes;

        public FormCompraBilhetes()
        {
            InitializeComponent();
            Voos = new List<Voo>();
            Aparelhos = new List<Aparelho>();
            Bilhetes = new List<Bilhete>();
        }

        private void FormCompraBilhetes_Load(object sender, EventArgs e)
        {
            contaVoos = Carregar.CarregarVoosID(@"ContaVoos.txt");
            Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            Carregar.CarregarVoos(Voos, Aparelhos, @"ListaVoos.txt");


            Carregar.CarregarBilhetes(Voos, Bilhetes, @"ListaBilhetes.txt");
            contaBilhetes = Carregar.CarregarBilhetesID(@"ContaBilhetes");

            InitLista();
        }



        private void btnFecha_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCompraBilhete_Click(object sender, EventArgs e)
        {
            Voo vooEscolhido = (Voo)listBoxVoos.SelectedItem;

            Voo escolhido = null;

            if (vooEscolhido != null)
            {
                foreach (Voo voo in Voos)
                {
                    if (vooEscolhido.Id == voo.Id)
                    {
                        escolhido = voo;
                        break;
                    }

                }

                List<Bilhete> bilhetes = new List<Bilhete>();
                Carregar.CarregarBilhetes(Voos, bilhetes, @"ListaBilhetes.txt");

                FormBilhetes _formBilhetes = new FormBilhetes(this, vooEscolhido, bilhetes);
                _formBilhetes.Show();
            }
            else
            {
                MessageBox.Show("Tem de selecionar um voo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void InitLista()
        {
            listBoxVoos.Items.Clear();
            listBoxVoos.DataSource = Voos;
            listBoxVoos.DisplayMember = "Descricao";
        }

    }
}
