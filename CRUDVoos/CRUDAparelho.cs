using Biblioteca;

namespace ProjetoFinalVoos
{
    public partial class CRUDAparelho : Form
    {
        List<Aparelho> Aparelhos;
        List<Bilhete> Bilhete;
        List<Voo> voos;
        int contaAparelhos = 1;

        public CRUDAparelho()
        {
            InitializeComponent();
            Aparelhos = new List<Aparelho>();
            Bilhete = new List<Bilhete>();
            voos = new List<Voo>();

            txtId.Text = contaAparelhos.ToString();

            this.FormClosing += new FormClosingEventHandler(this.CRUDAparelho_FormClosing);
        }





        private void btnCriar_Click(object sender, EventArgs e)
        {
            Aparelho novoAparelho;

            if (ValidaForm())
            {
                novoAparelho = new Aparelho()
                {
                    Id = contaAparelhos,
                    Tipo = txtTipo.Text,
                    Capacidade = Convert.ToInt32(numericUpDown.Value),
                    Lugares = new List<int>()
                };

                for (int i = 0; i < novoAparelho.Capacidade; i++)
                {
                    novoAparelho.Lugares.Add(i + 1);
                }

                Aparelhos.Add(novoAparelho);
                contaAparelhos++;

                InitLista();


            }

            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            txtTipo.Clear();
            numericUpDown.Value = 0;
            txtId.Text = contaAparelhos.ToString();
            txtTipo.Focus();

            SalvarDados();
        }



        private void btnCancela_Click(object sender, EventArgs e)
        {
            txtTipo.Text = string.Empty;
            numericUpDown.Value = 0;
            txtTipo.Focus();
        }




        private void btnApagar_Click(object sender, EventArgs e)
        {
            Aparelho aparelhoAApagar = (Aparelho)AparelhosListBox.SelectedItem;

            Aparelho apagado = null;

            if (aparelhoAApagar != null)
            {
                foreach (Aparelho aparelho in Aparelhos)
                {
                    if (aparelhoAApagar.Id == aparelho.Id)
                    {
                        apagado = aparelho;
                    }
                }
                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem a certeza que pretende apagar  {apagado.Descricao}?",
                        "Apagar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        Aparelhos.Remove(apagado);
                        InitLista();
                        txtId.Text = contaAparelhos.ToString();

                        Bilhete.RemoveAll(bilhete => bilhete.GetAparelho(voos) == apagado.Id);
                        voos.RemoveAll(voo => voo.Aparelho.Id == apagado.Id);
                        SalvarDados();

                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um aparelho para apagar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEdita_Click(object sender, EventArgs e)
        {
            Aparelho aparelhoAEditar = (Aparelho)AparelhosListBox.SelectedItem;
            Aparelho editado = null;

            if (aparelhoAEditar != null)
            {
                foreach (Aparelho aparelho in Aparelhos)
                {
                    if (aparelhoAEditar.Id == aparelho.Id)
                    {
                        editado = aparelho;
                    }
                }

                FormEditarAparelho _formEditarAparelho = new FormEditarAparelho(this, editado);
                _formEditarAparelho.Show();


            }
            else
            {
                MessageBox.Show("Tem de selecionar um aparelho para editar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void CRUDAparelho_Load(object sender, EventArgs e)
        {
            Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            contaAparelhos = Carregar.CarregarAparelhosID(@"ContaAparelhos.txt");
            Carregar.CarregarVoos(voos, Aparelhos, @"ListaVoos.txt");
            Carregar.CarregarBilhetes(voos, Bilhete, @"ListaBilhetes.txt");


            txtId.Text = contaAparelhos.ToString();
            InitLista();

        }



        /// <summary>
        /// Faz o metódo para validar se está tudo preenchido corretamente
        /// </summary>
        /// <returns>true caso tenha sido tudo validado com sucesso; false caso contrário</returns>
        private bool ValidaForm()
        {
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Insira o tipo do Aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (numericUpDown.Value <= 0)
            {
                MessageBox.Show("Introduza uma capacidade válida para o Aparelho", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        /// <summary>
        /// Metodo para a ListBox estar sempre atualizada
        /// </summary>
        public void InitLista()
        {
            AparelhosListBox.DataSource = null;
            AparelhosListBox.DataSource = Aparelhos;
            AparelhosListBox.DisplayMember = "Descricao";
        }



        /// <summary>
        /// Salva os dados todos em ficheiros.txt
        /// </summary>
        public void SalvarDados()
        {
            Gravar.GravarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            Gravar.GravarAparelhosID(contaAparelhos, @"ContaAparelhos.txt");
            Gravar.GravarVoos(voos, @"ListaVoos.txt");
            Gravar.GravarBilhetes(Bilhete, @"ListaBilhetes.txt");
        }

        private void CRUDAparelho_FormClosing(object sender, FormClosingEventArgs e)
        {
            SalvarDados();
        }


        /// <summary>
        /// Atualiza a lista de bilhetes
        /// </summary>
        /// <param name="bilhetes">Lista de bilhetes</param>
        internal void AtualizaBilhetes(List<Bilhete> bilhetes)
        {
            Bilhete = bilhetes;
        }
    }
}
