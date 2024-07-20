using Biblioteca;
using System.Data;

namespace ProjetoFinalVoos
{
    public partial class FormEditarAparelho : Form
    {
        Aparelho _editado;
        CRUDAparelho _form;

        List<Voo> voos;
        List<Aparelho> Aparelhos;

        public FormEditarAparelho(CRUDAparelho form, Aparelho editado)
        {
            InitializeComponent();
            voos = new List<Voo>();
            Aparelhos = new List<Aparelho>();

            _editado = editado;
            _form = form;

            txtId.Text = editado.Id.ToString();
            txtTipo.Text = editado.Tipo.ToString();
            numericUpDown.Value = editado.Capacidade;

            CarregarDados();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuarda_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                int novaCapacidade = Convert.ToInt32(numericUpDown.Value);

                // Se a capacidade mudou, ajuste nos bilhetes
                if (_editado.Capacidade != novaCapacidade)
                {
                    // Atualiza a capacidade do aparelho
                    _editado.Capacidade = novaCapacidade;

                    // Atualiza os bilhetes relacionados
                    List<Bilhete> bilhetes = AtualizarBilhetesAparelho(_editado);


                    _form.AtualizaBilhetes(bilhetes);
                }

                _editado.Tipo = txtTipo.Text;
                _form.InitLista();
                _form.SalvarDados();
                this.Close();
            }
        }




        /// <summary>
        /// Faz o metódo para validar se está tudo preenchido corretamente
        /// </summary>
        /// <returns>true caso tenha sido tudo validado com sucesso; false caso contrário</returns>
        private bool ValidaForm()
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Insira o Tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (numericUpDown.Value < 0)
            {
                MessageBox.Show("Insira uma capacidade válida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;
        }


        private List<Bilhete> AtualizarBilhetesAparelho(Aparelho aparelhoEditado)
        {
            List<Bilhete> bilhetes = new List<Bilhete>();
            Carregar.CarregarBilhetes(voos, bilhetes, @"ListaBilhetes.txt");

            foreach (var voo in voos.Where(v => v.Aparelho != null && v.Aparelho.Id == aparelhoEditado.Id))
            {
                // Remove bilhetes antigos
                bilhetes.RemoveAll(b => b.IdVoo == voo.Id);

                // Adiciona novos bilhetes com a nova capacidade
                for (int i = 0; i < aparelhoEditado.Capacidade; i++)
                {
                    bilhetes.Add(new Bilhete
                    {
                        IdVoo = voo.Id,
                        Lugar = i + 1,
                        Ocupado = false,
                        Passageiro = string.Empty
                    });
                }
            }

            // Salvar os bilhetes atualizados no arquivo sem duplicações
            //GravarBilhetesNoArquivo(bilhetes);
            Gravar.GravarBilhetes(bilhetes, @"ListaBilhetes.txt");
            return bilhetes;
        }


        /// <summary>
        /// Vai gravar os bilhetes no ficheiro.txt depois de alterar o Aparelho de modo a não haver duplicações no ficheiro.
        /// </summary>
        /// <param name="bilhetes"></param>
        private void GravarBilhetesNoArquivo(List<Bilhete> bilhetes)
        {
            var linhas = bilhetes.Select(b => $"{b.IdVoo};{b.Lugar};{b.Ocupado};{b.Passageiro}");
            File.WriteAllLines(@"ListaBilhetes.txt", linhas);
        }



        /// <summary>
        /// Carrega os dados da aplicação, a lista dos Voos e a lista dos Aparelhos
        /// </summary>
        private void CarregarDados()
        {
            // Carregar dados dos voos e aparelhos
            Carregar.CarregarAparelhos(Aparelhos, @"ListaAparelhos.txt");
            Carregar.CarregarVoos(voos, Aparelhos, @"ListaVoos.txt");
        }
    }
}
